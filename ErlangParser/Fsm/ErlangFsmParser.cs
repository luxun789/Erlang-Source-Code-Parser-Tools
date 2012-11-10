using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using ErlangParserLib.Elements;

namespace ErlangParserLib.Fsm
{
    public class ErlangFsmParser
    {
        public static ErlangFsmParser Instance = new ErlangFsmParser();
        public string Context { get; private set; }

        /// <summary>
        /// 加载文件内容
        /// </summary>
        /// <param name="filename"></param>
        public void Load(string filename)
        {
            this.Context = File.ReadAllText(filename);
            this.Context = this.Context.Replace("\r\n", "\n");
        }

        /// <summary>
        /// 加载文本信息
        /// </summary>
        /// <param name="context"></param>
        public void LoadContext(string context)
        {
            this.Context = context;
        }

        public ErlangElement Efile { get; set; }

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            this.Efile = new ErlangFile();

            Match m = FsmCheck.regWorkParser.Match(this.Context);

            Stack<string> pChar = new Stack<string>();
            Stack<ErlangElement> pElem = new Stack<ErlangElement>();

            pChar.Push("root");
            pElem.Push(Efile);
            ErlangElement fnode;

            //解析匹配流
            while (m.Success)
            {
                fnode = pElem.Peek();
                
                m = m.NextMatch();
            }
        }

        private ErlangElement GetElemByMatch(Match m)
        {
            ErlangElement elem = new ErlangElement(FsmStatus.FSM_UNDEFINE);
            string s = m.Value;
            if (m.Value.Length > 0)
            {
                //elem.Index = m.Index;
                elem.Context = m.Value;

                //判断所在分组
                foreach (string gs in FsmCheck.RegexGroups.Keys)
                {
                    if (m.Groups[gs].Success)
                    {
                        elem.Index = m.Groups[gs].Index;
                        elem.GroupName = gs;
                        break;
                    }
                }
            }
            else
            {
                elem = null;
            }

            return elem;
        }


    }
}
