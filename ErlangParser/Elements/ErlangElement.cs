using System;
using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang元素基类
    /// </summary>
    public class  ErlangElement : IDisposable
    {
        public ErlangElement(FsmStatus etype)
        {
            this.EType = etype;
            this.Context = string.Empty;
            this.Index = -1;
            this.GroupName = string.Empty;
            this.Elements = new List<ErlangElement>();
        }

        public FsmStatus EType { get; set; }

        public ErlangElement PrevNode { get; set; }

        public string Context {get; set;}

        public int Index {get; set;}

        public List<ErlangElement> Elements {get; set;}

        public string GroupName {get; set;}

        void IDisposable.Dispose()
        {
        }
    }
}
