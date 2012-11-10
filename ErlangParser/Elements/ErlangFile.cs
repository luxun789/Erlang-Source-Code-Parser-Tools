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

    }
}
