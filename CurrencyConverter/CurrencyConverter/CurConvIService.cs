using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConverter
{
    [ServiceContract]
    public interface CurConvIService
    {
        [OperationContract]
        MyValues GetData(string currency, string startdate, string enddate);
        [OperationContract]
        MyValues_Convert Convert(string currencyA, string currencyB, string date, string SumXinA);
         
        CompositeType GetDataUsingDataContract(CompositeType composite);

    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
