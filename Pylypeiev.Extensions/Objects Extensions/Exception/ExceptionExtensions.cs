using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Get the innermost exception from this exception
        /// </summary>
        /// <returns>innermost exception</returns>
        [DebuggerStepThrough]
        public static Exception GetInnermostException(this Exception ex)
        {
            var innerMostException = ex;
            while (innerMostException?.InnerException != null)
            {
                innerMostException = innerMostException.InnerException;
            }

            return innerMostException;
        }

        /// <summary>
        /// Get list of inner exceptions from this exception
        /// </summary>
        /// <returns>IEnumerable of inner exceptions from this exceptions</returns>
        [DebuggerStepThrough]
        public static IEnumerable<Exception> GetInnerExceptions(this Exception ex)
        {
            var innerEx = ex.InnerException;
            while (innerEx != null)
            {
                yield return innerEx;
                innerEx = innerEx.InnerException;
            }
        }
    }
}