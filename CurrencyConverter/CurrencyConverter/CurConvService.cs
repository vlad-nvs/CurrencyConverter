using System;
using System.Collections.Generic;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace CurrencyConverter
{

    #region Classes for Service Methodes
    public class MyValues
    {
        public List<string> Errors = new List<string>();
        public List<string> Date = new List<string>();
        public List<string> Currency = new List<string>();
        public List<string> Rate = new List<string>();
    }

    public class MyValues_Convert
    {
        public string result;
        public string rateA;
        public string rateB;
        public string errors;
    }
    #endregion

    public class CurConvService : CurConvIService
    {
        #region Global
       
        string off_line_xml = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
        Regex regex = new Regex(@"^[0-9-,.]*$");
       
        
        //string off_line_xml = AppDomain.CurrentDomain.BaseDirectory + @"\eurofxref-hist-90d.xml";
        static string sPattern = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";
        #endregion

        #region Check Internet connection
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.ecb.europa.eu"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region GetData Method
        public MyValues GetData(string currency, string startdate, string enddate)
        {
            if (CheckForInternetConnection() == false)
            {
                MyValues CurrencyInfo = new MyValues();
                CurrencyInfo.Errors.Add("error_connection");
                return CurrencyInfo;
            }
            try
            {
                int startexist = 0, endexist = 0, curexist = 0;
                MyValues CurrencyInfo = new MyValues();
                
                string relationship;
                XmlTextReader reader_get_data = new XmlTextReader(off_line_xml);
                XmlTextReader reader_get_errors = new XmlTextReader(off_line_xml);
                XmlTextReader reader_get_data_2 = new XmlTextReader(off_line_xml);

                #region Errors
                while (reader_get_errors.Read())
                {
                    if (reader_get_errors.HasAttributes)
                    {
                        for (int i = 0; i < reader_get_errors.AttributeCount; i++)
                        {
                            reader_get_errors.MoveToAttribute(i);
                            if (reader_get_errors.Value == startdate)
                            {
                                startexist++;
                            }
                            if (reader_get_errors.Value == enddate)
                            {
                                endexist++;
                            }
                            if (currency != "")
                            {
                                if (reader_get_errors.Value == currency)
                                {
                                    curexist++;
                                }
                            }
                        }
                        reader_get_errors.MoveToElement();
                    }
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(startdate, sPattern) == false)
                {
                    CurrencyInfo.Errors.Add("error_startdate_format");
                    return CurrencyInfo;
                }
                
                if (startexist == 0 || startdate == "")
                {
                    CurrencyInfo.Errors.Add("error_startdate");
                    return CurrencyInfo;
                }
                if (endexist == 0 || enddate == "")
                {
                    CurrencyInfo.Errors.Add("error_enddate");
                    return CurrencyInfo;
                }
                if (currency != "" && curexist == 0)
                {

                    CurrencyInfo.Errors.Add("error_currency");
                    return CurrencyInfo; ;
                }
                DateTime start = DateTime.Parse(startdate);
                DateTime end = DateTime.Parse(enddate);
                int result = DateTime.Compare(start, end);
                if (result < 0)
                {
                    relationship = "is earlier than";
                    CurrencyInfo.Errors.Add(relationship);
                    return CurrencyInfo;
                }
                else if (result == 0)
                {
                    relationship = "is the same time as";
                    CurrencyInfo.Errors.Add(relationship);
                    return CurrencyInfo;
                }
                else
                {
                    relationship = "is later than";
                #endregion

                    while (reader_get_data.Read())
                    {
                        if (reader_get_data.GetAttribute("time") == startdate)
                        {
                            CurrencyInfo.Date.Add(reader_get_data.GetAttribute("time"));
                            while (reader_get_data.Read() && reader_get_data.GetAttribute("time") != enddate)
                            {
                                if (currency != "")
                                {
                                    CurrencyInfo.Date.Add(reader_get_data.GetAttribute("time"));
                                    if (reader_get_data.GetAttribute("currency") == currency)
                                    {
                                        CurrencyInfo.Currency.Add("\"" + reader_get_data.GetAttribute("currency") + " - " + reader_get_data.GetAttribute("rate") + "\"");
                                    }
                                }
                                else
                                {
                                    CurrencyInfo.Currency.Add("\"" + reader_get_data.GetAttribute("currency") + " - " + reader_get_data.GetAttribute("rate") + "\"");
                                    CurrencyInfo.Date.Add(reader_get_data.GetAttribute("time"));
                                }
                            }
                        }
                    }
                    
                }

                CurrencyInfo.Date.RemoveAll(item => item == null);
                CurrencyInfo.Date.RemoveAll(item => item == "");
                CurrencyInfo.Currency.RemoveAll(item => item == null);
                CurrencyInfo.Currency.RemoveAll(item => item == "");
                CurrencyInfo.Currency.RemoveAll(item => item == "\" - \"");
                CurrencyInfo.Errors.RemoveAll(item => item == null);
                CurrencyInfo.Errors.RemoveAll(item => item == "");

                return CurrencyInfo;
            }
            catch
            {
                MyValues CurrencyInfo = new MyValues();
                CurrencyInfo.Errors.Add("Something went wrong in WCF Service!!!");
                return CurrencyInfo;
            }
        }
        #endregion

        #region Convert Method
        public MyValues_Convert Convert(string currencyA, string currencyB, string date, string SumXinA)
       {
           //if (CheckForInternetConnection() == false)
           //{
           //    MyValues_Convert my_convert_val = new MyValues_Convert();
           //    my_convert_val.errors = "error_connection";
           //    return my_convert_val;
           //}
           try
           {
               int dateexist = 0, curAexist = 0, curBexist = 0;
               List<string> times = new List<string>();
              
               MyValues_Convert my_convert_val = new MyValues_Convert();

               XmlTextReader reader_get_time = new XmlTextReader(off_line_xml);
               XmlTextReader reader_get_rateA_rateB = new XmlTextReader(off_line_xml);
               XmlTextReader reader_get_errors = new XmlTextReader(off_line_xml);

               #region Errors
               while (reader_get_errors.Read())
               {
                   if (reader_get_errors.HasAttributes)
                   {
                       for (int i = 0; i < reader_get_errors.AttributeCount; i++)
                       {
                           reader_get_errors.MoveToAttribute(i);
                           if (reader_get_errors.Value == date)
                           {
                               dateexist++;
                           }

                           if (currencyA != "")
                           {
                               if (reader_get_errors.Value == currencyA)
                               {
                                   curAexist++;
                               }
                           }
                           if (currencyB != "")
                           {
                               if (reader_get_errors.Value == currencyB)
                               {
                                   curBexist++;
                               }
                           }
                       }
                       reader_get_errors.MoveToElement();
                   }
               }
               if (System.Text.RegularExpressions.Regex.IsMatch(date, sPattern) == false && date != "")
               {
                   my_convert_val.errors = "error_date_format";
                   return my_convert_val;
               }
              
               if ((currencyA != "" && curAexist == 0) || currencyA == "")
               {
                   my_convert_val.errors = "error_currencyA";
                   return my_convert_val;
               }
               if ((currencyB != "" && curBexist == 0) || currencyB == "")
               {
                   my_convert_val.errors = "error_currencyB";
                   return my_convert_val;
               }
               if (dateexist == 0 || date == "")
               {
                   my_convert_val.errors = "error_date";
                   return my_convert_val;
               }
               if (currencyA == currencyB)
               {
                   my_convert_val.errors = "error_currencyB_currencyA";
                   return my_convert_val;
               }
               if (regex.IsMatch(SumXinA) == false || SumXinA == "")
               {
                   my_convert_val.errors = "error_sum_numbers";
                   return my_convert_val;
               }
               #endregion

               while (reader_get_time.Read())
               {
                   times.Add(reader_get_time.GetAttribute("time"));
               }

               string next_date = null;
               times.RemoveAll(item => item == null);
               times.RemoveAll(item => item == "");
               for (int i = 0; i < times.Count; i++)
               {
                   if (times[i] == date)
                   {
                       try
                       {
                           next_date = times[i + 1];
                       }
                       catch { continue; }
                   }
               }
              
               while (reader_get_rateA_rateB.Read())
               {
                   if (reader_get_rateA_rateB.GetAttribute("time") == date)
                   {
                       if (next_date != null)
                       {
                           while ((reader_get_rateA_rateB.Read() && reader_get_rateA_rateB.GetAttribute("time") != next_date))
                           {
                               if (reader_get_rateA_rateB.GetAttribute("currency") == currencyA)
                               {
                                   my_convert_val.rateA = reader_get_rateA_rateB.GetAttribute("rate");
                               }
                               else if (reader_get_rateA_rateB.GetAttribute("currency") == currencyB)
                               {
                                   my_convert_val.rateB = reader_get_rateA_rateB.GetAttribute("rate");
                               }
                           }
                       }
              
                   else
                   {
                       while (reader_get_rateA_rateB.Read() && reader_get_rateA_rateB.EOF != true)
                           {
                               if (reader_get_rateA_rateB.GetAttribute("currency") == currencyA)
                               {
                                   my_convert_val.rateA = reader_get_rateA_rateB.GetAttribute("rate");
                               }
                               else if (reader_get_rateA_rateB.GetAttribute("currency") == currencyB)
                               {
                                   my_convert_val.rateB = reader_get_rateA_rateB.GetAttribute("rate");
                               }
                           }
                       }
                   
                    }
                   }
               
               double r = System.Convert.ToDouble(SumXinA.Replace('.', ',')) * System.Convert.ToDouble(my_convert_val.rateA.Replace('.', ',')) * System.Convert.ToDouble(my_convert_val.rateB.Replace('.', ','));
               string jjj = r.ToString();
               my_convert_val.result = jjj;

               return my_convert_val;
           }
           catch
           {
               MyValues_Convert my_convert_val = new MyValues_Convert();
               my_convert_val.errors = "Something went wrong in WCF Service!!!";
               return my_convert_val;
           }
       }
        #endregion

        #region GetDataUsingDataContract
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        #endregion
    }
}
