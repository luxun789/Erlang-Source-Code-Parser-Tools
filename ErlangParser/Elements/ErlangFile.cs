using System.Collections.Generic;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang文件基础类
    /// </summary>
    public class ErlangFile : ErlangElement
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
        /// 所有函数
        /// </summary>
        [JsonIgnore()]
        public List<ErlangFunction> Functions = new List<ErlangFunction>();

        /// <summary>
        /// 函数组
        /// </summary>
        public Dictionary<string, List<ErlangFunction>> FuncionGroups = new Dictionary<string, List<ErlangFunction>>();

        /// <summary>
        /// 结构重组
        /// </summary>
        public void Reorganization()
        {
            if (this.Elements == null) return;

            int i = 0;
            int len = 0;
            ErlangElement prev = null;
            ErlangElement elem = null;
            while (i < this.Elements.Count)
            {
                //获取元素
                elem = this.Elements[i];
                if (elem.Context.StartsWith("%"))
                {
                    using (ErlangComment c = new ErlangComment())
                    {
                        len = c.Reorganization(this.Elements, i);

                        this.Elements.RemoveRange(i, len);
                        this.Elements.Insert(i, c);
                        this.Comments.Add(c);
                    }
                }
                else if (elem.Context.Equals("-"))
                {
                    using (ErlangDeclaration d = new ErlangDeclaration())
                    {
                        len = d.Reorganization(this.Elements, i);
                        this.Elements.RemoveRange(i, len);
                        this.Elements.Insert(i, d);
                        this.Declarations.Add(d);
                    }
                }
                else if (elem.GroupName.Equals("Function"))
                {
                    using (ErlangFunction f = new ErlangFunction())
                    {
                        len = f.Reorganization(this.Elements, i);
                        this.Elements.RemoveRange(i, len);
                        this.Elements.Insert(i, f);
                        this.Functions.Add(f);

                        //函数分组
                        List<ErlangFunction> funs = null;
                        if(!this.FuncionGroups.ContainsKey(f.Name))
                        {
                            funs = new List<ErlangFunction>();
                            this.FuncionGroups.Add(f.Name, funs);
                        }
                        else
                        {
                            funs = this.FuncionGroups[f.Name];
                        }
                        funs.Add(f);
                    }
                }
                prev = elem;
                i++;
            }

        }
    }
}
