using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class ObjectExtensions
    {
        /// <summary>Get properties and values of this object using reflection</summary>
        /// <param name="obj"></param>
        /// <returns>dictionary where key is property of object and value is value of this property</returns>
        [DebuggerStepThrough]
        public static Dictionary<string, string> GetPropertiesWithValues(this object obj)
        {
            var dictionary = new Dictionary<string, string>();

            if (obj.IsNull())
            {
                return dictionary;
            }

            Type objectType = obj.GetType();

            foreach (PropertyInfo prop in new List<PropertyInfo>(objectType.GetProperties()))
            {
                object propValue = prop.GetValue(obj, null);
                dictionary.Add(prop.Name, propValue?.ToString());
            }

            return dictionary;
        }

        /// <summary>Get properties and values of this object using reflection</summary>
        /// <param name="propNameValueSeparator">separator between property and value</param>
        /// <param name="propsSeparator">separator between different properties</param>
        /// <returns>string with properties and values separated with provided symbols</returns>
        [DebuggerStepThrough]
        public static string GetPropertiesWithValues(this object obj, string propNameValueSeparator, string propsSeparator = ", ")
        {
            if (obj.IsNull())
            {
                return string.Empty;
            }

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