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

        public ErlangFile Efile { get; set; }

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            this.Efile = new ErlangFile();

            Match m = FsmCheck.regWorkParser.Match(this.Context);

            SortedList<int, ErlangElement> elements = new SortedList<int, ErlangElement>();

            //解析匹配流
            while (m.Success)
            {
                string s = m.Value;
                ErlangElement elem = new ErlangElement(FsmStatus.FSM_UNDEFINE);
                if (m.Value.Length > 0)
                {
                    elem.Index = m.Index;
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
                    Efile.Elements.Add(elem);
                }
                m = m.NextMatch();
            }
        }

    }
}
