using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollector
{
    public class XRef
    {
        public FileInfo File;
        public int From;
        public int BlockBegin;
        public int To;
        public List<XMethod> Methods = null;

        public string ToString()
        {
            return File.Name;
        }

        public XRef(FileInfo file, int from, int blockAt, int to)
        {
            this.File = file;
            this.From = from;
            this.BlockBegin = blockAt;
            this.To = to;
            Methods = new List<XMethod>();
        }
    }
}
