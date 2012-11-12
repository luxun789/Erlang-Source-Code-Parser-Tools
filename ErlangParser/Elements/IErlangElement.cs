using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang元素接口
    /// </summary>
    public interface IErlangElement
    {
        /// <summary>
        /// erlang元素类型
        /// </summary>
        FsmStatus EType { get; set; }

        /// <summary>
        /// 当前元素的你结点
        /// </summary>
        ErlangElement PrevNode { get; set; }

        /// <summary>
        /// 元素内容
        /// </summary>
        string Context { get; set; }

        /// <summary>
        /// 当前元素在原文件中的位置
        /// </summary>
        int Index { get; set; }

        /// <summary>
        /// 子结点列表
        /// </summary>
        List<ErlangElement> Elements { get; set; }

        /// <summary>
        /// 元素的分组名称
        /// </summary>
        string GroupName { get; set; }
    }
}
