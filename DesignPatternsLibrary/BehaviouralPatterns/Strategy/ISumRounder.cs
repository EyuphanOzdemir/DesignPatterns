using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Strategy
{
    public interface ISumRounder
    {
        decimal SumRound(List<decimal> numbers);
    }
}
