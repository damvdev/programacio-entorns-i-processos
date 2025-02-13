using System;
using System.Xml;
using System.Xml.Linq;
using xml;

namespace parsers
{
    public class Program
    {
        public static void Main()
        {
            XMLHelpers.CreateXMLFileWithXmlWriter();
            XMLHelpers.CreateXMLFileWithXmlDocument();
            XMLHelpers.CreateXMLFileWithLINQ();
            XMLHelpers.ReadXMLFileWithXmlReader();
            XMLHelpers.ReadXMLFileWithXmlDocument();
            XMLHelpers.ReadXMLFileWithLINQ();
        }
    }
}