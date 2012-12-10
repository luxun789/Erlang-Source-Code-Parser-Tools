using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Statement
{
    public class ErlangComment : ErlangElement
    {
        public ErlangComment()
            :base()
        {
            this.EType = FsmStatus.FSM_COMMENT;
        }

        public override void Repo(List<IErlangElement> elems, int index)
        {
            IErlangElement elem = elems[index];
            elem.CopyTo(this);
            elems.RemoveAt(index);
        }
    }
}
