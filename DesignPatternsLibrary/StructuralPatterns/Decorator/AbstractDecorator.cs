using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Decorator
{
    public abstract class AbstractDecorator(AbstractNotifier notifier) : AbstractNotifier
    {
        protected AbstractNotifier _component = notifier;


        // The Decorator delegates all work to the wrapped component.
        public override string Notify(string message)
        {
            if (this._component != null)
            {
                return this._component.Notify(message);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
