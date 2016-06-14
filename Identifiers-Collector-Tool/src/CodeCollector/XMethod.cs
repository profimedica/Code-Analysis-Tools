using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollector
{
    public class XMethod
    {
        public XMethod(string name)
        {
            this.Name = name;
        }

        public string Text { get; set; }

        public string Name { get; set; }
        public XClass Class { get; set; }
        public XNamespace Namespace { get; set; }
        public XRef File { get; set; }
        public int From { get; set; }
        public int BlockBegin { get; set; }
        public int To { get; set; }
    }
}
