using System.IO;
using Xunit;

namespace Pylypeiev.Extensions.Tests
{
    public class StringIOExtensionsTests
    {
        [Fact]
        public void SaveAsTestCorrect()
        {
            //Arrange
            string text = "some text";
            string path = "text.txt";
            //Act
            var ifSaved = text.SaveAs(path);
            //Assert
            Assert.True(ifSaved);
            Assert.True(File.Exists(path));

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        [Fact]
        public void SaveAsTestWhenTextIsNull()
        {
            //Arrange
            string text = null;
            string path = "text.txt";
            //Act
            var ifSaved = text.SaveAs(path);
            //Assert
            Assert.False(ifSaved);
            Assert.False(File.Exists(path));

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        [Fact]
        public void SaveAsTestWhenPathIsNull()
        {
            //Arrange
            string text = "text";
            string path = null;
            //Act
            var ifSaved = text.SaveAs(path);
            //Assert
            Assert.False(ifSaved);
        }

        [Fact]
        public void SaveAsWithFileInfoTestCorrect()
        {
            //Arrange
            string text = "some text";
            var fileInfo = new FileInfo("text.txt");
            //Act
            var ifSaved = text.SaveAs(fileInfo);
            //Assert
            Assert.True(ifSaved);
            Assert.True(File.Exists(fileInfo.Name));

            if (File.Exists(fileInfo.Name))
            {
                File.Delete(fileInfo.Name);
            }
        }

        [Fact]
        public void SaveAsWithFileInfoTestWhenTextIsNull()
        {
            //Arrange
            string text = null;
            var fileInfo = new FileInfo("text.txt");
            //Act
            var ifSaved = text.SaveAs(fileInfo);
            //Assert
            Assert.False(ifSaved);
            Assert.False(File.Exists(fileInfo.Name));

            if (File.Exists(fileInfo.Name))
            {
                File.Delete(fileInfo.Name);
            }
        }

        [Fact]
        public void SaveAsWithFileInfoTestWhenPathIsNull()
        {
            //Arrange
            string text = "text";
            FileInfo fileInfo = null;
            //Act
            var ifSaved = text.SaveAs(fileInfo);
            //Assert
            Assert.False(ifSaved);
        }
    }
}
