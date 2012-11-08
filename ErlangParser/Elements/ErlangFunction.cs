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

        public ErlangFunction()
            : base(FsmStatus.FSM_FUNCTION)
        {
        }

        /// <summary>
        /// 函数重组
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public override int Reorganization(IList<ErlangElement> elements, int startIndex)
        {
            int len = 0;
            int index = startIndex;

            ErlangElement elem;

            //函数头部
            elem = elements[startIndex];
            this.Name = elem.Context;
            index = base.SkipBlank(elements, ++index);

            //参数表
            for(int i = index; i < elements.Count; i++, index++)
            {
                elem = elements[i];
                if(elem.GroupName.Equals("p"))
                {
                    switch(elem.Context)
                    {
                        case "->":
                        {
                            i = elements.Count;
                            break;
                        }
                    }
                }
            }

            for(int i = startIndex; i <= index; i ++, len ++)
            {
                this.Elements.Add(elements[i]);
            }

            return len;
        }
    }

}
