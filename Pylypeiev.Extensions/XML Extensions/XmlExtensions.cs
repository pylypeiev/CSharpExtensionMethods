using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Pylypeiev.Extensions
{
    public static class XmlExtensions
    {
        public static string XmlSerialize<T>(this T item)
        {
            var serializer = new XmlSerializer(typeof(T));
            var stringBuilder = new StringBuilder();
            using (StringWriter writer = new StringWriter(stringBuilder))
            {
                serializer.Serialize(writer, item);
            }
            return stringBuilder.ToString();
        }

        public static string XmlSerialize(this object item)
        {
            Type type = item.GetType();
            var serializer = new XmlSerializer(type);
            var stringBuilder = new StringBuilder();
            using (StringWriter writer = new StringWriter(stringBuilder))
            {
                serializer.Serialize(writer, item);
            }
            return stringBuilder.ToString();
        }

        public static T TryXmlDeserialize<T>(this string xmlData, T defaultValue = default)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xmlData))
            {
                try
                {
                    return (T)serializer.Deserialize(reader);
                }
                catch (Exception)
                {
                    return !defaultValue.Equals(default) ? defaultValue : default;
                }
            }
        }

        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();

            using (var xmlReader = xDocument.CreateReader())
                xmlDocument.Load(xmlReader);

            return xmlDocument;
        }
        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }
        public static XmlDocument ToXmlDocument(this XElement xElement)
        {
            var sb = new StringBuilder();
            var xws = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = false };

            using (var xw = XmlWriter.Create(sb, xws))
                xElement.WriteTo(xw);

            var doc = new XmlDocument();
            doc.LoadXml(sb.ToString());
            return doc;
        }
        public static Stream ToStream(this XmlDocument doc)
        {
            var xmlStream = new MemoryStream();
            doc.Save(xmlStream);
            xmlStream.Flush();
            xmlStream.Position = 0;
            return xmlStream;
        }
    }
}
