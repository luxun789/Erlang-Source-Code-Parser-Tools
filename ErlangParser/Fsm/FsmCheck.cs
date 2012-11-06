using System.Text.RegularExpressions;

namespace ErlangParserLib.Fsm
{
    public static class FsmCheck
    {
        public static readonly string strWorkParser = 
            @"(%.+\n)|" +                     //行注释
            @"(""(.|\n)*?(?!\\)"")|" +        //字符串
            @"(\w+)|" +                         //元子
            //@"(=\/=)|(=\:=)|" +                                            //分隔符(长度:3)
            //@"(\+\+)|(--)|(==)|(\/=)|(=<)|(>=)|(<<)|(>>)|(->)|" +          //分隔符(长度:2)
            @"([\>\<\|\,\;\:\{\}\[\]\(\)\.\+\-\*\/\=\!]+)|" +               //分隔符(长度:1)
            @"(\s)|" +                        //间隔(空格, \t, \r, \n)
            "(.*)";

        /// <summary>
        /// 词法分析器
        /// </summary>
        public static Regex regWorkParser = new Regex(
            FsmCheck.strWorkParser, 
            RegexOptions.Multiline
        );
    }
}
