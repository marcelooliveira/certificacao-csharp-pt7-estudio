using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace _02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml =
            "<Filmes>" +
                "<Filme>" +
                    "<Diretor>Quentin Tarantino</Diretor>" +
                    "<Titulo>Pulp Fiction</Titulo>" +
                    "<Minutos>154</Minutos>" +
                "</Filme>" +
                "<Filme>" +
                    "<Diretor>James Cameron</Diretor>" +
                    "<Titulo>Avatar</Titulo>" +
                    "<Minutos>162</Minutos>" +
                "</Filme>" +
            "</Filmes>";

            //XmlDocument documento = new XmlDocument();
            //documento.LoadXml(xml);

            XDocument documento = XDocument.Parse(xml);

            IEnumerable<XElement> consulta =
                from f in documento.Descendants("Filme")
                select f;

            foreach (var item in consulta)
            {
                Console.WriteLine(item.Element("Diretor").FirstNode);
                Console.WriteLine(item.Element("Titulo").FirstNode);
            }

            Console.ReadKey();
        }
    }
}
