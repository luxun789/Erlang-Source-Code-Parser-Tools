using System.Collections.Generic;

namespace ErlangParserLib.Elements
{
    public class ErlangDomTree
    {
        public ErlangElement Current { get; set;}

        public List<ErlangElement> Nodes = new List<ErlangElement>();
    }
}
