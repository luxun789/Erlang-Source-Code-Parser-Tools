using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangComment : ErlangElement
    {
        public ErlangComment()
            : base(FsmStatus.FSM_COMMENT)
        {
        }

        public override int Reorganization(IList<ErlangElement> elements, int startIndex)
        {
            int len = 0;

            ErlangElement elem = elements[startIndex];

            this.GroupName = elem.GroupName;
            this.Index = elem.Index;
            for(int i = startIndex; i < elements.Count; i ++)
            {
                elem = elements[i];
                if(!elem.Context.StartsWith("%"))
                {
                    break;
                }
                this.Context += elem.Context;
                len ++;
            }

            return len;
        }
    }
}
