using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollectorExplorer
{
    public class MarkedFile
    {
        public MarkedFile(string line)
        {
            string[] data = line.Split();
            this.Path = data[1];
            this.Name = data[1].IndexOf('\\') > 0 ? data[1].Substring(data[1].LastIndexOf('\\')+1) : data[1];
            Marker currrentMarker = new Marker();
            currrentMarker.From = 0;
            RootMarker = new Marker();
            currrentMarker.Parent = RootMarker;
            RootMarker.Markers.Add(currrentMarker);
            int pos = 0;
            string[] pairs = data[0].Split(new char[] { '/' }, StringSplitOptions.None);
            foreach(string pair in pairs)
            {
                string[] info = pair.Split(new char[] { '-' }, StringSplitOptions.None);
                int.TryParse(info[0], out pos);
                if(info.Length == 2)
                switch(info[1])
                {
                    case ";":
                        Marker m = new Marker();
                        m.From = pos + 1;
                        m.Parent = currrentMarker.Parent;
                        currrentMarker.Parent.Markers.Add(m);
                        currrentMarker.To = pos+1;
                        currrentMarker = m;
                        break;
                    case "{":
                        currrentMarker.BlockAt = pos+1;
                        Marker c = new Marker();
                        c.From = pos + 1;
                        c.Parent = currrentMarker;
                        currrentMarker.Markers.Add(c);
                        currrentMarker = c;
                        break;
                    case "}":
                        currrentMarker.To = pos;
                        currrentMarker.Parent.To = pos;
                        currrentMarker.Parent.Markers.Remove(currrentMarker);
                        currrentMarker = currrentMarker.Parent;

                            Marker n = new Marker();
                            n.From = pos + 1;
                            if(currrentMarker.Parent == null)
                            {
                                return;
                            }
                            n.Parent = currrentMarker.Parent;
                            currrentMarker.Parent.Markers.Add(n);
                            currrentMarker.To = pos + 1;
                            currrentMarker = n;

                            break;
                    case "~":
                        currrentMarker.From = pos;
                        break;
                }
            }
            currrentMarker.Parent.To = currrentMarker.From;
            currrentMarker.Parent.Markers.Remove(currrentMarker);
        }

        public string Path { get; set; }
        public string Name { get; set; }
        public Marker RootMarker { get; set; }
    }
    public class Marker
    {
        public Marker()
        {
            Markers = new List<Marker>();
        }

        public string ToString()
        {
            return From + "->" + To;
        }

        public Marker Parent;
        public List<Marker> Markers;
        public int From { get; set; }
        public int To { get; set; }
        public int BlockAt { get; internal set; }
    }
}
