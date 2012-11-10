using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangFunction : ErlangElement
    {
        /// <summary>
        /// 函数名
        /// </summary>
        public string Name { get; set; }

        public ErlangFunction()
            : base(FsmStatus.FSM_FUNCTION)
        {
        }
    }

}
