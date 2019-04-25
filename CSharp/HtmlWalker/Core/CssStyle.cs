using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HtmlWalker.Core
{
    public class CssStyle : SortedDictionary<string, string>, ICloneable
    {
        public CssStyle() { }

        public CssStyle(string css) { Properties = css; }

        public string Properties
        {
            get
            {
                if (Count == 0)
                    return null;
                return this.Select(p => p.Key + ":" + p.Value).Aggregate((p0, p1) => p0 + ";" + p1);
            }
            set
            {
                if (value == null)
                    Clear();
                else
                {
                    var pairs = value.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var pair in pairs)
                    {
                        var prop = pair.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        if (prop.Length == 2)
                        {
                            if (ContainsKey(prop[0]))
                                this[prop[0].ToLower().Trim()] = prop[1].Trim();
                            else
                                Add(prop[0].ToLower().Trim(), prop[1].Trim());
                        }
                    }
                }
            }
        }

        public object Clone() => new CssStyle().Properties = Properties;
    }
}
