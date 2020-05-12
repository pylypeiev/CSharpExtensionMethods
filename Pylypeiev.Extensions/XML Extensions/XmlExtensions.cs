using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Pylypeiev.Extensions.Xml
{
    public static class XmlExtensions
    {
        /// <summary>Convert to Stream</summary>
        public static Stream ToStream(this XmlDocument doc)
        {
            var xmlStream = new MemoryStream();
            doc.Save(xmlStream);
            xmlStream.Flush();
            xmlStream.Position = 0;
            return xmlStream;
        }

        /// <summary>Convert to XDocument</summary>
        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }

        /// <summary>Convert to XmlDocument</summary>
        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();

            using (var xmlReader = xDocument.CreateReader())
                xmlDocument.Load(xmlReader);

            return xmlDocument;
        }

        /// <summary>Convert to XmlDocument</summary>
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

        /// <summary>
        /// Try to deserialize this xml
        /// </summary>
        /// <param name="defaultValue">return object if xml deserialize will not succeed</param>
        /// <returns>deserialized xml if succeeded, otherwise - defaultValue. If this string is null - defaultValue</returns>
        public static T TryXmlDeserialize<T>(this string xmlData, T defaultValue = default)
        {
            if (string.IsNullOrWhiteSpace(xmlData))
                return !defaultValue.Equals(default) ? defaultValue : default;

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

        /// <summary>Serialize this object to XML via XmlSerializer</summary>
        /// <returns>XML in a string, if the object is null - an empty string</returns>
        public static string XmlSerialize<T>(this T item)
        {
            if (item == null) return string.Empty;

            var serializer = new XmlSerializer(typeof(T));
            var stringBuilder = new StringBuilder();
            using (var writer = new StringWriter(stringBuilder))
            {
                serializer.Serialize(writer, item);
            }
            return stringBuilder.ToString();
        }

        /// <summary>Serialize this object to XML via XmlSerializer</summary>
        /// <returns>XML in a string, if the object is null - an empty string</returns>
        public static string XmlSerialize(this object item)
        {
            if (item == null) return string.Empty;

            Type type = item.GetType();
            var serializer = new XmlSerializer(type);
            var stringBuilder = new StringBuilder();
            using (var writer = new StringWriter(stringBuilder))
            {
                serializer.Serialize(writer, item);
            }
            return stringBuilder.ToString();
        }
    }
}