using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ErlangParserLib.Fsm
{
    public class ErlangFsmParser
    {
        public static ErlangFsmParser Instance = new ErlangFsmParser();

        /// <summary>
        /// 加载文件内容
        /// </summary>
        /// <param name="filename"></param>
        public void Load(string filename)
        {
            this.Context = File.ReadAllText(filename);
        }

        /// <summary>
        /// 加载文本信息
        /// </summary>
        /// <param name="context"></param>
        public void LoadContext(string context)
        {
            this.Context = context;
        }

        private string Context;
        public List<string> words;

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            MatchCollection mc = FsmCheck.regWorkParser.Matches(this.Context);

            this.words = new List<string>();
            foreach(Match c in mc)
            {
                string s = c.Value;
                //string s = c.Groups["Number"].Value;
                if(s.Length > 0)
                {
                    this.words.Add(s);
                }
            }
        }

    }
}
