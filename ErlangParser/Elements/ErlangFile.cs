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

        public List<ErlangComment> Comments = new List<ErlangComment>();
        public Dictionary<string, ErlangDeclaration> Declarations = new Dictionary<string, ErlangDeclaration>();
        public Dictionary<string, ErlangFunction> Funcations = new Dictionary<string, ErlangFunction>();

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

                    this.Comments.Add(c);
                }
                else if(elem.Context.Equals("-"))
                {
                    //重组定义
                    ErlangDeclaration d = new ErlangDeclaration();
                    d.Repo(elems, i);
                    elems.Insert(i, d);

                    this.Declarations.Add(d.Name, d);
                }
                else if(elem.GroupName == "Function")
                {
                    //重组函数
                    ErlangFunction f = new ErlangFunction();
                    f.Repo(elems, i);
                    elems.Insert(i, f);

                    this.Funcations.Add(f.Name + "/" + f.Arguments.Elements.Count, f);
                }
                i ++;
            }
        }

    }

}
