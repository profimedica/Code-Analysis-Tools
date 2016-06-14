using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollector
{
    public class XFile
    {
        public FileInfo File;
        public List<XNamespace> Namespaces;
        public List<XClass> Classes;

        public XFile(FileInfo file)
        {
            this.File = file;
        }
    }
}
