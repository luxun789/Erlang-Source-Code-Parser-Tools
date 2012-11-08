using System;
using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang文件基础类
    /// </summary>
    public class ErlangFile : ErlangElement, IDisposable
    {
        public ErlangFile()
            : base(FsmStatus.FSM_FILE)
        {
        }

        /// <summary>
        /// 所有的注释行
        /// </summary>
        public List<ErlangComment> Comments = new List<ErlangComment>();

        /// <summary>
        /// 所有的声明
        /// </summary>
        public List<ErlangDeclaration> Declarations = new List<ErlangDeclaration>();

        /// <summary>
        /// 结构重组
        /// </summary>
        public override void Reorganization()
        {
            if (this.Elements == null) return;

            int i = 0;
            ErlangElement prev = null;
            ErlangElement elem = null;
            while (i < this.Elements.Count)
            {
                elem = this.Elements[i];

                if (elem.Context.StartsWith("%"))
                {
                    using (ErlangComment c = new ErlangComment())
                    {
                        c.Context = elem.Context;
                        c.GroupName = elem.GroupName;
                        c.Index = elem.Index;
                        this.Elements[i] = c;
                        this.Comments.Add(c);
                    }
                }
                else if (elem.Context.Equals("-"))
                {
                    using (ErlangDeclaration d = new ErlangDeclaration())
                    {
                        d.Index = elem.Index;
                        int j = 0;
                        for (j = i; j < this.Elements.Count; j++)
                        {
                            using (ErlangElement edec = this.Elements[j])
                            {
                                d.Elements.Add(edec);
                                d.Context += edec.Context;

                                if (edec.Context.Equals(".")) break;
                            }
                        }
                        this.Elements.RemoveRange(i, j - i);
                        d.Reorganization();
                        this.Elements.Insert(i, d);
                        this.Declarations.Add(d);
                    }
                }
                else if (elem.GroupName.Equals("Function"))
                {
                    using (ErlangFunction f = new ErlangFunction())
                    {
                    }
                }

                prev = elem;
                i++;
            }
        }

        void IDisposable.Dispose()
        {
        }
    }
}
