﻿using System.Collections.Generic;
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

        public List<string> words = new List<string>();

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            Match m = FsmCheck.regWorkParser.Match(this.Context);

            foreach(Group g in m.Groups)
            {
                this.words.Add(g.Value);
            }
        }

    }
}