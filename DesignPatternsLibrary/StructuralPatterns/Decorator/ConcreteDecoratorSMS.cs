using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Decorator
{
    public class ConcreteDecoratorSMS(AbstractNotifier notifier) : AbstractDecorator(notifier)
    {
        public override string Notify(string message)
        {
            return $"SMS notifier at work. {base.Notify(message)}";
        }
    }
}
