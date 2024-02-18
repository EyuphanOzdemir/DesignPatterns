using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Decorator
{
    public abstract class AbstractNotifier
    {
        public abstract string Notify(string message);
    }
}
