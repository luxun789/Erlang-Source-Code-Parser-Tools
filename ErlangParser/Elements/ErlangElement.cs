﻿using System;
using System.Collections.Generic;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;

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

        [JsonIgnore()]
        public FsmStatus EType { get; set; }

        public string Context {get; set;}

        [JsonIgnore()]
        public int Index {get; set;}

        //[JsonIgnore()]
        public List<ErlangElement> Elements {get; set;}

        [JsonIgnore()]
        public string GroupName {get; set;}

        void IDisposable.Dispose()
        {
        }
    }
}
