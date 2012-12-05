using ErlangParserLib.Fsm;
using System.Collections.Generic;
namespace ErlangParserLib.Elements
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
            this.GroupName = elem.GroupName;
            this.Index = elem.Index;
            this.Line = elem.Line;
            this.Parent = elem.Parent;
            this.Prev = elem.Prev;

            index ++;
            while (index < elems.Count)
            {
                elem = elems[index];
                if(!elem.Context.StartsWith("%"))
                {
                    break;
                }
                this.Context += elem.Context;
                elems.RemoveAt(index);
            }
            this.Next = elem;
        }
    }
}
