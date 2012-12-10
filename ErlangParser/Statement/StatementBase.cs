using ErlangParserLib.Fsm;

namespace ErlangParserLib.Statement
{
    public class StatementBase : ErlangElement
    {
        public StatementBase()
            :base()
        {
            this.EType = FsmStatus.FSM_STATEMENT;
        }
    }
}
