using CodeCollector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsPresenter
{
    public class CallElement
    {
        public XMethod FromMethod;
        public XMethod ToMethod;
        public CallElement(XMethod fromMethod, XMethod toMethod)
        {
            FromMethod = fromMethod;
            ToMethod = toMethod;
        }
    }
}
