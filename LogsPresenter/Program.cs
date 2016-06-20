using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsPresenter
{
    class Program
    {
        private static string DiagramImagePath = "C:\\Logs\\ImgDiagram.png";
        static void Main(string[] args)
        {
            GenerateGraph(0, -1, false);
            //int tolerance = 0;
            //Int32.TryParse(toleranceTextBox.Text, out tolerance);
            //GenerateGraph(1, tolerance, toleranceCheckBox.Checked);
        }

        private static void GenerateGraph(int mode, int tolerance, bool showAboveOnly)
        {
            DiagramSourceWriter dsw = new DiagramSourceWriter();
            dsw.ToGraphvizDiagram(mode, tolerance, showAboveOnly);
            dsw.ToXml(mode, tolerance, showAboveOnly);
            dsw.ToJson(mode, tolerance, showAboveOnly);
            dsw.ToHtml(mode, tolerance, showAboveOnly);
            //AddInfo(DiagramSourceWriter.Statistics);
            string output = "diagram";
            string GraphVizPath = "C:\\Program Files (x86)\\Graphviz2.38\\bin";

            if (File.Exists(GraphVizPath + "\\dot.exe"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                if (mode == 0)
                {
                    startInfo.FileName = GraphVizPath + "\\dot.exe";
                    startInfo.Arguments = "-Tpng -o " + DiagramImagePath + " C:\\Log\\" + output + ".gv";
                }
                else if (mode == 1)
                {
                    startInfo.FileName = GraphVizPath + "\\sfdp.exe";
                    startInfo.Arguments = "-Tpng -o " + DiagramImagePath + " -x -Goverlap=prism C:\\Log\\" + output + ".gv";
                }
                else
                {
                    startInfo.FileName = GraphVizPath + "\\sfdp.exe";
                    startInfo.Arguments = "-Tpng -o " + DiagramImagePath + " -x -Goverlap=prism C:\\Log\\" + output + ".gv";
                }
                /*
                try
                {
                    File.Copy(DiagramImagePath.Replace(".png", "4.png"), DiagramImagePath.Replace(".png", "5.png"), true);
                }
                catch (Exception e5)
                {
                }
                try
                {
                    File.Copy(DiagramImagePath.Replace(".png", "3.png"), DiagramImagePath.Replace(".png", "4.png"), true);
                }
                catch (Exception e4)
                {
                }
                try
                {
                    File.Copy(DiagramImagePath.Replace(".png", "2.png"), DiagramImagePath.Replace(".png", "3.png"), true);
                }
                catch (Exception e3)
                {
                } 
                try
                {
                    File.Copy(DiagramImagePath.Replace(".png", "1.png"), DiagramImagePath.Replace(".png", "2.png"), true);
                }
                catch (Exception e2)
                {
                }
                try
                {
                    File.Copy(DiagramImagePath, DiagramImagePath.Replace(".png", "1.png"), true);
                }
                catch (Exception e1)
                {
                }
                */
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                Process p = Process.Start(startInfo);
                p.WaitForExit();
            }
            else
            {
                FileInfo newFile = new FileInfo("C:\\logs\\" + output + ".gv");
                ProcessStartInfo startInfo = new ProcessStartInfo(GraphVizPath + "\\Gvedit.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;

                if (output.Equals("overview"))
                {
                    Process.Start(startInfo);
                }

                startInfo.Arguments = " -Tpng:dot -O \"C:\\logs\\" + newFile.Name + "\"";
                startInfo.Arguments = " sfdp -x -Goverlap=prism -Tpng data.dot > data.png";

                Process.Start(startInfo);
                int ps = 200;
                System.Threading.Thread.Sleep(1000);
                FileInfo graphFile = new FileInfo(".png");
                //graphFile.CopyTo("C:\\logs\\" + output + ".png", true);
            }
        }
    }
}
