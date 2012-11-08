using System.Collections.Generic;
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

        public FsmStatus EType { get; set; }

        public string Context {get; set;}

        public int Index {get; set;}

        public List<ErlangElement> Elements = new List<ErlangElement>();

        public string GroupName {get; set;}

        /// <summary>
        /// 数据重组
        /// </summary>
        public virtual void Reorganization()
        {
        }
    }
}
