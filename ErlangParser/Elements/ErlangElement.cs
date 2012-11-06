using ErlangParserLib.Fsm;
namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang元素基类
    /// </summary>
    public class  ErlangElement
    {
        public ErlangElement(FsmStatus etype)
        {
            this.EType = etype;
        }

        public FsmStatus EType { get; private set; }

        public string Context {get; set;}
    }
}
