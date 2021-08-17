using System.Diagnostics;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class BoolExtensions
    {
        /// <summary>convert a boolean value to string representation</summary>
        /// <param name="yes">returned string if bool is truthy</param>
        /// <param name="no" >returned string if bool is falsy</param>
        /// <returns>boolean value in string representation</returns>
        [DebuggerStepThrough]
        public static string ToYesNo(this bool b, string yes = "Yes", string no = "No")
        {
            return b ? yes : no;
        }
    }
}