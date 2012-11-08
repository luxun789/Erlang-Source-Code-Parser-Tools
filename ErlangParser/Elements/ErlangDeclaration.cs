using System.Collections.Generic;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;

namespace ErlangParserLib.Elements
{
    public class ErlangDeclaration : ErlangElement
    {
        /// <summary>
        /// 标识
        /// </summary>
        [JsonIgnore()]
        public string Name { get; set; }

        /// <summary>
        /// 内嵌内容
        /// </summary>
        [JsonIgnore()]
        public string InnerText { get; set; }

        public ErlangDeclaration()
            : base(FsmStatus.FSM_DECLARATION)
        {
            this.GroupName = "Declaration";
        }

        /// <summary>
        /// 声明重组
        /// </summary>
        public override int Reorganization(IList<ErlangElement> elements, int startIndex)
        {
            int len = 0;
            ErlangElement elem = elements[startIndex];
            this.Index = elem.Index;
            for (int i = startIndex; i < elements.Count; i++, len++)
            {
                elem = elements[i];
                if (!elem.GroupName.Equals("Blank"))
                {
                    this.Elements.Add(elem);
                    this.Context += elem.Context;
                }
                if (elem.Context.Equals(".")) break;
            }

            return len;
        }
    }
}
