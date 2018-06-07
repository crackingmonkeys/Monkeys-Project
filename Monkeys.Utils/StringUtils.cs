using System;
using System.Collections.Generic;
using System.Text;

namespace Monkeys.Utils
{
    public static class StringUtils
    {
        /// <summary>
        /// When empty return default value
        /// </summary>
        /// <param name="strValue">Text value</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns></returns>
        public static string GetValueOrDefault(this string strValue, string defaultValue)
        {
            if (string.IsNullOrEmpty(strValue))
            {
                return defaultValue;
            }
            else
            {
                return strValue;
            }
        }
    }
}
