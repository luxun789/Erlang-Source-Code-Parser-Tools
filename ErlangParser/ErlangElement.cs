namespace ErlangParserLib
{
    /// <summary>
    /// 元素类别
    /// </summary>
    public enum ElementType : short
    {
        COMMENT = 1,
        STATEMENT = 2,
        FUNCTION = 3,
        None = 0
    }

    /// <summary>
    /// Erlang元素基类
    /// </summary>
    public class  ErlangElement
    {
        public ErlangElement(ElementType etype)
        {
            this.EType = etype;
        }

        public ElementType EType {get; private set;}

        public string Context {get; set;}
    }
}
