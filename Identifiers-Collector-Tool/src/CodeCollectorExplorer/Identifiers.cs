using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollectorExplorer
{
    public class Identifier
    {
        public string Name { get; set; }

        public Identifier()
        {
            Identifiers = new List<Identifier>();
        }

        public string ToString()
        {
            return Name + " " + From + "->" + To;
        }

        public Identifier Parent;
        public List<Identifier> Identifiers;
        public int From { get; set; }
        public int To { get; set; }
        public int BlockAt { get; internal set; }
    }
}
