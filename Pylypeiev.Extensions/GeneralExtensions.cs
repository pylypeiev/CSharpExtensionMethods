using System;
using System.Linq;

namespace Pylypeiev.Extensions
{

    public static class GeneralExtensions
    {
        public static bool IsIn<T>(this T source, params T[] list)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return list.Contains(source);
        }
    }
}
