using ErlangParserLib.Elements;

namespace ErlangParserLib.Fsm
{
    public static class Utils
    {
        /// <summary>
        /// 复制成生一个新结点
        /// </summary>
        /// <param name="source"></param>
        /// <param name="desc"></param>
        public static void CopyTo(this IErlangElement source, IErlangElement desc)
        {
            desc.Context = source.Context;
            desc.Elements = source.Elements;
            desc.Index = source.Index;
            desc.GroupName = source.GroupName;
            desc.Parent = source.Parent;
            desc.Next = source.Next;
            desc.Prev = source.Prev;
            desc.Index = source.Index;
        }

    }
}
