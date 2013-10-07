using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;
using System;

namespace CurrencyConverterApp
{
    class ExtractDataToCSV
    {
        public void ExtractToCSV(DataGridView dataGridView)
        {
            CultureInfo oldcult = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("EN-us");
            try
            {
                var save = new SaveFileDialog
                {
                    AddExtension = true,
                    DefaultExt = "bin",
                    Filter = @"CSV-файл (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true

                };

                if (save.ShowDialog() != DialogResult.OK) return;
                var sw = new StreamWriter(save.FileName, true, Encoding.UTF8);
                int i;


                for (i = 0; i < dataGridView.ColumnCount; i++)
                {
                    sw.Write(dataGridView.Columns[i].HeaderText.ToString());
                    if (i < dataGridView.ColumnCount - 1)
                    {
                        sw.Write(";");
                    }

                }
                sw.Write(sw.NewLine);
                foreach (DataGridViewRow row in dataGridView.Rows)
                    if (!row.IsNewRow)
                    {
                        var first = true;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (!first) sw.Write(";");
                            if (cell.Value != null)
                            {
                                sw.Write(cell.Value.ToString());
                            }
                            else
                            {
                                continue;
                            }
                            first = false;
                        }
                        sw.WriteLine();
                    }
                sw.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, "Error in saving CSV file");
                return;
            }
            finally
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = oldcult;
            }
        }
        
    }
    
}
