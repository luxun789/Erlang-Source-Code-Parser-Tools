using System.Collections.Generic;
namespace ErlangParserLib.Elements
{
    /// <summary>
    /// 形参表
    /// </summary>
    public class ErlangFunctionArguments : ErlangElement
    {
        public ErlangFunctionArguments()
            :base()
        {
            this.EType = Fsm.FsmStatus.FSM_FUNCTION_ARGUMENTS;
        }

        public override void Repo(List<IErlangElement> elems, int index)
        {
            int i = index;
            IErlangElement elem;
            for(; i < elems.Count; i ++)
            {
                elem = elems[i];
                if(elem.Context != ",")
                {
                    this.Elements.Add(elem);
                }
                if(elem.Context.Equals(")"))
                {
                    break;
                }
            }
        }
    }
}
