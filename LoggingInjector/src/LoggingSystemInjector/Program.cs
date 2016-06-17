using CodeCollector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemInjector
{
    class Program
    {
        static string WorkingFolder = "C:\\Logs";
        static string RootFolder = "C:\\MethodsCatalog\\src";
        static string IdentifiersFileName = "Identifiers.txt";
        static string file = "";

        static bool RemoveFromFile = true;
        static void Main(string[] args)
        {
            file = WorkingFolder + "\\" + IdentifiersFileName;
            PrepareIdentifiers();
            if (RemoveFromFile)
            {
                string[] lines = File.ReadAllLines("C:\\Logs\\Log.html");
            }
            else
            {
                WriteLog();
            }
        }

        private static void WriteLog()
        {
            foreach(XNamespace n in namespaces)
            {
                foreach(XClass c in n.Classes)
                {
                    c.Namespace = n;
                    foreach(XRef f in c.Files)
                    {
                        if (f.File.Exists)
                        {
                            string content = File.ReadAllText(f.File.FullName.Replace("MethodsCatalog\\", "MC\\"));
                            int offset = 0;
                            foreach (XMethod m in f.Methods)
                            {
                                m.Class = c;
                                int insertionPoint = GetInsertionPoint(content, offset + m.File.BlockBegin);
                                if (
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get\n") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("set\n") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get\r") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("set\r") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get;") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("set;") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get {") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get {") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get{") ||
                                    content.Substring(m.File.BlockBegin, m.File.To - m.File.BlockBegin).Contains("get{")
                                    )
                                {

                                }
                                else
                                {
                                    if (!content.Substring(offset, tab.Length + 9).Trim().Equals("/*LoggingSystem "))
                                    {
                                        string log = tab + GetLogLine(m);
                                        content = content.Substring(0, insertionPoint) + log + content.Substring(insertionPoint);
                                        offset += log.Length;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        static string tab = "";
        private static int GetInsertionPoint(string content, int v)
        {
            int newLineIndex = v;
            int i = v;
            while (i< content.Length-1 && (char.IsWhiteSpace(content[i]) || char.IsControl(content[i])))
            {
                if (content[i].Equals('\n'))
                {
                    newLineIndex = i;
                }
                i++;
            }
            tab = content.Substring(newLineIndex + 1, i- newLineIndex-1);
            return newLineIndex;
        }

        private static int MethodNumber = 1;

        private static string GetLogLine(XMethod m)
        {
            return "/*LoggingSystem to be removed from production code*/ LoggingSystem.MyLogger.Log(new LoggingSystem.LoggingElement(){ Nr= " +
                    (MethodNumber++) + "," +
                    " Namespace = \"" + m.Class.Namespace.Name + "\"," +
                    " Class = \"" + m.Class.Name + "\"," +
                    " Method = \"" + m.Class.Methods + "\" });\r\n"; // m.Class.Namespace.Name + ", " + m.Class.Name + ", " + m.Name + "";
        }

        static List<XNamespace> namespaces = new List<XNamespace>();

        private static void PrepareIdentifiers()
        {
            namespaces.Clear();

            XNamespace currentNamespace = null;
            XClass currentClass = null;
            XRef currentFile = null;
            XMethod currentMethod = null;

            String path = null;
            int ante, from, blockAt, to;
            foreach (string line in File.ReadAllLines(file))
            {
                ante = 0;
                from = 0;
                blockAt = 0;
                to = 0;
                string[] elements = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (elements.Length > 0)

                    switch (elements[0])
                    {
                        case "N":
                            currentNamespace = new XNamespace(elements[1]);
                            namespaces.Add(currentNamespace);
                            break;
                        case "\tC":
                            currentClass = new XClass(elements[1]);
                            currentNamespace.Classes.Add(currentClass);
                            break;
                        case "\t\tF":
                            currentFile = new XRef(new FileInfo(elements[1]), 0, 0, 0);
                            currentClass.Files.Add(currentFile);
                            break;
                        case "\t\t\tM":
                            currentMethod = new XMethod(elements[1]);
                            currentFile.Methods.Add(currentMethod);
                            string[] markers = elements[elements.Length - 1].Split(':');
                            if (markers.Length == 4)
                            {
                                int.TryParse(markers[0], out ante);
                                Array.Copy(markers, 1, markers, 0, markers.Length - 1);
                            }
                            if (int.TryParse(markers[0], out from) && int.TryParse(markers[1], out blockAt) && int.TryParse(markers[2], out to))
                            {
                                currentMethod.File = new XRef(currentFile.File, from, blockAt, to);
                            }
                            break;
                        default:
                            break;
                    }

            }
        }

    }
}
