using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangDeclaration : ErlangElement
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 内嵌内容
        /// </summary>
        public string InnerText { get; set; }

        public ErlangDeclaration()
            : base(FsmStatus.FSM_DECLARATION)
        {
        }



    }
}
