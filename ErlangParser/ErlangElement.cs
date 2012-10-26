namespace ErlangParserLib
{
    public enum ElementType : int
    {
        COMMENT = 1,
        STATEMENT = 2,
        FUNCTION = 3,
        None = 0
    }
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
