using ErlangParserLib.Fsm;
using System.Collections.Generic;

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

        public FsmStatus EType { get; set; }

        public string Context {get; set;}

        public long Index {get; set;}

        public List<ErlangElement> Nodes = new List<ErlangElement>();

        public string GroupName {get; set;}
    }
}
