﻿using System.Text.RegularExpressions;
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

            //字符串
            @"(?<String>""(.|\n)*?(?<!\\)"")|" +

            //关键字
            @"(?<Keywords>\b(fun|if|case|of|end)\b)|" +

            //记录
            @"(?<Record>(#[a-z][_a-zA-Z0-9]*\.[a-z][_a-zA-Z0-9]*))|" +

            //变量
            @"(?<Var>([_A-Z][_a-zA-Z0-9]*))|" +

            //数值
            @"(?<Number>(\d+(\.\d)*[eE]\d)|(\d+\.\d+)|(\d+))|" +

            //基元
            @"(?<Atom>(\w+))|" +

            //分隔符(长度:3)
            @"(?<p>(\=\/\=)|(\=\:\=))|" +

            //分隔符(长度:2)
            @"(?<p>(\+\+)|(\-\-)|(\=\=)|(\/\=)|(\=\<)|(\>\=)|(\<\<)|(\>\>)|(\-\>))|" +

            //分隔符(长度:1)
            @"(?<p>[\#\>\<\|\.\,\;\:\{\}\[\]\(\)\+\-\*\/\=\!\?])|" +

            //间隔(空格, \t, \r, \n)
            @"(?<Blank>\s*)|" +

            //其它
            "(?<Other>.*)";

        /// <summary>
        /// 正则匹配组名
        /// </summary>
        public static Dictionary<string, Color> RegexGroups = new Dictionary<string, Color>{
                {"Var", Color.FromArgb(100, 100, 220)},
                {"String", Color.FromArgb(250, 250, 70)},
                {"Number", Color.FromArgb(175, 130, 255)},
                {"Keywords", Color.FromArgb(175, 255, 255)},
                {"Record", Color.FromArgb(180, 50, 50)},
                {"Atom", Color.FromArgb(250, 250, 250)},
                {"p", Color.FromArgb(220, 220, 220)},
                {"Blank", Color.FromArgb(0, 0, 0)},
                {"Other", Color.Red},
                {"Comment", Color.FromArgb(100, 250, 100)}
            };

        /// <summary>
        /// 词法分析器
        /// </summary>
        public static Regex regWorkParser = new Regex(
            FsmCheck.strLexParser, 
            RegexOptions.Multiline|RegexOptions.ExplicitCapture
        );
    }
}
