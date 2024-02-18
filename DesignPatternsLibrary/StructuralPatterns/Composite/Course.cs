using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Composite
{
    public class Course(int coursePrice) : Component
    {
        public int CoursePrice => coursePrice;
        public override int GetPrice()
        {
            int result = CoursePrice;
            foreach (Component component in this._children)
            {
                result += component.GetPrice();
            }

            return result;
        }
    }
}
