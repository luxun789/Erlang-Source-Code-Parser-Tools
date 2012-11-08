using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangComment : ErlangElement
    {
        public ErlangComment()
            : base(FsmStatus.FSM_COMMENT)
        {
        }
    }
}
