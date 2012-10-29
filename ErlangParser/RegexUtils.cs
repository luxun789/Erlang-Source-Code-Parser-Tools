﻿using System.Text.RegularExpressions;
namespace ErlangParserLib
{
    public static class RegexUtils
    {
        public static Regex regComment = new Regex(
            @"%.*\n",
            RegexOptions.Multiline
        );

        public static Regex regStatement = new Regex(
            @"^-(.*)\(((.|\n)*?)\)\.\n?",
            RegexOptions.Multiline
        );

        public static Regex regFunction = new Regex(
            @"([a-zA-Z_0-9]*)\(((.|\n)*?)\)(->)((.|\n)*?)[\;\.]+?",
            RegexOptions.Multiline
        );

        public static Regex regBlankLine = new Regex(
            @"^\b*?\n",
            RegexOptions.Multiline
        );

        public static Regex regElement = new Regex(
            @"(%.*\n)|(^-(.*)\(((.|\n)*?)\)\.\n?)|(([a-zA-Z_0-9]*)\(((.|\n)*?)\)(->)((.|\n)*?)[\;\.]+?)",
            RegexOptions.Multiline
        );
    }
}
