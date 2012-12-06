using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangFunction : ErlangElement
    {
        /// <summary>
        /// 函数名
        /// </summary>
        public string Name { get; set; }

        public override void Repo(List<IErlangElement> elems, int index)
        {
            IErlangElement elem = elems[index] as IErlangElement;
            elem.CopyTo(this);

            int i = index + 1;
            for (; i < elems.Count; i++)
            {
                elem = elems[i];
                this.Elements.Add(elem);
                if(elem.Context == ";" || elem.Context == ".")
                {
                    break;
                }
            }
            if(this.Elements.Count > 0)
            {
                this.Name = this.Context;
            }
            elems.RemoveRange(index, this.Elements.Count);
        }

    }

}
