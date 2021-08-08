using System.Linq;
using static System.Char;

namespace tictactoe.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        /// Формирует из строки с разделителем строку в формате lowerCammelCase
        /// </summary>
        public static string ToCamelCase(this string str, string separator = " ")
       => string.IsNullOrWhiteSpace(str) ? string.Empty :
           (ToLowerInvariant(str[0]) + str.Substring(1)).Replace(separator, string.Empty);
    }

}
