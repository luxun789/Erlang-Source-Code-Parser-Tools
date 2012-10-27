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

            ParserComment(ref Context, ref efile);
            ParserStatement(ref Context, ref efile);
            ParserFunction(ref Context, ref efile);

            return efile;
        }

        /// <summary>
        /// 解析注释
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="efile"></param>
        public static void ParserComment(ref string Context, ref ErlangFile efile)
        {
            MatchCollection match = RegexUtils.regComment.Matches(Context);
            Comment c;
            foreach (Match m in match)
            {
                c = new Comment();
                c.Context = m.Value;
                efile.Elements.Add(c);
                Context = Context.Replace(m.Value, "");
            }
        }

        /// <summary>
        /// 解析声明
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="efile"></param>
        public static void ParserStatement(ref string Context, ref ErlangFile efile)
        {
            MatchCollection match = RegexUtils.regStatement.Matches(Context);
            Statement s;
            foreach (Match m in match)
            {
                s = new Statement();
                s.Context = m.Value;
                s.Flag = m.Groups[1].Value;
                s.InnerText = m.Groups[2].Value;
                efile.Elements.Add(s);
                Context = Context.Replace(m.Value, "");
            }
        }

        /// <summary>
        /// 解析函数
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="efile"></param>
        public static void ParserFunction(ref string Context, ref ErlangFile efile)
        {
            MatchCollection match = RegexUtils.regFunction.Matches(Context);
            ErlangFunction f;
            foreach (Match m in match)
            {
                f = new ErlangFunction();
                f.Context = m.Value;
                f.Name = m.Groups[1].Value;
                efile.Elements.Add(f);
                Context = Context.Replace(m.Value, "");
            }
        }
    }
}
