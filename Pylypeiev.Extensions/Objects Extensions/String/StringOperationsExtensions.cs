using System;

namespace Pylypeiev.Extensions
{
    public static class StringOperationsExtensions
    {
        public static string RemoveLastCharacter(this string instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }
        public static string RemoveLast(this string instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }
        public static string RemoveFirstCharacter(this string instr)
        {
            return instr.Substring(1);
        }
        public static string RemoveFirst(this string instr, int number)
        {
            return instr.Substring(number);
        }

        public static string Reverse(this string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}