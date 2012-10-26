using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ErlangParserLib
{
    public static class ErlangParser
    {
        /// <summary>
        /// 解析erlang(*.erl)文件
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static ErlangFile ParserFile(string filename)
        {
            ErlangFile efile;

            string context = File.ReadAllText(filename, Encoding.UTF8);
            efile = Parser(context);
            return efile;
        }

        /// <summary>
        /// 解析erlang内容
        /// </summary>
        /// <param name="Context"></param>
        /// <returns></returns>
        public static ErlangFile Parser(string Context)
        {
            ErlangFile efile = new ErlangFile();
            MatchCollection match;

            //注释部分
            match = RegexUtils.regComment.Matches(Context);
            foreach(Match m in match)
            {
                Comment c = new Comment();
                c.Context = m.Value;
                efile.Elements.Add(c);
            }

            //各种声明部分
            match = RegexUtils.regStatement.Matches(Context);
            foreach (Match m in match)
            {
                Statement s = new Statement();
                s.Context = m.Value;
                s.Flag = m.Groups[1].Value;
                s.InnerText = m.Groups[2].Value;
                efile.Elements.Add(s);
            }

            //函数部分
            match = RegexUtils.regFunction.Matches(Context);
            foreach (Match m in match)
            {
                ErlangFunction f = new ErlangFunction();
                f.Context = m.Value;
                efile.Elements.Add(f);
            }

            return efile;
        }
    }
}
