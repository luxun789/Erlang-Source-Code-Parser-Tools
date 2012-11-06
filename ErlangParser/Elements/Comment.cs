using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class Comment : ErlangElement
    {
        public Comment()
            : base(FsmStatus.FSM_COMMENT)
        {
        }
    }
}
