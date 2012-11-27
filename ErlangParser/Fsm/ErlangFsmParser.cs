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
        public string Filename { get; private set; }

        /// <summary>
        /// 加载文件内容
        /// </summary>
        /// <param name="filename"></param>
        public void Load(string filename)
        {
            this.Filename = filename;
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

            string context = this.Context.Replace("\\\\", "\\\xFF");
            Match m = FsmCheck.regWorkParser.Match(context);

            Stack<string> pChar = new Stack<string>();

            ErlangElement fnode;
            ErlangElement cnode;

            string pc = string.Empty;

            pChar.Push("root");
            fnode = Efile;

            IErlangElement prev = this.Efile as IErlangElement;

            //解析匹配流
            while (m.Success)
            {
                cnode = GetElemByMatch(m);
                pc = GetStockChar(cnode);

                if (pc.Length > 0)
                {
                    //入栈
                    pChar.Push(pc);
                    fnode.Elements.Add(cnode);
                    cnode.Parent = fnode;
                    fnode = cnode;
                }
                else if (cnode.Context == pChar.Peek())
                {
                    //出栈
                    pc = pChar.Pop();
                    fnode = fnode.Parent as ErlangElement;
                    fnode.Elements.Add(cnode);
                }
                else
                {
                    //添加子元素
                    fnode.Elements.Add(cnode);
                    cnode.Parent = fnode;
                }

                //构建线索表
                if(prev != null)
                {
                    prev.Next = cnode;
                    cnode.Prev = prev;
                }
                prev = cnode;
                m = m.NextMatch();
            }
            Efile.Context = this.Filename;
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
                    elem = new ErlangElement();
                    elem.Index = m.Groups[gs].Index;
                    elem.GroupName = gs;
                    elem.Context = m.Value.Replace("\\\xFF", "\\\\");
                    break;
                }
            }

            return elem;
        }

        /// <summary>
        /// 判断是否为堆栈边界, 如果是则返回弹栈字符.
        /// </summary>
        /// <param name="elem"></param>
        /// <returns>返回</returns>
        public static string GetStockChar(ErlangElement elem)
        {
            string ret = string.Empty;
            string str = elem.Context;
            foreach (string[] sl in FsmCheck.StockChar)
            {
                if (sl[0].Equals(str))
                {
                    ret = sl[1];
                    break;
                }
            }
            return ret;
        }

    }
}
