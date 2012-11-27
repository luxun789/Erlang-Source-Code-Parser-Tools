using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;

namespace ErlangParserLib.Fsm
{
    public static class FsmCheck
    {
        /// <summary>
        /// 正则匹配式
        /// </summary>
        public static readonly string strLexParser =

            //行注释
            @"(?<Comment>%.+\n)|" +

            //字符串, 单引基元
            @"(?<String>""(.|\n)*?(?<!\\)"")|" +
            @"(?<String>\'(.|\n)*?(?<!\\)\')|" +

            //关键字
            @"(?<Keywords>\b(fun|if|case|of|end|when|true|false)\b)|" +

            //关键字(二进制流类型)
            @"(?<BinaryKeywords>(?<=\/)(" +
                @"(little\-|big\-|native\-)*" +
                @"(signed\-|unsigned\-)*" +
                @"(integer|float|binary|byte|bits|bitstring)" +
                @"(\-unit)*" +
            @"))|" +

            //记录
            @"(?<Record>(#[a-z][_a-zA-Z0-9]*\.[a-z][_a-zA-Z0-9]*))|" +

            //变量
            @"(?<Var>([_A-Z][_a-zA-Z0-9]*))|" +

            //宏
            @"(?<Macro>(\?\w+))" +

            //数值
            @"(?<Number>(\d+(\.\d)*[eE]\d))|"+
            @"(?<Number>(\d+\.\d+))|" +
            @"(?<Number>(\d+))|" +

            //函数
            @"(?<Function>(?<![\:\-])([a-z]\w*?(?=\()))|" +

            //模块调用
            @"(?<ModuleCall>([a-z]{1}\w*?(?=\:)))|" +

            //元子
            @"(?<Atom>(\w+))|" +

            //分隔符(长度:3)
            @"(?<p>(\=\/\=)|(\=\:\=))|" +

            //分隔符(长度:2)
            @"(?<p>(\+\+)|(\-\-)|(\=\=)|(\/\=)|(\=\<)|(\<\-)|(\|\|)|(\<\=)|(\>\=)|(\<\<)|(\>\>)|(\-\>))|" +

            //分隔符(长度:1)
            @"(?<p>[\>\<\|\.\,\;\:\{\}\[\]\(\)\+\-\*\/\=\!\?])|" +

            //间隔(空格, \t, \r, \n)
            @"(?<Blank>\s*)|" +

            //其它
            "(?<Other>.*)";

        /// <summary>
        /// 正则匹配组名
        /// </summary>
        public static readonly Dictionary<string, Color> RegexGroups = new Dictionary<string, Color>{
            {"Var", Color.FromArgb(100, 100, 220)},
            {"Macro", Color.FromArgb(100, 220, 220)},
            {"String", Color.FromArgb(250, 250, 70)},
            {"Number", Color.FromArgb(175, 130, 255)},
            {"Keywords", Color.FromArgb(175, 255, 255)},
            {"BinaryKeywords", Color.FromArgb(255, 30, 30)},
            {"Record", Color.FromArgb(180, 50, 50)},
            {"Function", Color.FromArgb(30, 250, 30)},
            {"ModuleCall", Color.FromArgb(250, 250, 0)},
            {"Atom", Color.FromArgb(250, 250, 250)},
            {"p", Color.FromArgb(220, 220, 220)},
            {"Blank", Color.FromArgb(0, 0, 0)},
            {"Comment", Color.FromArgb(150, 150, 150)},
            {"Other", Color.Red}
        };

        /// <summary>
        /// 语法栈
        /// </summary>
        public static readonly string[][] StockChar = new string[][]{
            new string[]{"[", "]"},
            new string[]{"<<", ">>"},
            new string[]{"{", "}"},
            new string[]{"(", ")"},
            new string[]{"fun", "end"},
            new string[]{"if", "end"},
            new string[]{"case", "end"}
        };

        /// <summary>
        /// 词法分析器
        /// </summary>
        public static readonly Regex regWorkParser = new Regex(
            FsmCheck.strLexParser,
            RegexOptions.Multiline | RegexOptions.ExplicitCapture
        );
    }
}
