using System.Collections.Generic;
using ErlangParserLib.Fsm;
using System;

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
        /// 所有函数
        /// </summary>
        public List<ErlangFunction> Functions = new List<ErlangFunction>();

        /// <summary>
        /// 函数组
        /// </summary>
        public Dictionary<string, List<ErlangFunction>> FuncionGroups = new Dictionary<string, List<ErlangFunction>>();

        /// <summary>
        /// 元素重组
        /// </summary>
        public void Repo()
        {
            int i = 0;
            while(i < this.Elements.Count)
            {
                ErlangElement elem = this.Elements[i] as ErlangElement;

                if(elem.Context.StartsWith("%"))
                {
                    ErlangComment c  = new ErlangComment();
                    elem.CopyTo(c);
                    this.Comments.Add(c);
                }
                i++;
            }
        }

    }

}
