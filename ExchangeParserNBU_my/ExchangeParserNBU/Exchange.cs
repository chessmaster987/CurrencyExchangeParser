using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExchangeParserNBU
{
    class Exchange
    {
        //1 UAH to 1 SomeCurrency
        public static double ParsedExchangeCourse(List<object> list)
        {
            int units = Convert.ToInt32(list[0]);
            var amount = Convert.ToDouble(list[1].ToString().Replace(".", ","));
            var exchangeCourse = units == 1 ? amount : amount / units;

            return exchangeCourse;
        }
    }
}
