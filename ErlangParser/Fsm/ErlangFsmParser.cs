using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using ErlangParserLib.Elements;

namespace ErlangParserLib.Fsm
{
    public class ErlangFsmParser
    {
        public static ErlangFsmParser Instance = new ErlangFsmParser();

        private string Context;

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

        public ErlangFile Efile {get; set;}

        /// <summary>
        /// 解析文件
        /// </summary>
        /// <returns></returns>
        public void Parser()
        {
            this.Efile = new ErlangFile();

            Match m = FsmCheck.regWorkParser.Match(this.Context);

            SortedList<int, ErlangElement> elements = new SortedList<int, ErlangElement>();

            string[] groups = new string[]{
                "Comment", "Var", "String", "Number", "Atom",
                "p", "Blank", "Other", "Record", "Macro"
            };

            //解析匹配流
            while(m.Success)
            {
                string s = m.Value;
                ErlangElement elem = new ErlangElement(FsmStatus.FSM_UNDEFINE);
                elem.Index = m.Index;
                elem.Context = m.Value;

                //判断所在分组
                foreach(string gs in groups)
                {
                    if(m.Groups[gs].Success)
                    {
                        elem.GroupName = gs;
                        break;
                    }
                }
                Efile.Elements.Add(elem);
                m = m.NextMatch();
            }
        }

    }
}
