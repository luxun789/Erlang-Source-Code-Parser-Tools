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
        public string[] words;

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            this.words = FsmCheck.regWorkParser.Split(this.Context);
        }

    }
}
