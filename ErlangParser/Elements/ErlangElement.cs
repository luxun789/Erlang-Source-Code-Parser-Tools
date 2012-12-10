using System;
using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Statement
{
    /// <summary>
    /// Erlang元素基类
    /// </summary>
    public class ErlangElement : IDisposable, IErlangElement
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ErlangElement()
        {
            this.Context = string.Empty;
            this.Index = -1;
            this.EType = FsmStatus.FSM_UNDEFINE;
            this.GroupName = string.Empty;
            this.Elements = new List<IErlangElement>();
        }

        /// <summary>
        /// erlang元素类型
        /// </summary>
        public FsmStatus EType { get; set; }

        /// <summary>
        /// 父结点
        /// </summary>
        public IErlangElement Parent { get; set; }

        /// <summary>
        /// 上一个结点
        /// </summary>
        public IErlangElement Prev { get; set; }

        /// <summary>
        /// 下一个结点
        /// </summary>
        public IErlangElement Next { get; set; }

        /// <summary>
        /// 元素内容
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// 当前元素在原文件中的位置
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 子结点列表
        /// </summary>
        public List<IErlangElement> Elements { get; set; }

        /// <summary>
        /// 元素的分组名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 当前元素在原文件中的行位置
        /// </summary>
        public int Line { get; set; }

        /// <summary>
        /// 重组元素
        /// </summary>
        public virtual void Repo(List<IErlangElement> elems, int index)
        {
            return;
        }

        void IDisposable.Dispose()
        {
        }

        /// <summary>
        /// 所有IErlangElement都是ErlangElemenet对象.
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public bool IsTypeOf(IErlangElement elem)
        {
            return true;
        }
    }

}
