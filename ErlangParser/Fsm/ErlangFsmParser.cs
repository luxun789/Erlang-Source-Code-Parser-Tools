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
            ErlangElement cnode;

            //解析匹配流
            fnode = Efile;
            while (m.Success)
            {
                cnode = GetElemByMatch(m);
                m = m.NextMatch();
            }
        }

        /// <summary>
        /// 根据匹配内容, 得到erlang元素
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private ErlangElement GetElemByMatch(Match m)
        {
            ErlangElement elem = null;

            foreach (string gs in FsmCheck.RegexGroups.Keys)
            {
                //判断所在分组
                if (m.Groups[gs].Success)
                {
                    elem = new ErlangElement(FsmStatus.FSM_UNDEFINE);
                    elem.Index = m.Groups[gs].Index;
                    elem.GroupName = gs;
                    elem.Context = m.Value;
                    break;
                }
            }

            return elem;
        }

        /// <summary>
        /// 判断是否为堆栈处理字符
        /// </summary>
        /// <param name="elem"></param>
        /// <returns>返回用于判断结构的子组</returns>
        public static string[] GetStockChar(ErlangElement elem)
        {
            string[] ret = null;
            string str = elem.Context;
            foreach(string[] sl in FsmCheck.StockChar)
            {
                if(sl[0].Equals(str)) {
                    ret = sl;
                    break;
                }
            }
            return ret;
        }

    }
}
