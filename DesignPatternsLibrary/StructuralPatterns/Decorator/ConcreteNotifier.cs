using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Decorator
{
    public class ConcreteNotifier : AbstractNotifier
    {
        public override string Notify(string message)
        {
            return $"{message} + was sent by {this.GetType().Name}";
        }
    }
}
