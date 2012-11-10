﻿using System.Collections.Generic;
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
        public string InnerText { get; set; }

        public ErlangDeclaration()
            : base(FsmStatus.FSM_DECLARATION)
        {
            this.GroupName = "Declaration";
        }

    }
}
