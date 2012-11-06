using System.Text.RegularExpressions;

namespace ErlangParserLib.Fsm
{
    public static class FsmCheck
    {
        public static readonly string strWorkParser =

            //行注释
            @"(?<Comment>%.+\n)|" +

            //字符串
            @"(?<String>""(.|\n)*?(?<!\\)"")|" +

            //关键字
            @"(?<KeyWords>fun|)" +

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
            @"(?<p>[\#\>\<\|\.\,\;\:\{\}\[\]\(\)\+\-\*\/\=\!])|" +

            //间隔(空格, \t, \r, \n)
            @"(?<Blank>[\s]*)|" +

            //其它
            "(?<Other>.*)";

        /// <summary>
        /// 词法分析器
        /// </summary>
        public static Regex regWorkParser = new Regex(
            FsmCheck.strWorkParser, 
            RegexOptions.Multiline|RegexOptions.ExplicitCapture
        );
    }
}
