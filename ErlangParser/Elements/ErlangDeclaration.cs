using ErlangParserLib.Fsm;
using System.Collections.Generic;

namespace ErlangParserLib.Elements
{
    public class ErlangDeclaration : ErlangElement
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 内嵌内容
        /// </summary>
        public string InnerText { get; set; }

        public ErlangDeclaration()
            : base()
        {
        }

        public override void Repo(List<IErlangElement> elems, int index)
        {
            int count = 1;
            for (int i = index; i < elems.Count; i++, count++)
            {
                IErlangElement elem = elems[i];
                if (elem.Context == ".")
                {
                    break;
                }
                this.Elements.Add(elem);
            }
            elems.RemoveRange(index, count);
        }
    }
}
