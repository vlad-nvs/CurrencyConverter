using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace CurrencyConverterApp
{
    public partial class Currency_Converter : Form
    {
        
        #region Global
        ToolTip toolTip = new ToolTip();
        int index_space, date_length, currency_length;
        static string substring_currency, substring_first_currency, res, errors;
        static string[] Errors = {""};
        
        ServiceReference.CurConvIServiceClient client = new ServiceReference.CurConvIServiceClient();
        ExtractDataToCSV ExtractToCsv = new ExtractDataToCSV();
        
        #endregion

        public Currency_Converter()
        {
            try
            {
                InitializeComponent();
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Something went wrong in Initialize!");
                return;
            }
        }
      
        #region ClickEevents for Buttons

            private void getData_Click(object sender, EventArgs e)
            {
                GetData();
            }
         
            private void convert_button_Click(object sender, EventArgs e)
            {
                Converting();
            }

            private void export_button_Click(object sender, EventArgs e)
            {
                ExtractToCsv.ExtractToCSV(dataGridView);
            }

        #endregion

        #region Click Events for textBoxes
        private void currency_textbox_Click(object sender, EventArgs e)
        {
            currency_textBox.BackColor = Color.White;
            toolTip.Hide(currency_textBox);
        }

        private void startDate_textBox_Click(object sender, EventArgs e)
        {
            startDate_textBox.BackColor = Color.White;
            toolTip.Hide(startDate_textBox);
        }

        private void endDate_textBox_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Errors.Length; i++)
                {
                    if (Errors[i] == "is the same time as")
                    {
                        startDate_textBox.BackColor = Color.White;
                        endDate_textBox.BackColor = Color.White;
                    }
                    else
                    {
                        endDate_textBox.BackColor = Color.White;
                    }
                }
                toolTip.Hide(endDate_textBox);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Something went wrong!!!");
                return;
            }
        }
        private void currencyA_textBox_Click(object sender, EventArgs e)
        {
            try
            {
                string Errors = client.Convert(currencyA_textBox.Text, currencyB_textBox.Text, date_textBox.Text, sumXinA_textBox.Text).errors;
                if (Errors == "error_currencyB_currencyA")
                {
                    currencyA_textBox.BackColor = Color.White;
                    currencyB_textBox.BackColor = Color.White;
                }
                else
                {
                    currencyA_textBox.BackColor = Color.White;
                }
                toolTip.Hide(currencyA_textBox);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Something went wrong!!!");
                return;
            }
        }

        private void currencyB_textBox_Click(object sender, EventArgs e)
        {
            try
            {
                string Errors = client.Convert(currencyA_textBox.Text, currencyB_textBox.Text, date_textBox.Text, sumXinA_textBox.Text).errors;
                if (Errors == "error_currencyB_currencyA")
                {
                    currencyA_textBox.BackColor = Color.White;
                    currencyB_textBox.BackColor = Color.White;
                }
                else
                {
                    currencyB_textBox.BackColor = Color.White;
                }
                toolTip.Hide(currencyB_textBox);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Something went wrong!!!");
                return;
            }
        }

        private void date_textBox_Click(object sender, EventArgs e)
        {
            date_textBox.BackColor = Color.White;
            toolTip.Hide(date_textBox);
        }
        private void sumXinA_textBox_Click(object sender, EventArgs e)
        {
            sumXinA_textBox.BackColor = Color.White;
            toolTip.Hide(sumXinA_textBox);
        }
        #endregion   
        
        #region Get Data
        private void GetData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (GetDataErrors())
                {
                    return;
                }

                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                dataGridView.Update();
                dataGridView.Refresh();

                List<string> Date = new List<string>();
                List<string> Currency = new List<string>();
                List<string> Error = new List<string>();
                date_length = client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Date.Length;
                currency_length = client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Currency.Length;

                for (int i = 0; i < date_length; i++)
                {
                    Date.Add(client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Date[i]);
                }
                for (int i = 0; i < currency_length; i++)
                {
                    Currency.Add(client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Currency[i]);
                }

                for (int i = 0; i < date_length; i++)
                {
                    dataGridView.Columns.Add(new DataGridViewColumn() { HeaderText = Date[i], DataPropertyName = Date[i], CellTemplate = new DataGridViewTextBoxCell() });
                }
                int rows_length = 33;
                if (currency_textBox.Text != "")
                {
                    rows_length = 1;
                }

                for (int i = 0; i < rows_length; i++)
                {
                    dataGridView.Rows.Add();
                }
                int rows_index = 0;
                for (int i = -1; i < date_length - 1; )
                {
                    for (int j = 0; j < currency_length; j++)
                    {
                        index_space = Currency[j].IndexOf(' ');
                        substring_currency = Currency[j].Substring(0, index_space);
                        substring_first_currency = Currency[0].Substring(0, index_space);

                        if (substring_currency == substring_first_currency)
                        {
                            rows_index = 0;
                            i++;
                        }
                        dataGridView.Rows[rows_index].Cells[i].Value = Currency[j];
                        rows_index++;
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.StackTrace,"Error in Get Data Method!");
                return;
            }
        }
        #endregion

        #region Converting
        private void Converting ()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (ConvertingErrors())
                {
                    return;
                }
                rateA_res_label.Text = client.Convert(currencyA_textBox.Text, currencyB_textBox.Text, date_textBox.Text, sumXinA_textBox.Text).rateA;
                rateB_res_label.Text = client.Convert(currencyA_textBox.Text, currencyB_textBox.Text, date_textBox.Text, sumXinA_textBox.Text).rateB;
                res = client.Convert(currencyA_textBox.Text, currencyB_textBox.Text, date_textBox.Text, sumXinA_textBox.Text).result;
                res_label.Text = res;

                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Error in Converting Method!");
                return;
            }
        }
        #endregion

        #region Errors

        #region GetData Method Errors
        private bool GetDataErrors()
        {
            try
            {
            Errors = client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Errors;
                for (int i = 0; i < client.GetData(currency_textBox.Text, startDate_textBox.Text, endDate_textBox.Text).Errors.Length; i++)
                {
                    if (Errors[i] == "error_connection")
                    {
                        MessageBox.Show("Your PC can't connect to http://www.ecb.europa.eu! Chek connection to Internet!\n Do you want work with off-line data?", "Connection Error!", MessageBoxButtons.OK);
                        return true;
                    }
                    if (Errors[i] == "error_startdate_format")
                    {
                        startDate_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for start date! Wrong format! Enter date in format \"yyyy-mm-dd\".", startDate_textBox);
                        return true;
                    }
                    if (Errors[i] == "error_startdate_format")
                    {
                        endDate_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for end date! Wrong format! Enter date in format \"yyyy-mm-dd\".", startDate_textBox);
                        return true;
                    }
                    if (Errors[i] == "Something went wrong in WCF Service!!!")
                    {
                        MessageBox.Show("Something went wrong in WCF Service!!!");
                        return true;
                    }
                    if (Errors[i] == "error_startdate")
                    {
                        startDate_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for start date! No such date! Try another one.", startDate_textBox);
                        return true;
                    }
                    if (Errors[i] == "error_enddate")
                    {
                        endDate_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for end date! No such date! Try another one.", endDate_textBox);
                        return true;
                    }
                    if (Errors[i] == "error_currency")
                    {
                        currency_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for currency! No such currency! Try another one.", currency_textBox);
                        return true;
                    }
                    if (Errors[i] == "is earlier than")
                    {
                        startDate_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for start date! It's earlier than end date!", startDate_textBox);
                        return true;
                    }
                    if (Errors[i] == "is the same time as")
                    {
                        startDate_textBox.BackColor = Color.Orange;
                        endDate_textBox.BackColor = Color.Orange;
                        toolTip.Show("Error for dates! It's same!", endDate_textBox);
                        return true;
                    }
                }
                export_button.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Something went wrong in GetData Method Errors!");
                return true;
            }
            return false;
        }
        #endregion

        #region Converting Method Errors
        private bool ConvertingErrors()
        {
            try
            {
                errors = client.Convert(currencyA_textBox.Text, currencyB_textBox.Text, date_textBox.Text, sumXinA_textBox.Text).errors;
                if (errors == "error_connection")
                {
                    MessageBox.Show("Your PC can't connect to http://www.ecb.europa.eu! Chek connection to Internet!\n Do you want work with off-line data?", "Connection Error!", MessageBoxButtons.OK);
                    return true;
                }
                if (errors == "Something went wrong in WCF Service!!!")
                {
                    MessageBox.Show("Something went wrong in WCF Service!!!", "WCF Service Error!");
                    return true;
                }
                if (errors == "error_currencyA")
                {
                    currencyA_textBox.BackColor = Color.Orange;
                    toolTip.Show("Error for currency \"A\"! No such currency! Try another one.", currencyA_textBox);
                    return true;
                }
                if (errors == "error_currencyB")
                {
                    currencyB_textBox.BackColor = Color.Orange;
                    toolTip.Show("Error for currency \"B\"! No such currency! Try another one.", currencyB_textBox);
                    return true;
                }
                if (errors == "error_currencyB_currencyA")
                {
                    currencyA_textBox.BackColor = Color.Orange;
                    currencyB_textBox.BackColor = Color.Orange;
                    toolTip.Show("Error for currencies! It's same! Try again.", currencyB_textBox);
                    return true;
                }
                if (errors == "error_date_format")
                {
                    date_textBox.BackColor = Color.Orange;
                    toolTip.Show("Error for Date! You need enter only numbers! Try again.", date_textBox);
                    return true;
                }

                if (errors == "FATAL ERROR!")
                {
                    MessageBox.Show("FATAL ERROR!!!");
                    return true;
                }
                if (errors == "error_date")
                {
                    date_textBox.BackColor = Color.Orange;
                    toolTip.Show("Error for date! No such date! Try another one.", date_textBox);
                    return true;
                }
                if (errors == "error_sum_numbers")
                {
                    sumXinA_textBox.BackColor = Color.Orange;
                    toolTip.Show("Error for Sum! You need enter only numbers! Try again.", sumXinA_textBox);
                    return true;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Something went wrong in Converting Method Errors!");
                return true;
            }
            return false;  
        }
       
           #endregion

        #endregion

    }
}
