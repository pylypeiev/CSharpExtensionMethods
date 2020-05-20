using System;

namespace Pylypeiev.Extensions
{
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Get the innermost exception from this exception
        /// </summary>
        /// <returns>innermost exception</returns>
        public static Exception GetInnermostException(this Exception ex)
        {
            var innerMostException = ex;
            while (innerMostException.InnerException != null)
                innerMostException = innerMostException.InnerException;

            return innerMostException;
        }
    }
}