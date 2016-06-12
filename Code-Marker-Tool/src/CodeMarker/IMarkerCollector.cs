using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMarker
{
    public interface IMarkerCollector
    {
        /// <summary>
        /// Return markers for given filePath
        /// </summary>
        string CollectMarkers(string path);
    }
}
            