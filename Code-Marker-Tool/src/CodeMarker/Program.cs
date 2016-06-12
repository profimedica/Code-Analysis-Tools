using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeMarker
{
    class Program
    {
        enum InfosLevel { Time, Extended, Debug, Data }
        /// <summary>
        /// File paths to be considered for processing. If this parameter is not specified, all supported files will be processed.
        /// </summary>
        private static List<string> AcceptedExtensions = new List<string>();
        /// <summary>
        /// Process the files in the given folder recursively
        /// </summary>
        private static bool SearchRecursively = false;
        /// <summary>
        /// In case there is no list of file to process, you have to provide at least a sourcefile path to process or a folder to process. Multiple paths can be provided. You can provide a series of files, folders and lists of paths in the same request.
        /// </summary>
        private static List<string> PathsToProcess = new List<string>();
        /// <summary>
        /// A list of paths to be interpreted as list of filepaths to be processed
        /// </summary>
        private static List<string> InputFilePath = new List<string>();
        /// <summary>
        /// The full path of the file to output the processing result. If not provided, the result will be sent to standard output stream
        /// </summary>
        private static string OutputFilePath { get; set; }
        private static int InfoLevel { get; set; }

        static void Main(string[] args)
        {
            ConsumeArguments(args);
            List<string> allPaths = BuildListOfPaths();
            string result = CollectMarkers(allPaths);
            if (OutputFilePath != null)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (!File.Exists(OutputFilePath))
                {
                    try
                    {
                        File.Create(OutputFilePath).Close();
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: output to file was not successfull. Check if file exist or is in use: " + OutputFilePath);
                    }

                }
                try
                {
                    File.WriteAllText(OutputFilePath, result);
                    stopWatch.Stop();
                    if (InfoLevel > (int)InfosLevel.Time) Console.Write("INFO: " + "Output to file in " + Utils.GetReadableElapsedTime(stopWatch.ElapsedMilliseconds) + "." + '\n');
                }
                catch
                {
                    Console.WriteLine("ERROR: output to file was not successfull. Check if file exist or is in use: " + OutputFilePath);
                }
            }

        }

        private static string CollectMarkers(List<string> allPaths)
        {
            MarkerCollector markerCollector = new MarkerCollector();
            StringBuilder results = new StringBuilder();
            int i = allPaths.Count;
            Stopwatch stopWatch = new Stopwatch();
            if (InfoLevel > (int)InfosLevel.Debug) Console.Write("Files left: ");
            foreach (string path in allPaths)
            {
                stopWatch.Start();
                string markers = markerCollector.CollectMarkers(path);
                stopWatch.Stop();
                results.AppendLine(markers + " " + path);
                i--;
                if (InfoLevel > (int)InfosLevel.Debug)
                {
                    Console.WriteLine(markers);
                }
                else if (InfoLevel > (int)InfosLevel.Debug)
                {
                    Console.SetCursorPosition(12, Console.CursorTop);
                    long estimation = (long)((stopWatch.ElapsedMilliseconds / (decimal)(allPaths.Count - i)) * i);
                    Console.Write(i + " in " + Utils.GetReadableElapsedTime(estimation).Substring(0, Utils.GetReadableElapsedTime(estimation).IndexOf("seconds") + 3));
                }
                else if (InfoLevel > (int)InfosLevel.Debug)
                {
                    if (i % 100 == 0)
                    {
                        Console.SetCursorPosition(12, Console.CursorTop);
                        long estimation = (long)((stopWatch.ElapsedMilliseconds / (decimal)(allPaths.Count - i)) * i);
                        Console.Write(i - (i % 100)+"  ");
                    }
                }
            }
            stopWatch.Stop();
            if (InfoLevel > (int)InfosLevel.Debug) Console.Write("\n");
            if (InfoLevel > (int)InfosLevel.Time) Console.Write("INFO: " + allPaths.Count + " files processed in " + Utils.GetReadableElapsedTime(stopWatch.ElapsedMilliseconds) + "." + '\n');
            if (OutputFilePath != null)
            {

            }
            else if (InfoLevel > (int)InfosLevel.Data)
            {
                Console.Write(results);
            }
            return results.ToString();
        }

        private static List<string> BuildListOfPaths()
        {
            List<string> allPaths = new List<string>();
            if (InfoLevel > (int)InfosLevel.Debug) Console.Write("Files: ");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Add all paths specified in command line arguments if any
            foreach (string path in PathsToProcess)
            {
                if (Directory.Exists(path))
                {
                    allPaths.AddRange(PathCollector.DirSearch(path, AcceptedExtensions, SearchRecursively));
                }
                else
                {
                    if (AcceptedExtensions.Count > 0)
                    {
                        if (path.IndexOf('.') > 0 && path.LastIndexOf('.') + 1 < path.Length - 1 && path.LastIndexOf('.') > path.LastIndexOf('\\') && AcceptedExtensions.Contains(path.Substring(path.LastIndexOf('.') + 1)))
                        {
                            allPaths.Add(path);
                        }
                    }
                    else
                    {
                        allPaths.Add(path);
                    }

                }
            }
            // Add all list of paths specified in input files with option /L if any
            foreach (string path in InputFilePath)
            {
                foreach (string listedPath in File.ReadAllLines(path))
                {
                    if (Directory.Exists(listedPath))
                    {
                        allPaths.AddRange(PathCollector.DirSearch(listedPath, AcceptedExtensions, SearchRecursively));
                    }
                    else
                    {
                        if (AcceptedExtensions.Count > 0)
                        {
                            if (listedPath.IndexOf('.') > 0 && path.LastIndexOf('.') + 1 < path.Length - 1 && listedPath.LastIndexOf('.') > listedPath.LastIndexOf('\\') && AcceptedExtensions.Contains(listedPath.Substring(listedPath.LastIndexOf('.') + 1)))
                            {
                                allPaths.Add(listedPath);
                            }
                        }
                        else
                        {
                            allPaths.Add(listedPath);
                        }

                    }
                }
            }
            stopWatch.Stop();
            if (InfoLevel > (int)InfosLevel.Debug)
            {
                Console.SetCursorPosition(7, Console.CursorTop);
            }
            if (InfoLevel > (int)InfosLevel.Time) Console.Write("INFO: " + "" + allPaths.Count + " files collected in " + Utils.GetReadableElapsedTime(stopWatch.ElapsedMilliseconds) + "." + '\n');
            return allPaths;
        }

        private static void ConsumeArguments(string[] args)
        {
            // Synopsis are needed in case of invalid input
            string showSynopsis = null;

            if (args.Contains("-i") || args.Contains("-I") || args.Contains("/i") || args.Contains("/I"))
            {
                InfoLevel = 1;
                string[] optionForms = new string[] { "-i", "-I", "/i", "/I" };
                string commandLineParameters = "";
                // Search for this option`s argument
                for (int i = 0; i < args.Length; i++)
                {
                    if (optionForms.Contains(args[i]) && i + 1 < args.Length)
                    {
                        if (i + 1 < args.Length && args[i + 1][0] != '/' && args[i + 1][0] != '-')
                        {
                            // Found the argument
                            int infoLevel = 1;
                            if (int.TryParse(args[i + 1], out infoLevel))
                            {
                                InfoLevel = infoLevel;
                            }
                        }
                    }
                    commandLineParameters += " " + args[i];
                }
                if (InfoLevel > (int)InfosLevel.Debug) Console.Write("ARGUMENTS: " + commandLineParameters + '\n');
                if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "User requested for info level = " + InfoLevel + "." + '\n');
            }

            // Show help if requested or no argument was provided
            if (args.Length < 1 || args.Contains("-h") || args.Contains("-H") || args.Contains("/h") || args.Contains("/H"))
            {
                showSynopsis = GetHelp();
                if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "Help was requested or no argument was provided." + '\n');
            }
            else
            {
                // Consume the arguments list
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-t" || args[i] == "-T" || args[i] == "/t" || args[i] == "/T")
                    {
                        // Test this tool!
                        showSynopsis = RunTestCases();
                        if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "Execution of test cases was requested." + '\n');
                    }
                    else
                    if (args[i] == "-r" || args[i] == "-R" || args[i] == "/r" || args[i] == "/R")
                    {
                        // Recursivity option is provided. Use recursivity if appropiate.
                        SearchRecursively = true;
                        if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "Recursivity option is provided. Recursivity will be used when possible." + '\n');
                    }
                    else
                    if (args[i] == "-l" || args[i] == "-L" || args[i] == "/l" || args[i] == "/L")
                    {
                        if (i + 1 < args.Length && args[i + 1][0] != '/' && args[i + 1][0] != '-')
                        {
                            // A file to be interpreted as a list of paths to be processed was provided.
                            InputFilePath.AddRange(args[i + 1].Split(new char[] { ',', ';' }));
                            if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "A file to be interpreted as a list of paths to be processed was provided. If file contain folder paths, parse folders according to recursivity option if any." + '\n');
                            continue;
                        }
                        else
                        {
                            // Missing argument
                            showSynopsis = "ERROR: Missing argument for option /L\nProvide a file containing a list of paths to be processed.\nOtherwise give a file or folder to process, without using the this option.";
                        }
                    }
                    else if (args[i] == "-o" || args[i] == "-O" || args[i] == "/o" || args[i] == "/O")
                    {

                        if (i + 1 < args.Length && args[i + 1][0] != '/' && args[i + 1][0] != '-')
                        {
                            // An output path was provided. Create it if does not exist already. Overrite it if it exist.
                            OutputFilePath = args[i + 1];
                            if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "An output path was provided. This file will be created or overwrited !" + '\n');
                            continue;
                        }
                        else
                        {
                            // Missing argument
                            showSynopsis = "ERROR: Missing argument for option /O\nProvide an output path.\nIf it does not exist, it will be created. If it exists, will be overwrited.\nDrop this option if you want the output to be directed to the console.";
                        }


                    }
                    else if (args[i] == "-e" || args[i] == "-E" || args[i] == "/e" || args[i] == "/E")
                    {

                        if (i + 1 < args.Length && args[i + 1][0] != '/' && args[i + 1][0] != '-')
                        {
                            // An list of wanted extensions was provided. Ignore files with other extensions.
                            AcceptedExtensions.AddRange(args[i + 1].Split(new char[] { ',', ';' }));
                            if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "An list of wanted extensions was provided. Files with other extensions will not be processed." + '\n');
                            continue;
                        }
                        else
                        {
                            // Missing argument
                            showSynopsis = "ERROR: Missing argument for option /O\nProvide an output path.\nIf it does not exist, it will be created. If it exists, will be overwrited.\nDrop this option if you want the output to be directed to the console.";
                        }
                    }
                    else if (args[i] == "-i" || args[i] == "-I" || args[i] == "/i" || args[i] == "/I")
                    {
                        int level = 0;
                        if (i + 1 < args.Length && int.TryParse(args[i + 1], out level))
                        {
                            i++;
                        }
                        // It was interpreted before this for loop.
                    }
                    else if (args[i] == "-p" || args[i] == "-P" || args[i] == "/p" || args[i] == "/P")
                    {
                        // Do nothing :) 
                        // Anyway, the next argument will be added to the list of paths to be processed.
                    }
                    else
                    {
                        // Add this argument as a path to be processed
                        if (InfoLevel > (int)InfosLevel.Debug) Console.Write("INFO: " + "File or directory was provided." + '\n');
                        PathsToProcess.AddRange(args[i].Split(new char[] { ',', ';' }));
                    }
                }
            }

            if (showSynopsis != null)
            {
                Console.Write('\n' + showSynopsis + '\n');
            }
            else
            {
                // Prepare file extensions
            }
        }

        private static string RunTestCases()
        {
            //throw new NotImplementedException();
            return "No test cases yet! :)";
        }

        private static string GetHelp()
        {
            string Info = "\n"
            + "============================\n\n"
            + "CMARK /P | /L  [/E] [/R] [/O] [/I infoLevel]\n\n"
            + "/P \tPath to be processed. File or folder.\n\t You can just give the path to be processed.\n"
            + "/L \tFile contain the list of paths to be processed.\n\t This option can be specified more then once with different parameters.\n"
            + "/E \tFile extensions considered to be processesed.\n\t If not provided, all supported files will be processes\n"
            + "/R \tWorks with /P parameter.\n\t If you need to process also subfolders.\n"
            + "/O \tOutput results into given file. FIle will be created or overwrited!\n"
            + "/O \tOutput info. If no infoLevel in provided, level will be 1.\n"
            + "\n"
            + "EXAMPLES:\n\n"
            + "cmark mySourceFile.java\n"
            + "\tProcess file 'mySourceFile.java'.\n"
            + "cmark mySourcesFolder\n"
            + "\tProcess all files from folder 'mySourcesFolder'. No recursivity!\n"
            + "cmark mySourcesFolder /R\n"
            + "\tProcess all files from folder 'mySourcesFolder' with recursivity.\n"
            + "cmark mySourcesFolder /E php,java,cs /R\n"
            + "\tProcess only files of type php, java and cs from folder 'mySourcesFolder' recursively.\n"
            + "cmark /L inputList.txt /O outputResult.txt\n"
            + "\tProcess files listed in the input file 'inputList.txt' and save the result into file 'outputResult.txt'.\n"
            + "\n"
            + "============================\n\n"
            + "";
            return Info;
        }
    }
}