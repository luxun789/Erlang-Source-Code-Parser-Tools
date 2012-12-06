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
            IErlangElement elem = elems[index];
            i = index;
            while (i < this.Elements.Count)
            {
                elem = elems[i];
                if (elem.Context.StartsWith("%"))
                {
                    //重组注释
                    ErlangComment c = new ErlangComment();
                    c.Repo(elems, i);
                    elems.Insert(i, c);
                }
                else if(elem.Context.Equals("-"))
                {
                    //重组定义
                    ErlangDeclaration d = new ErlangDeclaration();
                    d.Repo(elems, i);
                    elems.Insert(i, d);
                }
                else if(elem.GroupName == "Function")
                {
                    ErlangFunction f = new ErlangFunction();
                    f.Repo(elems, i);
                    elems.Insert(i, f);
                }
                i ++;
            }
        }

    }

}
