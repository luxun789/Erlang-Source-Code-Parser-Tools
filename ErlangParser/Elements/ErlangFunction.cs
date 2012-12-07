using System.Collections.Generic;
using ErlangParserLib.Fsm;

namespace ErlangParserLib.Elements
{
    public class ErlangFunction : ErlangElement
    {
        /// <summary>
        /// 函数名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 形参表
        /// </summary>
        public ErlangFunctionArguments Arguments {get; set;}

        public override void Repo(List<IErlangElement> elems, int index)
        {
            IErlangElement elem = elems[index] as IErlangElement;
            elem.CopyTo(this);

            int i = index + 1;

            this.Arguments = new ErlangFunctionArguments();
            for (; i < elems.Count; i++)
            {
                elem = elems[i];
                this.Elements.Add(elem);
                if(elem.Context == "(")
                {
                    //生成形参表
                    this.Arguments.Repo(elem.Elements, 0);
                }
                else if(elem.Context == ";" || elem.Context == ".")
                {
                    break;
                }
            }
            if(this.Elements.Count > 0)
            {
                this.Context += "/" + this.Arguments.Elements.Count;
                this.Name = this.Context;
            }
            
            elems.RemoveRange(index, this.Elements.Count);
        }

    }

}
