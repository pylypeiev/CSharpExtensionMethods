using Pylypeiev.Extensions.Xml;
using System.Xml;
using System.Xml.Linq;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class XmlTests
    {
        [Fact]
        public void ToStreamCorrectTest()
        {
            //Arrange
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version=\"1.0\"?> \n" +
    "<books xmlns=\"http://www.contoso.com/books\"> \n" +
    "  <book genre=\"novel\" ISBN=\"1-861001-57-8\" publicationdate=\"1823-01-28\"> \n" +
    "    <title>Pride And Prejudice</title> \n" +
    "    <price>24.95</price> \n" +
    "  </book> \n" +
    "</books>");
            //Act
            var stream = doc.ToStream();
            //Assert
            Assert.True(stream.Length > 0);
        }

        [Fact]
        public void ToStreamWhenNullTest()
        {
            //Arrange
            XmlDocument doc = null;
            //Act
            var stream = doc.ToStream();
            //Assert
            Assert.Null(stream);
        }

        [Fact]
        public void ToStreamWhenEmprtyTest()
        {
            //Arrange
            XmlDocument doc = new XmlDocument();
            //Act
            var stream = doc.ToStream();
            //Assert
            Assert.True(stream.Length == 0);
        }

        [Fact]
        public void ToXDocumentCorrectTest()
        {
            //Arrange
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version=\"1.0\"?> \n" +
    "<books xmlns=\"http://www.contoso.com/books\"> \n" +
    "  <book genre=\"novel\" ISBN=\"1-861001-57-8\" publicationdate=\"1823-01-28\"> \n" +
    "    <title>Pride And Prejudice</title> \n" +
    "    <price>24.95</price> \n" +
    "  </book> \n" +
    "  <book genre=\"novel\" ISBN=\"1-861002-30-1\" publicationdate=\"1985-01-01\"> \n" +
    "    <title>The Handmaid's Tale</title> \n" +
    "    <price>29.95</price> \n" +
    "  </book> \n" +
    "</books>");
            //Act
            var xDoc = doc.ToXDocument();
            //Assert
            Assert.NotNull(xDoc);
        }

        [Fact]
        public void ToXDocumentEmptyTest()
        {
            //Arrange
            XmlDocument doc = new XmlDocument();
            //Act
            var xDoc = doc.ToXDocument();
            //Assert
            Assert.Null(xDoc);
        }

        [Fact]
        public void ToXDocumentWhenNullTest()
        {
            //Arrange
            XmlDocument doc = null;
            //Act
            var xDoc = doc.ToXDocument();
            //Assert
            Assert.Null(xDoc);
        }

        [Fact]
        public void ToXmlDocumentCorrectTest()
        {
            //Arrange
            XDocument xDoc = new XDocument(
                new XElement("Root",
                    new XElement("Child1", "data1"),
                    new XElement("Info8", "info8")
                )
            );
            //Act
            var xmlDoc = xDoc.ToXmlDocument();
            //Assert
            Assert.NotNull(xmlDoc);
            Assert.Equal("<Root><Child1>data1</Child1><Info8>info8</Info8></Root>", xmlDoc.OuterXml);
        }

        [Fact]
        public void ToXmlDocumentEmptyTest()
        {
            //Arrange
            XDocument xDoc = new XDocument();
            //Act
            var xmlDoc = xDoc.ToXmlDocument();
            //Assert
            Assert.NotNull(xmlDoc);
        }

        [Fact]
        public void ToXmlDocumentNullTest()
        {
            //Arrange
            XDocument xDoc = null;
            //Act
            var xmlDoc = xDoc.ToXmlDocument();
            //Assert
            Assert.Null(xmlDoc);
        }

        [Fact]
        public void XElementToXmlDocumentCorrectTest()
        {
            //Arrange
            var elem = new XElement("Child1", "data1");
            //Act
            var xmlDoc = elem.ToXmlDocument();
            //Assert
            Assert.NotNull(xmlDoc);
            Assert.Equal("<Child1>data1</Child1>", xmlDoc.OuterXml);
        }

        [Fact]
        public void XElementToXmlDocumentNullTest()
        {
            //Arrange
            XElement elem = null;
            //Act
            var xmlDoc = elem.ToXmlDocument();
            //Assert
            Assert.Null(xmlDoc);
        }

        [Fact]
        public void TryXmlDeserializeCorrectTest()
        {
            //Arrange
            var xml = "<Root><Child1>data1</Child1><Info8>info8</Info8></Root>";
            //Act
            var xmlObj = xml.TryXmlDeserialize<Root>();
            //Assert
            Assert.NotNull(xmlObj);
            Assert.Equal("data1", xmlObj.Child1);
        }

        [Fact]
        public void TryXmlDeserializeWhenNullTest()
        {
            //Arrange
            string xml = null;
            //Act
            var xmlObj = xml.TryXmlDeserialize<Root>();
            //Assert
            Assert.Null(xmlObj);
        }

        [Fact]
        public void TryXmlDeserializeWhenXmlBrokenTest()
        {
            //Arrange
            string xml = "<Root><Child1>data1</Child1><Info8>info8</Info8></Root";
            //Act
            var xmlObj = xml.TryXmlDeserialize<Root>();
            //Assert
            Assert.Null(xmlObj);
        }

        [Fact]
        public void XmlSerializeCorrectTest()
        {
            //Arrange
            var obj = new Root
            {
                Child1 = "data1",
                Info8 = "info8"
            };
            //Act
            var xml = obj.XmlSerialize();
            //Assert
            Assert.False(xml.IsNullOrWhiteSpace());
        }

        [Fact]
        public void XmlSerializeOnNUllTest()
        {
            //Arrange
            Root obj = null;
            //Act
            var xml = obj.XmlSerialize();
            //Assert
            Assert.True(xml.IsNullOrWhiteSpace());
        }
    }
}


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Root
{

    private string child1Field;

    private string info8Field;

    /// <remarks/>
    public string Child1
    {
        get
        {
            return this.child1Field;
        }
        set
        {
            this.child1Field = value;
        }
    }

    /// <remarks/>
    public string Info8
    {
        get
        {
            return this.info8Field;
        }
        set
        {
            this.info8Field = value;
        }
    }
}


