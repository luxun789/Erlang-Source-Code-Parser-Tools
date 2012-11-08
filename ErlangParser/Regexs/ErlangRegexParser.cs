using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using ErlangParserLib.Elements;

namespace ErlangParserLib.Regexs
{
    public static class ErlangRegexParser
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

            MatchCollection match = RegexUtils.regElement.Matches(Context);

            foreach (Match m in match)
            {
                string str = m.Value;

                if(str.StartsWith("%"))
                {
                    //注释
                    ErlangComment c = new ErlangComment();
                    c.Context = m.Value;
                    efile.Elements.Add(c);
                }
                else if(str.StartsWith("-"))
                {
                    //声明
                    ErlangDeclaration s = new ErlangDeclaration();
                    s.Context = m.Value;
                    s.Name = m.Groups[1].Value;
                    s.InnerText = m.Groups[2].Value;
                    efile.Elements.Add(s);
                }
                else if (str.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("\t", "").Length == 0)
                {
                    //空白行
                }
                else
                {
                    //函数
                    ErlangFunction f = new ErlangFunction();
                    f.Context = m.Value;
                    f.Name = m.Groups[1].Value;
                    efile.Elements.Add(f);
                }
            }

            return efile;
        }

    }
}
