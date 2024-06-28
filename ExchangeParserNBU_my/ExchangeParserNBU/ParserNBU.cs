using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExchangeParserNBU
{
    class ParserNBU
    {
        //Парсинг API и получение списка из [units, amount] для некоторой валюты и даты
        public static List<object> Parse(string ID, string date)
        {
            string data = "";
            using (WebClient wc = new WebClient())
            {
                data = wc.DownloadString(@"https://bank.gov.ua/NBU_Exchange/exchange?date=" + date);
            }
            Match match = Regex.Match(data, $"<CurrencyCodeL>{ID}</CurrencyCodeL>.*?<Units>(.*?)</Units>.*?<Amount>(.*?)</Amount>", RegexOptions.Singleline);
            List<object> templist = new List<object>() { match.Groups[1].Value, match.Groups[2].Value };

            return templist;
        }

        //Записываем ВСЕ наименования валют в файл типа .txt
        public static void WriteInFileAllCurrency()
        {
            string filePath = "cIndices.txt";
            var arrInd = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("https://bank.gov.ua/NBU_Exchange/exchange?date=");
            XmlNodeList elemList = xDoc.GetElementsByTagName("CurrencyCodeL");
            for (int index2AddList = 0; index2AddList < elemList.Count; index2AddList++)
            {
                string middleIndString = elemList[index2AddList].InnerText;
                arrInd.Add(middleIndString);
            }
            FileStream fileStream = File.Open(filePath, FileMode.Create);
            StreamWriter output = new StreamWriter(fileStream);
            for (int index2AddFile = 0; index2AddFile < arrInd.Count; index2AddFile++)
            {
                output.Write(arrInd[index2AddFile] + "\n");
            }
            output.Close();
        }

    }
}