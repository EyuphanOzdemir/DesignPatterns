using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Facade
{
    public class FacadeDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            ComplexSubSystem1 s1 = new ComplexSubSystem1();
            ComplexSubSystem2 s2 = new ComplexSubSystem2();
            return new Facade(s1, s2).Calculate().ToString();
        }
    }
}
