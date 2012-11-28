using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using ErlangParserLib.Elements;

namespace ErlangParserLib.Fsm
{
    public class ErlangFsmParser
    {
        public static ErlangFsmParser Instance = new ErlangFsmParser();

        /// <summary>
        /// 加载的文件内容
        /// </summary>
        public string Context { get; private set; }

        /// <summary>
        /// 加载的文件路径
        /// </summary>
        public string Filename { get; private set; }

        /// <summary>
        /// 解析后的文件类
        /// </summary>
        public ErlangElement Efile { get; set; }

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

        /// <summary>
        /// 行号标识
        /// </summary>
        private Stack<int> lines_flag = new Stack<int>();

        /// <summary>
        /// 行号解析
        /// </summary>
        /// <param name="context"></param>
        private void LinesParser(ref string context)
        {
            lines_flag.Clear();
            foreach(Match m in FsmCheck.regLines.Matches(context))
            {
                lines_flag.Push(m.Index);
            }
        }

        /// <summary>
        /// 获取行号
        /// </summary>
        /// <param name="index">行号</param>
        private int GetLineNo(int index)
        {
            int ret = -1;

            while(lines_flag.Peek() >= index)
            {
                lines_flag.Pop();
            }
            ret = lines_flag.Peek();
            return ret;
        }

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            this.Efile = new ErlangFile();

            string context = this.Context.Replace(FsmCheck.remean_char, FsmCheck.repalce_char);

            LinesParser(ref context);

            Match m = FsmCheck.regWorkParser.Match(context);

            ErlangElement fnode;        //父结点
            ErlangElement cnode;       //当前结点

            Stack<string> pChar = new Stack<string>();         //语法层次栈
            string pc = string.Empty;                                   //弹栈用字符.

            pChar.Push("root");
            fnode = Efile;

            IErlangElement prev = this.Efile as IErlangElement; //前一个结点

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
                    elem.Line = GetLineNo(elem.Index);
                    break;
                }
            }

            return elem;
        }

        /// <summary>
        /// 判断是否为入栈边界, 如果是则返回弹栈字符.
        /// </summary>
        /// <param name="elem"></param>
        /// <returns>返回</returns>
        public static string GetStockChar(ErlangElement elem)
        {
            string ret = string.Empty;
            string str = elem.Context;

            if(FsmCheck.StockChar.ContainsKey(str))
            {
                ret = FsmCheck.StockChar[str];
            }
            return ret;
        }

    }
}
