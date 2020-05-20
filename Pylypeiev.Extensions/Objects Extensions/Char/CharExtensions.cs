using System;

namespace Pylypeiev.Extensions
{
    public static class CharExtensions
    {
        /// <summary>
        /// Determines whether two specified chars have the same value
        /// </summary>
        /// <param name="compareTo">The char to compare to</param>
        /// <returns>true if have same value, otherwise - false</returns>
        public static bool EqualsIgnoreCase(this char ch, char compareTo)
        {
            return char.ToUpperInvariant(ch) == char.ToUpperInvariant(compareTo);
        }
    }
}