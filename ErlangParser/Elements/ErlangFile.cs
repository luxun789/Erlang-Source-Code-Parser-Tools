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
        /// 所有的注释行
        /// </summary>
        public List<ErlangComment> Comments = new List<ErlangComment>();

        /// <summary>
        /// 所有的声明
        /// </summary>
        public Dictionary<string, ErlangDeclaration> Declarations = new Dictionary<string, ErlangDeclaration>();

        /// <summary>
        /// 函数组
        /// </summary>
        public Dictionary<string, List<ErlangFunction>> FuncionGroups = new Dictionary<string, List<ErlangFunction>>();

        /// <summary>
        /// 元素重组
        /// </summary>
        public void Repo()
        {
            IErlangElement elem = this.Next;
            while (elem != null)
            {
                if (elem.Context.StartsWith("%"))
                {
                    //重组注释
                    ErlangComment c = new ErlangComment();
                    elem.CopyTo(c);
                    this.Comments.Add(c);
                    int index = this.Elements.IndexOf(elem);
                    this.Elements.RemoveAt(index);
                    this.Elements.Insert(index, c);

                }
                elem = elem.Next;
            }
        }

    }

}
