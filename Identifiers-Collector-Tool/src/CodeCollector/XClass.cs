using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollector
{
    [MyMarker(SomeData=8)]
    public class XClass
    {
        public XNamespace Namespace { get; set; }
        public string Name { get; set; }
        public List<XRef> Files;

        public List<XMethod> Methods;
        
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
        public XClass(string name)
        {
            this.Name = name;
            Files = new List<XRef>();
            Methods = new List<XMethod>();
        }
    }

    internal class MyMarkerAttribute : Attribute
    {
        public int SomeData { get; set; }
    }
}
