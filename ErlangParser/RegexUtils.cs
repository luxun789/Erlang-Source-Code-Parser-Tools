using System.Text.RegularExpressions;
namespace ErlangParserLib
{
    public static class RegexUtils
    {
        public static Regex regComment = new Regex(
            @"%.*\n",
            RegexOptions.Multiline
        );

        public static Regex regStatement = new Regex(
            @"^-(.*)\(((.|\n)*?)\)\.?",
            RegexOptions.Multiline
        );

        public static Regex regFunction = new Regex(
            @"^((a-zA-Z_){1}(a-zA-Z_0-9)).*",
            RegexOptions.Multiline
        );
    }
}
