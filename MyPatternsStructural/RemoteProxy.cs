using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyPatternsStructural
{
    class RemoteProxy
    {
        public string GetResponseFromServer(string input, DateTime date)
        {
            string result = string.Empty;
            

            string requestDate = string.Format("{0}.{1:D2}.{2}", date.Day, date.Month, date.Year);
            string url = @"https://www.bnm.md/ro/official_exchange_rates?get_xml=1&date=" + requestDate;

            try
            {
                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                StreamReader streamReader = new StreamReader(dataStream);

                result = streamReader.ReadToEnd();

                //Console.WriteLine(result);

                streamReader.Close();
                response.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            StringBuilder output = new StringBuilder();

            // xml parser
            string xmlString = result;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString), settings))
            {
                //xmlReader.MoveToContent();

                //xmlReader.ReadToFollowing("Valute");
                //xmlReader.MoveToFirstAttribute();
                //string ValutaID = xmlReader.Value;

                //output.AppendLine("The valute ID: " + ValutaID);

                //xmlReader.ReadToFollowing("NumCode");
                //output.AppendLine("     NumCode: " + xmlReader.ReadElementContentAsString());

                //xmlReader.ReadToFollowing("CharCode");
                //output.AppendLine("     CharCode: " + xmlReader.ReadElementContentAsString());

                //xmlReader.ReadToFollowing("Name");
                //output.AppendLine("     Name: " + xmlReader.ReadElementContentAsString());

                //xmlReader.ReadToFollowing("Value");
                //output.AppendLine("     Value: " + xmlReader.ReadElementContentAsString());




                while (reader.Read())
                {

                    reader.MoveToContent();
                    //reader.ReadStartElement("ValCurs");
                    

                    reader.ReadToFollowing("Valute");
                    reader.ReadToFollowing("NumCode");
                    string numCode = reader.ReadElementContentAsString();
                    reader.ReadToFollowing("CharCode");
                    string charCode = reader.ReadElementContentAsString();

                    output.AppendLine(numCode);
                    output.AppendLine(charCode);

                    reader.MoveToContent();
                    reader.ReadEndElement();
                    //switch (reader.NodeType)
                    //{
                    //    case XmlNodeType.Element: // Узел является элементом.


                    //        Console.Write("" + reader.Name);

                    //        while (reader.MoveToNextAttribute()) // Чтение атрибутов.
                    //            //Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                    //        Console.WriteLine(">");
                    //        break;
                    //    case XmlNodeType.Text: // Вывести текст в каждом элементе.
                    //        //Console.WriteLine("---value---");
                    //        Console.Write(" " + reader.Value);
                    //        break;
                    //    case XmlNodeType.EndElement: // Вывести конец элемента.
                    //        Console.Write("</" + reader.Name);
                    //        Console.WriteLine(">");
                    //        break;
                    //}
                }

                string xml_text = output.ToString();
                Console.WriteLine(xml_text);
            }


            // https://habrahabr.ru/post/24673/

            return "";
        }

    }
}
