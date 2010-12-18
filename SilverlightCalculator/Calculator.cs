using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Browser;

namespace SilverlightCalculator
{
    public class Calculator
    {
        [ScriptableMember]
        public string Multiply(string value1, string value2)
        {
            var decimal_1 = System.Convert.ToDecimal(value1);
            var decimal_2 = System.Convert.ToDecimal(value2);
            return (decimal_1*decimal_2).ToString();
        }

        [ScriptableMember]
        public string Add(string value1, string value2)
        {
            var decimal_1 = System.Convert.ToDecimal(value1);
            var decimal_2 = System.Convert.ToDecimal(value2);
            return (decimal_1 + decimal_2).ToString();
        }

        [ScriptableMember]
        public string Divide(string value1, string value2)
        {
            var decimal_1 = System.Convert.ToDecimal(value1);

            var decimal_2 = System.Convert.ToDecimal(value2);

            return (decimal_1/decimal_2).ToString();
        }

        [ScriptableMember]
        public string Subtract(string value1, string value2)
        {
            var decimal_1 = System.Convert.ToDecimal(value1);

            var decimal_2 = System.Convert.ToDecimal(value2);

            return (decimal_1 - decimal_2).ToString();
        }

        [ScriptableMember]
        public string AddSeries(string series)
        {
            var returnValue = 0.0m;
          
            var parts = series.Split(System.Convert.ToChar(","));
            foreach(string part in parts)
            {
                returnValue += System.Convert.ToDecimal(part);
            }
            return returnValue.ToString();
        }

    }
}