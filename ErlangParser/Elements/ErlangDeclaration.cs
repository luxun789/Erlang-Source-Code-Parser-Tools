using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangDeclaration : ErlangElement
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ErlangDeclaration()
            : base()
        {
            this.EType = FsmStatus.FSM_DECLARATION;
        }

        /// <summary>
        /// 重组标识
        /// </summary>
        /// <param name="elems"></param>
        /// <param name="index"></param>
        public override void Repo(List<IErlangElement> elems, int index)
        {
            int i = index + 1;
            IErlangElement elem = elems[index];
            elem.CopyTo(this);

            for (; i < elems.Count; i++)
            {
                elem = elems[i];
                this.Elements.Add(elem);

                if (elem.Context == ".") break;
            }
            if(this.Elements.Count > 0)
            {
                this.Name = this.Elements[0].Context;
            }
            elems.RemoveRange(index, i - index + 1);
        }
    }
}
