using System.Text.RegularExpressions;
namespace ErlangParserLib
{
    public static class RegexUtils
    {
        /// <summary>
        /// 空白行
        /// </summary>
        public static Regex regBlankLine = new Regex(
            @"^\b*?\n",
            RegexOptions.Multiline
        );

        /// <summary>
        /// Erlang元素
        /// </summary>
        public static Regex regElement = new Regex(
            @"(%.*\n)|(^-(.*)\(((.|\n)*?)\)\.\n?)|(([_a-zA-Z0-9]*)\(((.|\n)*)\)(->)((.|\n)*?)[\;\.]+?)",
            RegexOptions.Multiline
        );
    }
}
