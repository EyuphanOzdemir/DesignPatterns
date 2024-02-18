using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Facade
{
    public class Facade
    {
        //Facades can be singleton because only 1 instance of them is enough. But let's not do that here.
        protected ComplexSubSystem1 _subsystem1;
        protected ComplexSubSystem2 _subsystem2;

        public Facade(ComplexSubSystem1 subsystem1, ComplexSubSystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public int Calculate()
        {
            var result = _subsystem1.Calculate();
            result += _subsystem2.Calculate();
            return result;
        }
    }
}
