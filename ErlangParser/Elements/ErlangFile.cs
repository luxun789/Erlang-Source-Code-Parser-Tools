using System.Collections.Generic;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang文件基础类
    /// </summary>
    public class ErlangFile
    {
        /// <summary>
        /// 文件中所有Erlang语法元素.
        /// </summary>
        public List<ErlangElement> Elements = new List<ErlangElement>();
    }
}
