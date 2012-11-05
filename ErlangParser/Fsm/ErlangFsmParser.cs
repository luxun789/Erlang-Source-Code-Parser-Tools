using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ErlangParserLib.Fsm
{
    public class ErlangFsmParser
    {
        public static ErlangFsmParser Instance = new ErlangFsmParser();

        /// <summary>
        /// 加载文件
        /// </summary>
        /// <param name="filename"></param>
        public void Load(string filename)
        {
            Context = File.ReadAllText(filename);
        }

        public Stack<FsmStatus> status = new Stack<FsmStatus>();
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
