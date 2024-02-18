using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Decorator
{
    public class FacebookDecoratorNotifier(AbstractNotifier notifier) : AbstractDecorator(notifier)
    {
        public override string Notify(string message)
        {
            return $"Facebook notifier at work. {base.Notify(message)}";
        }
    }
}
