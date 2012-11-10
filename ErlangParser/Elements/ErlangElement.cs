using System;
using System.Collections.Generic;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;

namespace ErlangParserLib.Elements
{
    /// <summary>
    /// Erlang元素基类
    /// </summary>
    public class  ErlangElement : IDisposable
    {
        public ErlangElement(FsmStatus etype)
        {
            this.EType = etype;
            this.Context = string.Empty;
            this.Index = -1;
            this.GroupName = string.Empty;
            this.Elements = new List<ErlangElement>();
        }

        [JsonIgnore()]
        public FsmStatus EType { get; set; }

        public string Context {get; set;}

        [JsonIgnore()]
        public int Index {get; set;}

        //[JsonIgnore()]
        public List<ErlangElement> Elements {get; set;}

        [JsonIgnore()]
        public string GroupName {get; set;}

        /// <summary>
        /// 元素重组
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public virtual int Reorganization(List<ErlangElement> elements)
        {
            return Reorganization(elements, 0);
        }

        /// <summary>
        /// 元素重组
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public virtual int Reorganization(List<ErlangElement> elements, int startIndex)
        {
            int len = 0;
            len = this.Reorganization(elements, startIndex, null, string.Empty);
            return len;
        }

        public int Reorganization(List<ErlangElement> elements, int startIndex, ErlangElement root, string endChar)
        {
            int len = 0;
            ErlangElement elem;
            string[] chs = null;
            for (int i = startIndex; i < elements.Count; i++, len++)
            {
                elem = elements[i];
                chs = FsmCheck.IsStockChar(elem.Context);
                if (chs != null)
                {
                    ErlangElement newnode = new ErlangElement(FsmStatus.FSM_UNDEFINE);
                    newnode.Index = elem.Index;
                    newnode.Elements.Add(elem);
                    int cnt = elem.Reorganization(elements, i + 1, newnode, chs[1]);
                    if(root != null)
                    {
                        root.Elements.Add(newnode);
                    }
                    else
                    {
                        //TODO someerror
                        elem.Elements.Add(newnode);
                    }
                    elements.RemoveRange(i, cnt);
                }
                else if(root != null && elem.Context.Equals(endChar))
                {
                    root.Elements.Add(elem);
                    break;
                }
                else if(root != null)
                {
                    root.Elements.Add(elem);
                }
            }

            return len;
        }

        /// <summary>
        /// 跳过空元素
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="startIndex"></param>
        /// <returns>下一个非空元素的下标</returns>
        public int SkipBlank(IList<ErlangElement> elements, int startIndex)
        {
            int index = 0;
            for (index = startIndex; index < elements.Count; index++)
            {
                if(!elements[index].GroupName.Equals("Blank"))
                {
                    break;
                }
            }
            return index;
        }

        void IDisposable.Dispose()
        {
        }
    }
}
