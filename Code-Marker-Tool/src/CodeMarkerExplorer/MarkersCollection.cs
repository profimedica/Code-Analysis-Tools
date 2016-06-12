using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMarkerExplorer
{
    public class MarkersCollection
    {
        public static string MarkersFilePath = "C:\\Logs\\Markers.txt";
        public MarkersCollection()
        {
            LoadMarkers();
        }
        public ObservableCollection<MarkedFile> markedFiles { get; set; }
        private void LoadMarkers()
        {
            if (!File.Exists(MarkersFilePath))
            {
                File.Create(MarkersFilePath).Close();
            }
            string[] lines = File.ReadAllLines(MarkersFilePath);
            markedFiles = new ObservableCollection<MarkedFile>();
            foreach (string line in lines)
            {
                MarkedFile markedFile = new MarkedFile(line);
                markedFiles.Add(markedFile);
            }
        }
    }
}
