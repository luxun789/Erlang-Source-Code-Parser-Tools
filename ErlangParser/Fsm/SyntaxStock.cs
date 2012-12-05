using System.ComponentModel;
namespace ErlangParserLib.Fsm
{
    [DefaultProperty("Value")]
    public class SyntaxStock
    {
        public string Value {get; set;}
        public bool IsPop {get; set;}
    }
}
