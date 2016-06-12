using System;
using System.Collections.Generic;
using System.IO;

namespace CodeMarker
{
    class PathCollector
    {
        public static List<string> DirSearch(string sDir, List<string> acceptedExtensions, bool searchRecursively)
        {
            List<string> paths = new List<string>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    if (acceptedExtensions.Count > 0)
                    {
                        // Accept: sr.c\\t.est.cs
                        // Accept: src\\t.est.cs
                        // Accept: t.est.cs
                        if (f.IndexOf('.') > 0 && f.LastIndexOf('.') + 1 < f.Length - 1 && f.LastIndexOf('.') > f.LastIndexOf('\\') && acceptedExtensions.Contains(f.Substring(f.LastIndexOf('.')+1)))
                        {
                            paths.Add(f);
                        }
                    }
                    else
                    {
                        paths.Add(f);
                    }
                }
                if(searchRecursively)
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    paths.AddRange(DirSearch(d, acceptedExtensions, searchRecursively));
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return paths;
        }
    }
}