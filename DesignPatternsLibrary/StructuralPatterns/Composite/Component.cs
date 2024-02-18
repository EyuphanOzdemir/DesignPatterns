using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Composite
{
    public abstract class Component
    {
        protected List<Component> _children = [];
        public Component() { }

        // The base Component may implement some default behavior or leave it to
        // concrete classes (by declaring the method containing the behavior as
        // "abstract").

        

        public abstract int GetPrice();

        // In some cases, it would be beneficial to define the child-management
        // operations right in the base Component class. This way, you won't
        // need to expose any concrete component classes to the client code,
        // even during the object tree assembly. The downside is that these
        // methods will be empty for the leaf-level components.
        public virtual void Add(Component component)
        {
            _children.Add(component);
        }

        public virtual void Remove(Component component)
        {
            _children.Remove(component);
        }

        // You can provide a method that lets the client code figure out whether
        // a component can bear children.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
