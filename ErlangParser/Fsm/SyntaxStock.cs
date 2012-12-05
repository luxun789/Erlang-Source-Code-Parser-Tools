using System.ComponentModel;
namespace ErlangParserLib.Fsm
{
    [DefaultProperty("Value")]
    public class SyntaxStock
    {
        /// <summary>
        /// 判断值
        /// </summary>
        public string Value {get; set;}

        /// <summary>
        /// 是否回溯
        /// </summary>
        public bool IsPrev {get; set;}
    }
}
