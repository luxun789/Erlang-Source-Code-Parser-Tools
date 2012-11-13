using ErlangParserLib.Fsm;
namespace ErlangParserLib.Elements
{
    public class ErlangComment : ErlangElement
    {
        public ErlangComment()
            :base()
        {
            this.EType = FsmStatus.FSM_COMMENT;
        }
    }
}
