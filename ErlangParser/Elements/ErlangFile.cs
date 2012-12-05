using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang文件基础类
    /// </summary>
    public class ErlangFile : ErlangElement
    {
        public ErlangFile() :
            base()
        {
            this.EType = FsmStatus.FSM_FILE;
        }

        /// <summary>
        /// 元素重组
        /// </summary>
        public override void Repo(List<IErlangElement> elems, int index)
        {
            int i = 0;
            IErlangElement elem = this.Elements[0];
            while (i < this.Elements.Count)
            {
                if (elem.Context.StartsWith("%"))
                {
                    //重组注释
                    ErlangComment c = new ErlangComment();
                    elem.CopyTo(c);
                    c.Repo(this.Elements, i);
                    this.Elements.Insert(i, c);
                }
                i ++;
            }
        }

    }

}
