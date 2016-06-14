using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollector
{
    public class XNamespace
    {
        public string Name { get; set; }
        public List<XRef> Files;
        public List<XClass> Classes;

        public string ToString()
        {
            return Name;// + " " + Files[0].Offset + " : " + Files[0].BlockBegin + "->" + Files[0].BlockEnd + "";
        }

        public void AddRef(FileInfo file, int index, int blockOffset, int blockLength)
        {
            if (Files == null)
            {
                Files = new List<XRef>();
            }
            if (null == Files.Where(p => p.File.FullName.Equals(file.FullName)).FirstOrDefault())
            {
                Files.Add(new XRef(file, index, blockOffset, blockLength));
            }
            else
            {

            }
        }

        public XNamespace(string name)
        {
            this.Name = name;
        }
    }
}
