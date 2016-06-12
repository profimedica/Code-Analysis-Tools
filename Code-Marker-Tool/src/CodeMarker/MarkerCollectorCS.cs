using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMarker
{
    public class MarkerCollector : IMarkerCollector
    {
        /// <summary>
        /// Return markers for given filePath
        /// </summary>
        public string CollectMarkers(string path)
        {
            string fileContent = File.ReadAllText(path);
            bool isInString = false;
            int lastOffset = 0;
            bool isInComment = false;
            bool isEscapeNeutralized = false;
            bool isEscapeNeutralizedAndEscaped = false; // @" "" "
            bool isNotEscapeNeutralizedAndEscaped = false; // " \\\" "
            bool isMultilineComment = false;
            int blockLevel = 0;
            bool markBeginingOfText = true;
            int namespaceLevel = 0;
            int classLevel = 0;
            string markers = "";
            int methodLevel = 0;
            for (int i = 0; i < fileContent.Length; i++)
            {
                if (!isInComment && !isInString)
                {
                    if (fileContent[i] == '/' && i < fileContent.Length - 1 && fileContent[i + 1] == '/')
                    {
                        isInComment = true;
                        lastOffset = i;
                        isMultilineComment = false;
                        continue;
                    }
                    if (fileContent[i] == '/' && i < fileContent.Length - 1 && fileContent[i + 1] == '*')
                    {
                        isInComment = true;
                        lastOffset = i;
                        isMultilineComment = true;
                        continue;
                    }

                    if (markBeginingOfText && fileContent[i] != ' ' && markBeginingOfText && fileContent[i] != '\t' && markBeginingOfText && fileContent[i] != '\n' && markBeginingOfText && fileContent[i] != '\r' && /* exclude the possibility to be in a character string */ ((i - 1 >= 0 && fileContent[i - 1] != '\'') || (i + 1 < fileContent.Length - 1) && fileContent[i + 1] != '\''))
                    {
                        markers += i + "-~/";
                        markBeginingOfText = false;
                    }

                    if (fileContent[i] == '{' && /* exclude the possibility to be in a character string */ ((i - 1 >= 0 && fileContent[i - 1] != '\'') || (i + 1 < fileContent.Length - 1) && fileContent[i + 1] != '\''))
                    {
                        blockLevel++;
                        markBeginingOfText = true;
                        markers += i + "-{/";
                    }

                    if (fileContent[i] == '}' && /* exclude the possibility to be in a character string */ ((i - 1 >= 0 && fileContent[i - 1] != '\'') || (i + 1 < fileContent.Length - 1) && fileContent[i + 1] != '\''))
                    {
                        blockLevel--;
                        markers += i + "-}/";
                        markBeginingOfText = true;
                    }

                    if (fileContent[i] == ';' && /* exclude the possibility to be in a character string */ ((i - 1 >= 0 && fileContent[i - 1] != '\'') || (i + 1 < fileContent.Length - 1) && fileContent[i + 1] != '\''))
                    {
                        markers += i + "-;/";
                        markBeginingOfText = true;
                    }

                    if (fileContent[i] == '"' && /* exclude the possibility to be in a character string */ ((i - 1 >= 0 && fileContent[i - 1] != '\'') || (i + 1 < fileContent.Length - 1) && fileContent[i + 1] != '\''))
                    {
                        lastOffset = i + 1;
                        isInString = true;
                        isEscapeNeutralized = (i - 1 >= 0 && fileContent[i - 1] == '@');
                        continue;
                    }
                }
                if (isInString)
                {
                    if (fileContent[i] == '"' && (isEscapeNeutralized || !isNotEscapeNeutralizedAndEscaped))
                    {
                        if (isEscapeNeutralized)
                        {
                            if (isEscapeNeutralizedAndEscaped)
                            {
                                isEscapeNeutralizedAndEscaped = false;
                                continue;
                            }
                            else
                            {
                                if (i + 1 <= fileContent.Length - 1 && fileContent[i + 1] == '"')
                                {
                                    isEscapeNeutralizedAndEscaped = true;
                                    continue;
                                }
                            }
                        }

                        isInString = false;
                        continue;
                    }
                    isNotEscapeNeutralizedAndEscaped = (!isNotEscapeNeutralizedAndEscaped) && fileContent[i] == '\\';
                }
                if (isInComment)
                {
                    if (isMultilineComment)
                    {
                        if (fileContent[i] == '*' && i < fileContent.Length - 1 && fileContent[i + 1] == '/')
                        {
                            isInComment = false;
                            continue;
                        }
                    }
                    else // if (!isMultilineComment)
                    {
                        if (fileContent[i] == '\n')
                        {
                            isInComment = false;
                            continue;
                        }
                    }
                }
            }
            return markers;
        }
    }
}
