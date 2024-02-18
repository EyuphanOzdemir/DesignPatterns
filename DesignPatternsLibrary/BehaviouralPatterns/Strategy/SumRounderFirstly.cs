using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Strategy
{
    public class SumRounderFirstly : ISumRounder
    {
        public decimal Round(List<decimal> numbers)
        {
            throw new NotImplementedException();
        }

        public decimal SumRound(List<decimal> numbers)
        {
            return numbers.Sum(n=>Math.Round(n,2));
        }
    }
}
