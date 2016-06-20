using CodeCollector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogsPresenter
{
        public class DiagramSourceWriter
        {
            public static List<CallElement> CallSequence = new List<CallElement>();


            public static string Statistics = "";
            /// <summary>
            /// Extracted only for debug (allow changes of containing functions at debug time)
            /// </summary>
            /// <param name="times"></param>
            /// <param name="Number"></param>
            /// <returns></returns>
            private MethodHitInfo GetRelationByMethodsNumber(List<MethodHitInfo> times, string Number)
            {
                return times.Where(p => p.Number.Equals(Number)).FirstOrDefault();
            }

        internal void ToXml(int mode, int tolerance, bool showAboveOnly)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<Namespaces>");
            foreach (XNamespace myNamespace in namespaces)
            {
                sb.AppendLine("\t<Namespace Name=\"" + myNamespace.Name + "\">");
                foreach (XClass myClass in myNamespace.Classes)
                {
                    sb.AppendLine("\t\t<Class Name=\"" + myClass.Name + "\">");
                    foreach (XRef myFile in myClass.Files)
                    {
                        //sb.AppendLine("<File Name=\"" + myFile.File.FullName + "\">")
                        foreach (XMethod myMethod in myFile.Methods)
                        {
                            sb.AppendLine("\t\t\t<Method Name=\"" + myMethod.Name + "\"/>");
                        }
                        //sb.AppendLine("</File>");
                    }
                    sb.AppendLine("\t\t</Class>");
                }
                sb.AppendLine("\t</Namespace>");
            }
            sb.AppendLine("</Namespaces>");
            File.WriteAllText("C:\\Logs\\IdentifiersAsXml.xml", sb.ToString());
        }

        internal void ToJson(int mode, int tolerance, bool showAboveOnly)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder cc = new StringBuilder();
            StringBuilder mm = new StringBuilder();
            sb.Append("{ \"Namespaces\":{");
            StringBuilder nn = new StringBuilder();
            foreach (XNamespace myNamespace in namespaces)
            {
                nn.Append(", \r\n\t\"" + myNamespace.Name + "\":{");
                cc = new StringBuilder();
                foreach (XClass myClass in myNamespace.Classes)
                {
                    cc.Append(", \r\n\t\t\"" + myClass.Name + "\":{");
                    foreach (XRef myFile in myClass.Files)
                    {
                        //sb.AppendLine("<File Name=\"" + myFile.File.FullName + "\">")
                        if (myFile.Methods.Count > 0)
                        {
                            mm = new StringBuilder();
                            foreach (XMethod myMethod in myFile.Methods)
                            {
                                mm.Append(", \r\n\t\t\t\"" + myMethod.Name + "\":{}");
                            }
                            //sb.AppendLine("</File>");
                            //cc.Append(mm.ToString().Substring(2));
                        }
                    }
                    cc.Append(mm.ToString().Substring(2));
                    cc.Append("\r\n\t\t}");
                }
                nn.Append(cc.ToString().Substring(2));
                nn.Append("\r\n\t}");
            }
            sb.Append(nn.ToString().Substring(2));
            sb.Append("\r\n}}");
            File.WriteAllText("C:\\Logs\\IdentifiersAsJson.xml", sb.ToString());
        }

        internal void ToHtml(int mode, int tolerance, bool showAboveOnly)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder cc = new StringBuilder();
            StringBuilder mm = new StringBuilder();
            sb.AppendLine("<BODY>");
            sb.AppendLine("     <style>");
            sb.AppendLine("         .ball {");
            sb.AppendLine("             display: inline-block;");
            sb.AppendLine("             width: 13px;");
            sb.AppendLine("             height: 14px;");
            sb.AppendLine("             margin: 3px auto 0;");
            sb.AppendLine("             margin-right: 6px;");
            sb.AppendLine("             border-radius: 50%;");
            sb.AppendLine("             box-shadow: inset -2px -2px 4px rgba(0,0,0,0.7);");
            sb.AppendLine("         }");
            sb.AppendLine("         .nball{background-color: #cc0000;}");
            sb.AppendLine("         .cball{background-color: #FF5500;}");
            sb.AppendLine("         .mball{background-color: #0055cc;}");
            sb.AppendLine("         .namespace{color:black}");
            sb.AppendLine("         .class{color:red}");
            sb.AppendLine("         .method{color:blue}");
            sb.AppendLine("     </style>");
            sb.AppendLine("     <script>function clearSelection() {    if (document.selection && document.selection.empty)            {                document.selection.empty();            }            else if (window.getSelection)            {                var sel = window.getSelection();                sel.removeAllRanges();            }        }");
            sb.AppendLine("     </script>");
            StringBuilder nn = new StringBuilder();
            foreach (XNamespace myNamespace in namespaces)
            {
                sb.AppendLine("\t<span><span class='namespace' ondblclick=\"var n = document.getElementById('" + myNamespace.ID + "'); n.style.display = n.style.display == 'none' ? 'inline' : 'none'; clearSelection();\"><span class='ball nball'></span>" + myNamespace.Name + "</span><span id='" + myNamespace.ID + "'>");
                cc = new StringBuilder();
                foreach (XClass myClass in myNamespace.Classes)
                {
                    sb.AppendLine("\t\t<span><span class='class' ondblclick=\"var e = document.getElementById('" + myNamespace.ID + ":" + myClass.ID + "'); e.style.display = e.style.display == 'none' ? 'inline' : 'none'; clearSelection();\"><span class='ball cball'></span>" + myClass.Name + "</span><span id='" + myNamespace.ID + ":" + myClass.ID + "'>");
                    foreach (XRef myFile in myClass.Files)
                    {
                        //sb.AppendLine("<File Name=\"" + myFile.File.FullName + "\">")
                        if (myFile.Methods.Count > 0)
                        {
                            mm = new StringBuilder();
                            foreach (XMethod myMethod in myFile.Methods)
                            {
                                sb.AppendLine("\t\t\t<span class='method' title='" + myMethod.File.File.FullName + "'/><span class='ball mball'></span>" + myMethod.Name + "</span>,");
                            }
                            //sb.AppendLine("</File>");
                            //cc.Append(mm.ToString().Substring(2));
                        }
                    }
                    sb.AppendLine("\t\t</span></span>,");
                }
                sb.AppendLine("\t</span></span></span>");
            }
            sb.AppendLine("</BODY>");
            File.WriteAllText("C:\\Logs\\IdentifiersAsHtml.html", sb.ToString());
        }
        public static List<XNamespace> GetNamespaces()
            {
                CallSequence = new List<CallElement>();
                XMethod lastMethod = null;
                List<string> linesCsproj = File.ReadAllLines(@"C:\Logs\Identifiers.txt").ToList();
                StringBuilder sb = new StringBuilder();
                int lines = 0;

                List<HitRelationInfo> hitInfos = new List<HitRelationInfo>();
                List<XNamespace> namespaces = new List<XNamespace>();

                MethodHitInfo lastHittedInfo = null;
                foreach (string line in linesCsproj)
                {
                    if (line.Length < 10)
                    {
                        continue;
                    }
                    string pLine = line;
                    lines++;
                    MethodHitInfo tn = new MethodHitInfo();
                    if (pLine.Substring(25, 6).Equals("silver"))
                    {
                        tn.Component = 1;
                    }
                    else
                    {
                        tn.Component = 0;
                    }
                    tn.Namespace = pLine.Substring(0, pLine.IndexOf("</span>"));
                    tn.Namespace = tn.Namespace.Substring(tn.Namespace.LastIndexOf(">") + 1);
                    XNamespace currentNamespace = namespaces.Where(p => p.Name.Equals(tn.Namespace)).FirstOrDefault();
                    if (currentNamespace == null)
                    {
                        currentNamespace = new XNamespace(tn.Namespace);
                        namespaces.Add(currentNamespace);
                    }
                    pLine = pLine.Substring(pLine.IndexOf("</span>") + 7);
                    tn.Class = pLine.Substring(0, pLine.IndexOf("</span>"));
                    tn.Class = tn.Class.Substring(tn.Class.LastIndexOf(">") + 1);
                    XClass currentClass =
                        currentNamespace.Classes.Where(p => p.Name.Equals(tn.Class)).FirstOrDefault();
                    if (currentClass == null)
                    {
                        currentClass = new XClass(tn.Class);
                        currentNamespace.Classes.Add(currentClass);
                    }
                    pLine = pLine.Substring(pLine.IndexOf("</span>") + 7);
                    tn.Method = pLine.Substring(0, pLine.IndexOf("</b>"));
                    tn.Method = tn.Method.Substring(tn.Method.LastIndexOf(">") + 1);
                    if (tn.Method.Equals(".ctor"))
                    {
                        tn.Method = tn.Class + "()";
                    }
                    //if (MainForm.Exclusions.Contains(tn.Method))
                    {
                        //continue;
                    }
                    XMethod currentMethod = currentClass.Methods.Where(p => p.Name.Equals(tn.Method)).FirstOrDefault();
                    if (currentMethod == null)
                    {
                        currentMethod = new XMethod(tn.Method);
                        currentMethod.Parent = currentClass;
                        currentMethod.Calls = new List<XMethod>();
                        currentClass.Methods.Add(currentMethod);
                    }
                    if (lastMethod != null)
                    {
                        lastMethod.Calls.Add(currentMethod);
                        //if (XMethod.CallSequence.Count<50)
                        {
                            CallSequence.Add(new CallElement(lastMethod, currentMethod));
                        }
                    }
                    lastMethod = currentMethod;
                    pLine = pLine.Substring(pLine.IndexOf("</span>") + 7);
                    string milisecondsString = "";
                    int miliseconds = 0;
                    milisecondsString = pLine.Substring(0, pLine.IndexOf("</span>"));
                    milisecondsString = milisecondsString.Substring(milisecondsString.LastIndexOf(">") + 1);
                    if (int.TryParse(milisecondsString, out miliseconds))
                    {
                        tn.Time = tn.Time += miliseconds;
                        // no error reported. This method might be not accurate
                    }
                    pLine = pLine.Substring(pLine.IndexOf("</span>") + 7);
                    tn.Number = pLine.Substring(0, pLine.IndexOf("</span>"));
                    tn.Number = tn.Number.Substring(tn.Number.LastIndexOf(">") + 1);
                    int Nr = 0; int.TryParse(tn.Number, out Nr);
                    currentMethod.ID = Nr;
                }
                return namespaces;
            }


            public string GetElements(int mode, int tolerance, bool showAboveOnly)
            {
                List<string> linesCsproj = File.ReadAllLines("C:\\Logs\\Identifiers.txt").ToList();
                StringBuilder sb = new StringBuilder();
                string lastMethod = "";
                int lines = 0;
                if (mode == 0)
                {
                    sb.Append(" subgraph cluster_Default { ");
                    sb.Append(" style=filled; ");
                    sb.Append(" color=white; ");
                    sb.Append(" node [style=filled,color=yellow]; ");
                }
                if (mode == 1)
                {
                    sb.Append(" subgraph cluster_Default { ");
                    sb.Append(" style=filled; ");
                    sb.Append(" color=lightgrey; ");
                    sb.Append(" node [style=filled,color=yellow]; ");
                }
                List<HitRelationInfo> hitInfos = new List<HitRelationInfo>();
                
                MethodHitInfo lastHittedInfo = null;
                PrepareIdentifiers();

            if (mode == 0)
                foreach (XNamespace myNamespace in namespaces)
                {
                    sb.Append(" subgraph cluster_N" + namespaces.IndexOf(myNamespace) + " { ");
                    sb.Append(" style=filled; ");
                    sb.Append(" color=lightgray; ");
                    sb.Append(" node [style=filled,color=yellow]; ");
                    sb.Append(" label = \"" + myNamespace.Name + "\"; ");
                    foreach (XClass myClass in myNamespace.Classes)
                    {
                        sb.Append(" subgraph cluster_N" + namespaces.IndexOf(myNamespace) + "C" + myNamespace.Classes.IndexOf(myClass) + " { ");
                        sb.Append(" style=filled; ");
                        sb.Append(" color=turquoise1; ");
                        sb.Append(" node [style=filled,color=yellow]; ");
                        sb.Append(" label = \"Default\"; ");
                        sb.Append(" label = \"" + myClass.Name + "\"; ");

                        foreach (XRef myFile in myClass.Files)
                        {
                            foreach (XMethod myMethod in myFile.Methods)
                            {
                                sb.AppendLine("\t " + myMethod.ID + "[color=yellow; label=\"" +
                                     myMethod.Name + "\"];");
                            }
                        }
                        sb.Append(" } ");
                    }
                    sb.Append(" } ");
                }

                    /*
                    if (lastHittedInfo != null)
                    {
                        HitRelationInfo currentInfo = hitInfos.Where(p => p.Hitted1.Number == lastHittedInfo.Number && p.Hitted2.Number == tn.Number).FirstOrDefault();
                        if (currentInfo == null)
                        {
                            currentInfo = new HitRelationInfo();
                            currentInfo.Hitted1 = lastHittedInfo;
                            currentInfo.Hitted2 = tn;
                            currentInfo.Times = 1;
                            hitInfos.Add(currentInfo);
                        }
                        else
                        {
                            currentInfo.Times++;
                            if (mode != 0)
                            {
                                if (!showAboveOnly)
                                {
                                    if (tolerance < 0 || currentInfo.Times <= tolerance)
                                    {
                                        sb.AppendLine("\t " + currentInfo.Hitted1.Number + "[color=" + (currentInfo.Hitted1.Component == 0 ? "greenyellow" : "yellow") + "; label=\"" + currentInfo.Hitted1.Method + "\"];");
                                        sb.AppendLine("\t " + currentInfo.Hitted2.Number + "[color=" + (currentInfo.Hitted1.Component == 0 ? "greenyellow" : "yellow") + "; label=\"" +
                                                      currentInfo.Hitted2.Method + "\"];");
                                        sb.AppendLine("\t " + currentInfo.Hitted1.Number + " -> " +
                                                      currentInfo.Hitted2.Number +
                                                      ";");
                                    }
                                }
                            }
                        }
                    }
                    lastHittedInfo = tn;

                    if (lines > 10000)
                    {
                        //break;
                    }
                }
                bool isFirstHit = true;
                
                foreach (HitRelationInfo currentInfo in hitInfos)
                {
                    if (mode == 0 || (showAboveOnly && currentInfo.Times >= tolerance))
                    {
                        if (isFirstHit)
                        {
                            sb.AppendLine("\t " + currentInfo.Hitted1.Number + "[color=" + (currentInfo.Hitted1.Component == 0 ? "greenyellow" : "yellow") + "; label=\"" +
                                currentInfo.Hitted1.Method + "\"];");
                            isFirstHit = false;
                        }
                        sb.AppendLine("\t " + currentInfo.Hitted2.Number + "[color=" + (currentInfo.Hitted2.Component == 0 ? "greenyellow" : "yellow") + "; label=\"" + currentInfo.Hitted2.Method + "\"];");
                        sb.AppendLine("\t " + currentInfo.Hitted1.Number + " -> " + currentInfo.Hitted2.Number +
                                      "[ label=\"" +
                                      currentInfo.Times + "\" ];");
                    }
                }*/
                sb.Append(" label = \"Default\"; ");
                sb.Append(" } ");
            /*
                StringBuilder statistics = new StringBuilder();
                hitInfos = hitInfos.OrderBy(o => o.Times).ToList();
                foreach (HitRelationInfo currentInfo in hitInfos)
                {
                    statistics.AppendLine("" + currentInfo.Times + "x " + currentInfo.Hitted1.Class + "." + currentInfo.Hitted1.Method + " -> " + currentInfo.Hitted1.Class + "." + currentInfo.Hitted1.Method + "");
                }
                Statistics = statistics.ToString();
                */
                return sb.ToString();
                
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
            foreach (string line in File.ReadAllLines(@"C:\Logs\Identifiers.txt"))
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

        public void ToGraphvizDiagram(int mode, int tolerance, bool showAboveOnly)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\diagram.gv");
                file.AutoFlush = true;
                switch (mode)
                {
                    case 0:
                        file.WriteLine("strict digraph G { arrowsize=2.0; ratio=fill; node[fontsize=24]; graph [fontsize=24] edge [fontsize=24] node [fontsize=24] ranksep = 1.5 nodesep = .25 edge [style=\"setlinewidth(3)\"]; ");
                        break;
                    case 1:
                        file.WriteLine("digraph G { arrowsize=2.0; ratio=fill; node[fontsize=24]; graph [fontsize=24] edge [fontsize=24] node [fontsize=24] ranksep = 1.5 nodesep = 0.25 edge [style=\"setlinewidth(1)\"]; splines=true; sep=\"+25,25\"; overlap=scalexy; ");
                        break;
                }
                file.WriteLine(GetElements(mode, tolerance, showAboveOnly));
                file.WriteLine("}");
                file.Close();
                //string output = diagram.ExecuteDiagram();
            }

            internal static void CreatePVClassDiagram(List<XNamespace> namespaces)
            {
                List<string> associations = new List<string>();
                StringBuilder associationsRepresentation = new StringBuilder();
                StringBuilder lifelinesRepresentation = new StringBuilder();
                StringBuilder shapesRepresentation = new StringBuilder();
                StringBuilder messagesRepresentation = new StringBuilder();
                StringBuilder connectorsRepresentation = new StringBuilder();

                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "LoggingSystemInjector.Resources.VPOriginal.xml";
                var se = assembly.GetManifestResourceNames();
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string emptyClassDiagram = reader.ReadToEnd();

                    StringBuilder namespacesRepresentation = new StringBuilder();
                    foreach (XNamespace myNamespace in namespaces)
                    {
                        //sb.Append(" subgraph cluster_N" + namespaces.IndexOf(myNamespace) + " { ");
                        //sb.Append(" label = \"" + myNamespace.Name + "\"; ");
                        string packageVP = new VPPackageModel(myNamespace).ToString();
                        StringBuilder classesRepresentation = new StringBuilder();
                        foreach (XClass myClass in myNamespace.Classes)
                        {
                            string classVP = new VPClassModel(myClass).ToString();
                            StringBuilder methodsRepresentation = new StringBuilder();
                            foreach (XMethod myMethod in myClass.Methods)
                            {
                                methodsRepresentation.AppendLine(new VPOperationModel(myMethod).ToString());

                                foreach (XMethod calledMethod in myMethod.Calls)
                                {
                                    if (!(associations.Contains(myMethod.ID + " " + calledMethod.ID) || associations.Contains(calledMethod.ID + " " + myMethod.ID)))
                                    {
                                        associations.Add(myMethod.ID + " " + calledMethod.ID);
                                        associationsRepresentation.AppendLine(new VPAssociationModel(myMethod.Parent.ID, calledMethod.Parent.ID).ToString());
                                    }
                                }
                            }
                            classVP = classVP.Replace("ArgumentsAndOperators", methodsRepresentation.ToString());
                            classesRepresentation.AppendLine(classVP);
                            lifelinesRepresentation.AppendLine(new VPLifelineModel(myClass).ToString());
                            shapesRepresentation.AppendLine(new VPShapeModel(myClass).ToString());
                        }
                        packageVP = packageVP.Replace("MyClasses", classesRepresentation.ToString());
                        namespacesRepresentation.AppendLine(packageVP);
                    }

                    emptyClassDiagram = emptyClassDiagram.Replace("MyPackages", namespacesRepresentation.ToString());
                    emptyClassDiagram = emptyClassDiagram.Replace("MyAssociations", associationsRepresentation.ToString());
                    emptyClassDiagram = emptyClassDiagram.Replace("MyLifelines", lifelinesRepresentation.ToString());
                    emptyClassDiagram = emptyClassDiagram.Replace("MyShapes", shapesRepresentation.ToString());
                    foreach (CallElement callElement in CallSequence)
                    {
                        messagesRepresentation.AppendLine(new VPMessageModel(callElement).ToString());
                        connectorsRepresentation.AppendLine(new VPConnectorModel(callElement).ToString());
                    }
                    emptyClassDiagram = emptyClassDiagram.Replace("MyMessages", messagesRepresentation.ToString());
                    emptyClassDiagram = emptyClassDiagram.Replace("MyConnectors", connectorsRepresentation.ToString());

                    File.WriteAllText("C:\\Log\\VP.xml", emptyClassDiagram);
                }
            }
        }
    }

