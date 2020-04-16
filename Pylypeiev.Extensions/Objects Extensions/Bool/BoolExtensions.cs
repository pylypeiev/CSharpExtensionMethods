using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Pylypeiev.Extensions
{
    public static class BoolExtensions
    {
        public static string ToYesNo(this bool b, string yes = "Yes", string no = "No")
        {
            return b ? yes : no;
        }
    }
}
