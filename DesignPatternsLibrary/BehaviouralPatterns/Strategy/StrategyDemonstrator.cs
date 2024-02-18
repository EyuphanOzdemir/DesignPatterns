using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Strategy
{
    public class StrategyDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var context = new Context(new SumRounderFirstly());
            var first = context.DoBusiness().ToString();
            context.SetStrategy(new SumRounderAtTheEnd());
            var end = context.DoBusiness().ToString();
            return String.Join("-", first, end);
        }
    }
}
