namespace ErlangParserLib.Elements
{
    public class ErlangFunction : ErlangElement
    {
        /// <summary>
        /// 函数名
        /// </summary>
        public string Name {get; set;}

        public ErlangFunction()
            : base(ElementType.FUNCTION)
        {
        }
    }
}
