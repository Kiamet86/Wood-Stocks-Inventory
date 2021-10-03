using System;

namespace WSI.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Constructor method for StringHandler class.
        /// </summary>
        static StringHandler()
        {
        }
        
        /// <summary>
        /// Splits a string into an array of strings, as delimited by commas
        /// </summary>
        /// <param name="source">string</param>
        /// <returns>string[]</returns>
        public static string[] SplitByComma(this string source)
        {
            if (!source.Contains(","))
                throw new ArgumentException($"String {source} does not contain any commas.");

            var columns = source.Split(new char[] { ',' });
            return columns;
        }
              
    }
}
