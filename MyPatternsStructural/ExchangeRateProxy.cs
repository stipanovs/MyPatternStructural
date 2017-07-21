using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace MyPatternsStructural
{
    interface ICurrencyExchangeRate
    {
        string EURExchangeRate { get; }
        string USDExchangeRate { get; }
        string UAHExchangeRate { get; }
        string RUBExchangeRate { get; }
        string RONExchangeRate { get; }

    }

    class ExchangeRate : ICurrencyExchangeRate
    {
        public string EURExchangeRate => throw new NotImplementedException();

        public string USDExchangeRate => throw new NotImplementedException();

        public string UAHExchangeRate => throw new NotImplementedException();

        public string RUBExchangeRate => throw new NotImplementedException();

        public string RONExchangeRate => throw new NotImplementedException();
    }
    class ExchangeRateProxy : ICurrencyExchangeRate
    {
        public string EURExchangeRate{ get { return GetResponseFromServer(DateTime.Now, "978"); }}

        public string USDExchangeRate { get { return GetResponseFromServer(DateTime.Now, "840"); } }

        public string UAHExchangeRate { get { return GetResponseFromServer(DateTime.Now, "980"); } }

        public string RUBExchangeRate { get { return GetResponseFromServer(DateTime.Now, "643"); } }

        public string RONExchangeRate { get { return GetResponseFromServer(DateTime.Now, "946"); } }

        private string GetResponseFromServer(DateTime date, string code)
        {
            string result = string.Empty;

            string xmlString = string.Empty;

            string requestDate = string.Format("{0}.{1:D2}.{2}", date.Day, date.Month, date.Year);

            string url = @"https://www.bnm.md/ro/official_exchange_rates?get_xml=1&date=" + requestDate;

            try
            {
                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                StreamReader streamReader = new StreamReader(dataStream);

                xmlString = streamReader.ReadToEnd();

                streamReader.Close();
                response.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            StringBuilder output = new StringBuilder();

            // xml parser
           
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);

            XmlNodeList elemList = doc.GetElementsByTagName("Valute");
            
            for (int i = 0; i < elemList.Count; i++)
            {
                XmlNode numCode = elemList[i].SelectSingleNode("NumCode");
                XmlNode valueNode = elemList[i].SelectSingleNode("Value");
                if (numCode.InnerText == code) // codul valutei
                {
                    output.AppendLine(valueNode.InnerText);
                }
            }

            result = output.ToString();
            
            return result;
        }

    }
}
