using System;
using System.Xml.Linq;
using System.Xml;

namespace xml
{
    public static class XMLHelpers
    {
        public static void ReadXMLFileWithLINQ()
        {
            string xmlFilePath = "book.xml";
            XDocument xmlDoc = XDocument.Load(xmlFilePath);

            var books = from book in xmlDoc.Descendants("book")
                        select new
                        {
                            Id = (string)book.Attribute("id"),
                            Author = (string)book.Element("author"),
                            Title = (string)book.Element("title"),
                            Genre = (string)book.Element("genre"),
                            Price = (string)book.Element("price"),
                            PublishDate = (string)book.Element("publish_date"),
                            Description = (string)book.Element("description")
                        };

            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"Price: {book.Price}");
                Console.WriteLine($"Publish Date: {book.PublishDate}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine();
            }
        }

        public static void ReadXMLFileWithXmlDocument()
        {
            string xmlFilePath = "book.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList bookNodes = xmlDoc.SelectNodes("/catalog/book");

            foreach (XmlNode bookNode in bookNodes)
            {
                string bookId = bookNode.Attributes["id"].Value;
                string author = bookNode.SelectSingleNode("author").InnerText;
                string title = bookNode.SelectSingleNode("title").InnerText;
                string genre = bookNode.SelectSingleNode("genre").InnerText;
                string price = bookNode.SelectSingleNode("price").InnerText;
                string publishDate = bookNode.SelectSingleNode("publish_date").InnerText;
                string description = bookNode.SelectSingleNode("description").InnerText;

                Console.WriteLine($"ID: {bookId}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Genre: {genre}");
                Console.WriteLine($"Price: {price}");
                Console.WriteLine($"Publish Date: {publishDate}");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine();
            }
        }

        public static void ReadXMLFileWithXmlReader()
        {
            string xmlFilePath = "book.xml";
            XmlReader reader = XmlReader.Create(xmlFilePath);

            try
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "book")
                    {
                        string bookId = reader.GetAttribute("id");
                        Console.WriteLine($"ID: {bookId}");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "author")
                    {
                        reader.Read();
                        Console.WriteLine($"Author: {reader.Value}");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        reader.Read();
                        Console.WriteLine($"Title: {reader.Value}");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "genre")
                    {
                        reader.Read();
                        Console.WriteLine($"Genre: {reader.Value}");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "price")
                    {
                        reader.Read();
                        Console.WriteLine($"Price: {reader.Value}");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "publish_date")
                    {
                        reader.Read();
                        Console.WriteLine($"Publish Date: {reader.Value}");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "description")
                    {
                        reader.Read();
                        Console.WriteLine($"Description: {reader.Value}");
                        Console.WriteLine();
                    }
                }
            }
            finally
            {
                reader.Close();
            }
        }
        public static void CreateXMLFileWithXmlWriter()
        {
            string xmlFilePath = "new_book.xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(xmlFilePath, settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("catalog");

            WriteBookElement(writer, "bk101", "Gambardella, Matthew", "XML Developer's Guide", "Computer", "44.95", "2000-10-01", "An in-depth look at creating applications with XML.");
            WriteBookElement(writer, "bk102", "Ralls, Kim", "Midnight Rain", "Fantasy", "5.95", "2000-12-16", "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world.");

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            Console.WriteLine("Document XML creat correctament.");
        }

        private static void WriteBookElement(XmlWriter writer, string id, string author, string title, string genre, string price, string publishDate, string description)
        {
            writer.WriteStartElement("book");
            writer.WriteAttributeString("id", id);

            // Añadir los elementos hijos
            WriteElementWithValue(writer, "author", author);
            WriteElementWithValue(writer, "title", title);
            WriteElementWithValue(writer, "genre", genre);
            WriteElementWithValue(writer, "price", price);
            WriteElementWithValue(writer, "publish_date", publishDate);
            WriteElementWithValue(writer, "description", description);

            writer.WriteEndElement();
        }
        private static void WriteElementWithValue(XmlWriter writer, string elementName, string value)
        {
            writer.WriteStartElement(elementName);
            writer.WriteString(value);
            writer.WriteEndElement();
        }

        public static void CreateXMLFileWithXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement catalogElement = xmlDoc.CreateElement("catalog");
            xmlDoc.AppendChild(catalogElement);

            AddBookNode(xmlDoc, catalogElement, "bk101", "Gambardella, Matthew", "XML Developer's Guide", "Computer", "44.95", "2000-10-01", "An in-depth look at creating applications with XML.");
            AddBookNode(xmlDoc, catalogElement, "bk102", "Ralls, Kim", "Midnight Rain", "Fantasy", "5.95", "2000-12-16", "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world.");

            string xmlFilePath = "new_book_doc.xml";
            xmlDoc.Save(xmlFilePath);

            Console.WriteLine("Document XML creat correctament.");
        }

        private static void AddBookNode(XmlDocument xmlDoc, XmlElement parentElement, string id, string author, string title, string genre, string price, string publishDate, string description)
        {
            XmlElement bookElement = xmlDoc.CreateElement("book");
            parentElement.AppendChild(bookElement);

            bookElement.SetAttribute("id", id);

            // Afegeix nodes fills al node de llibre
            AddChildElement(xmlDoc, bookElement, "author", author);
            AddChildElement(xmlDoc, bookElement, "title", title);
            AddChildElement(xmlDoc, bookElement, "genre", genre);
            AddChildElement(xmlDoc, bookElement, "price", price);
            AddChildElement(xmlDoc, bookElement, "publish_date", publishDate);
            AddChildElement(xmlDoc, bookElement, "description", description);
        }
        private static void AddChildElement(XmlDocument xmlDoc, XmlElement parentElement, string elementName, string value)
        {
            XmlElement childElement = xmlDoc.CreateElement(elementName);
            childElement.InnerText = value;
            parentElement.AppendChild(childElement);
        }

        public static void CreateXMLFileWithLINQ()
        {
            XDocument xmlDoc = new XDocument(
                new XElement("catalog",
                    new XElement("book",
                        new XAttribute("id", "bk101"),
                        new XElement("author", "Gambardella, Matthew"),
                        new XElement("title", "XML Developer's Guide"),
                        new XElement("genre", "Computer"),
                        new XElement("price", "44.95"),
                        new XElement("publish_date", "2000-10-01"),
                        new XElement("description", "An in-depth look at creating applications with XML.")
                    ),
                    new XElement("book",
                        new XAttribute("id", "bk102"),
                        new XElement("author", "Ralls, Kim"),
                        new XElement("title", "Midnight Rain"),
                        new XElement("genre", "Fantasy"),
                        new XElement("price", "5.95"),
                        new XElement("publish_date", "2000-12-16"),
                        new XElement("description", "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world.")
                    )
                )
            );
            string xmlFilePath = "new_book_linq.xml";
            xmlDoc.Save(xmlFilePath);

            Console.WriteLine("Documento XML creado correctamente.");
        }
    }
}