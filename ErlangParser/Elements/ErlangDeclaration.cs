using ErlangParserLib.Fsm;
using Newtonsoft.Json;

namespace ErlangParserLib.Elements
{
    public class ErlangDeclaration : ErlangElement
    {
        /// <summary>
        /// 标识
        /// </summary>
        [JsonIgnore()]
        public string Name { get; set; }

        /// <summary>
        /// 内嵌内容
        /// </summary>
        [JsonIgnore()]
        public string InnerText {get; set;}

        public ErlangDeclaration()
            : base(FsmStatus.FSM_DECLARATION)
        {
        }

        /// <summary>
        /// 声明重组
        /// </summary>
        public override void Reorganization()
        {
        }
    }
}
