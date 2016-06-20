using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsPresenter
{
        /// <summary>
        /// Helper class used for sorting and graph creation
        /// </summary>
        class HitRelationInfo
        {
            public int Times;
            public MethodHitInfo Hitted1;
            public MethodHitInfo Hitted2;
        }
        /// <summary>
        /// Helper class used for sorting and graph creation
        /// </summary>
        class MethodHitInfo
        {
            /// <summary>
            /// Extracted only for debug (allow changes of containing functions at debug time)
            /// </summary>
            /// <param name="times"></param>
            /// <param name="Number"></param>
            /// <returns></returns>
            public static MethodHitInfo GetMethodByNumber(List<MethodHitInfo> times, string Number)
            {
                return times.Where(p => p.Number.Equals(Number)).FirstOrDefault();
            }

            public int Time;
            public int Hits;
            public int Component;
            public string Namespace;
            public string Class;
            public string Method;
            public string Number;
            public decimal Average;
            public decimal Min;
            public decimal Max;

            public int Compare(object x, object y)
            {
                return ((MethodHitInfo)x).Time > ((MethodHitInfo)y).Time ? 0 : 1;
            }
        }
    }
