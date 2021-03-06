﻿using System.Collections.Generic;
namespace ErlangParserLib.Statement
{
    /// <summary>
    /// 形参表
    /// </summary>
    public class ErlangFunctionArguments : ErlangElement
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ErlangFunctionArguments()
            :base()
        {
            this.EType = Fsm.FsmStatus.FSM_FUNCTION_ARGUMENTS;
        }

        /// <summary>
        /// 重组形参表
        /// </summary>
        /// <param name="elems"></param>
        /// <param name="index"></param>
        public override void Repo(List<IErlangElement> elems, int index)
        {
            int i = index;
            IErlangElement elem;
            for(; i < elems.Count; i ++)
            {
                elem = elems[i];
                if(elem.Context != "," && elem.GroupName != "Blank")
                {
                    this.Elements.Add(elem);
                }
            }
        }
    }
}
