using System.Collections.Generic;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;

namespace ErlangParserLib.Statement
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

        [JsonIgnore()]
        public List<ErlangComment> Comments = new List<ErlangComment>();

        [JsonIgnore()]
        public Dictionary<string, List<ErlangDeclaration>> Declarations = new Dictionary<string, List<ErlangDeclaration>>();

        [JsonIgnore()]
        public Dictionary<string, List<ErlangFunction>> Funcations = new Dictionary<string, List<ErlangFunction>>();

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

                    if(!this.Declarations.ContainsKey(d.Name))
                    {
                        this.Declarations.Add(d.Name, new List<ErlangDeclaration>());
                    }
                    this.Declarations[d.Name].Add(d);
                }
                else if(elem.GroupName == "Function")
                {
                    //重组函数
                    ErlangFunction f = new ErlangFunction();
                    f.Repo(elems, i);
                    elems.Insert(i, f);

                    string key = f.Name + "/" + f.Arguments.Elements.Count;
                    if(!this.Funcations.ContainsKey(key))
                    {
                        this.Funcations.Add(key, new List<ErlangFunction>());
                    }
                    this.Funcations[key].Add(f);
                }
                i ++;
            }
        }

    }

}
