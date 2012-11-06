using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class Statement : ErlangElement
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// 内嵌内容
        /// </summary>
        public string InnerText {get; set;}

        public Statement()
            : base(FsmStatus.FSM_STATEMENT)
        {
        }
    }
}
