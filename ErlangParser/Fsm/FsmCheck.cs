using System.Text.RegularExpressions;

namespace ErlangParserLib.Fsm
{
    public static class FsmCheck
    {
        public static readonly string strWorkParser = 
            @"(%.*\n)|" +                     //行注释
            @"(""(.|\n)*?(?!\\)"")" +         //字符串
            @"(\s+?)|" +                        //间隔(空格, \t, \r, \n)
            @"([,.;:\(\)]{1})|" +             //分隔符(,.;)
            @"(\w+)|" +                         //元子
            @"((.|\n)+?)" +                     //未知项
            "";

        /// <summary>
        /// 词法分析器
        /// </summary>
        public static Regex regWorkParser = new Regex(Fsm.FsmCheck.strWorkParser,  RegexOptions.Multiline);
    }
}
