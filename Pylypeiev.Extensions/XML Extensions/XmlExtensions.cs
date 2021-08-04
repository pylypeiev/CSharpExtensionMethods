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
        /// <returns>xml in stream if succeeded, otherwise - null</returns>
        public static Stream ToStream(this XmlDocument doc)
        {
            if (doc == null)
            {
                return null;
            }

            var xmlStream = new MemoryStream();
            try
            {
                doc.Save(xmlStream);
                xmlStream.Flush();
                xmlStream.Position = 0;
                return xmlStream;
            }
            catch { return null; }
        }

        /// <summary>Convert to XDocument</summary>
        /// <returns>xml in xDocument object if succeeded, otherwise - null</returns>
        public static XDocument ToXDocument(this XmlDocument doc)
        {
            if (doc == null)
            {
                return null;
            }

            try
            {
                using (var nodeReader = new XmlNodeReader(doc))
                {
                    nodeReader.MoveToContent();
                    return XDocument.Load(nodeReader);
                }
            }
            catch { return null; }
        }

        /// <summary>Convert to XmlDocument</summary>
        /// <returns>xml in xmlDocument object if succeeded, if object is empty - default, otherwise - null</returns>
        public static XmlDocument ToXmlDocument(this XDocument doc)
        {
            if (doc == null)
            {
                return null;
            }

            var xmlDocument = new XmlDocument();

            using (var xmlReader = doc.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }

            return xmlDocument;
        }

        /// <summary>Convert to XmlDocument</summary>
        /// <returns>xml in xmlDocument object if succeeded, otherwise - null</returns>
        public static XmlDocument ToXmlDocument(this XElement xElement)
        {
            if (xElement == null)
            {
                return null;
            }

            try
            {
                var sb = new StringBuilder();
                var xws = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = false };

                using (var xw = XmlWriter.Create(sb, xws))
                {
                    xElement.WriteTo(xw);
                }

                var doc = new XmlDocument();
                doc.LoadXml(sb.ToString());
                return doc;
            }
            catch { return null; }
        }

        /// <summary>
        /// Try to deserialize this xml
        /// </summary>
        /// <param name="defaultValue">return object if xml deserialize will not succeed</param>
        /// <returns>deserialized xml if succeeded, otherwise - defaultValue. If this string is null - defaultValue</returns>
        public static T TryXmlDeserialize<T>(this string xmlData, T defaultValue = default)
        {
            if (string.IsNullOrWhiteSpace(xmlData))
            {
                return !defaultValue?.Equals(default) ?? default ? defaultValue : default;
            }

            var serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xmlData))
            {
                try
                {
                    return (T)serializer.Deserialize(reader);
                }
                catch
                {
                    return !defaultValue?.Equals(default) ?? default ? defaultValue : default;
                }
            }
        }

        /// <summary>Serialize this object to XML via XmlSerializer</summary>
        /// <returns>XML in a string, if the object is null - an empty string</returns>
        public static string XmlSerialize<T>(this T item)
        {
            if (item == null)
            {
                return string.Empty;
            }

            var serializer = new XmlSerializer(typeof(T));
            var stringBuilder = new StringBuilder();
            using (var writer = new StringWriter(stringBuilder))
            {
                serializer.Serialize(writer, item);
            }
            return stringBuilder.ToString();
        }
    }
}