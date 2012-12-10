namespace ErlangParserLib.Statement
{
    /// <summary>
    /// 实参表
    /// </summary>
    public class ErlangFunctionParameters : ErlangElement
    {
        public ErlangFunctionParameters()
            :base()
        {
            this.EType = Fsm.FsmStatus.FSM_FUNCTION_PARAMETERS;
        }
    }
}
