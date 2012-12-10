using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Statement
{
    public class ErlangWhenStatement : StatementBase
    {
        public override void Repo(List<IErlangElement> elems, int index)
        {
            int i = index + 1;
            IErlangElement elem = elems[index];
            elem.CopyTo(this);

            for(; i < elems.Count && !elem.Context.Equals("->"); i++)
            {
                elem = elems[i];
                this.Elements.Add(elem);
            }
            elems.RemoveRange(index, this.Elements.Count);

            base.Repo(elems, index);
        }
    }
}
