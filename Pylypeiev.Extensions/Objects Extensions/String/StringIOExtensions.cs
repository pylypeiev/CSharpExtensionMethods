using System;
using System.Diagnostics;
using System.IO;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class StringIOExtensions
    {
        /// <summary>write string to file</summary>
        /// <param name="path">The complete file path to write to</param>
        /// <param name="append">true to append data to the file; false to overwrite the file.</param>
        /// <returns>true if succeeded to write to file, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool SaveAs(this string str, string path, bool append = false)
        {
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            try
            {
                using (var tw = new StreamWriter(path, append))
                {
                    tw.Write(str);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>write string to file</summary>
        /// <param name="fileInfo">fileInfo about the file to write to</param>
        /// <param name="append">true to append data to the file; false to overwrite the file.</param>
        /// <returns>true if succeeded to write to file, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool SaveAs(this string str, FileInfo fileInfo, bool append = false)
        {
            if (string.IsNullOrWhiteSpace(str) || fileInfo == null || string.IsNullOrWhiteSpace(fileInfo.FullName))
            {
                return false;
            }

            try
            {
                using (var tw = new StreamWriter(fileInfo.FullName, append))
                {
                    tw.Write(str);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}