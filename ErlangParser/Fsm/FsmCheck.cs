using System.Text.RegularExpressions;

namespace ErlangParserLib.Fsm
{
    public static class FsmCheck
    {
        /// <summary>
        /// 词法分析器
        /// </summary>
        public static Regex regWorkParser = new Regex(
            @"("".*?[~\\]"")|" +       //字符串
            @"(%.*\n)|" +              //注释
            @"(\s*)|" +                  //间隔(空格, \t, \r, \n)
            @"(\d)|" +                   //整数
            @"(\w+)|" +                  //元子
            @"(.*)?"                      //未知项
            ,RegexOptions.Multiline
        );
    }
}
