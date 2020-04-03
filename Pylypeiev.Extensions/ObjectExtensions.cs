using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pylypeiev.Extensions
{

    public static class ObjectExtensions
    {
        public static Dictionary<string, string> GetPropertiesWithValues(this object obj)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            Type objectType = obj.GetType();

            foreach (PropertyInfo prop in new List<PropertyInfo>(objectType.GetProperties()))
            {
                object propValue = prop.GetValue(obj, null);
                dictionary.Add(prop.Name, propValue?.ToString());
            }

            return dictionary;
        }

        public static string GetPropertiesWithValues(this object obj, string propNameValueSeparator = " = ", string propsSeparator = ", ")
        {
            var sb = new StringBuilder();

            var objectType = obj.GetType();
            foreach (PropertyInfo prop in new List<PropertyInfo>(objectType.GetProperties()))
            {
                object propValue = prop.GetValue(obj, null);
                sb.Append(prop.Name).Append(propNameValueSeparator).Append(propValue?.ToString()).Append(propsSeparator);
            }

            return sb.ToString();
        }
    }
}
