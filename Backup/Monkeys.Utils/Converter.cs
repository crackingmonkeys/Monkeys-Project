using System;

namespace Monkeys.Utils
{
    public static class Converter
    {
        /// <summary>
        /// Return integer, If can't convert return 0 (zero)
        /// </summary>
        /// <param name="strNumber">String number</param>
        /// <returns></returns>
        public static int ToInt(this string strNumber)
        {
            int tmpNumber = 0;
            int.TryParse(strNumber, out tmpNumber);

            return tmpNumber;
        }

        /// <summary>
        /// Return integer, If can't convert return null
        /// </summary>
        /// <param name="strNumber">String number</param>
        /// <returns></returns>
        public static int? ToIntNullable(this string strNumber)
        {
            int tmpNumber = 0;
            if (!int.TryParse(strNumber, out tmpNumber))
                return null;
            else
                return tmpNumber;
        }


    }
}
