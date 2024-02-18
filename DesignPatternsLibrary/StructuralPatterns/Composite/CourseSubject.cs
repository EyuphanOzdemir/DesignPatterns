using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Composite
{
    //leaf
    public class CourseSubject(int price) : Component
    {
        public  int SubjectPrice => price;
        public override int GetPrice()
        {
            return SubjectPrice; //each subject is 10 NZD 
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
