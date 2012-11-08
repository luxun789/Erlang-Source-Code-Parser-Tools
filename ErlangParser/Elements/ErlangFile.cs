using ErlangParserLib.Fsm;

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
        /// 结构重组
        /// </summary>
        public override void Reorganization()
        {
            if(this.Elements == null) return;

            int i = 0;
            ErlangElement prev = null;
            ErlangElement elem = null;
            while(i < this.Elements.Count)
            {
                elem = this.Elements[i];

                if(elem.Context.StartsWith("%"))
                {
                    Comment c = new Comment();
                    c.Context = elem.Context;
                    c.GroupName = elem.GroupName;
                    c.Index = elem.Index;
                    this.Elements[i] = c;
                }
                else if(elem.Context.Equals("-"))
                {
                    Declaration d = new Declaration();
                    d.Index = elem.Index;
                    int j = 0;
                    for(j = i; j < this.Elements.Count; j ++)
                    {
                        ErlangElement edec = this.Elements[i];
                        d.Elements.Add(edec);
                        if(edec.Context.Equals(".")) break;
                    }
                    this.Elements.RemoveRange(i, j - i + 1);
                }

                prev = elem;
                i++;
            }
        }
    }
}
