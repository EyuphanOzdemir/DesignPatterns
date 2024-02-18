using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Strategy
{
    public class Context
    {
        private ISumRounder _sumRounder;

        public Context(ISumRounder rounder)
        {
            this._sumRounder = rounder;
        }

        public void SetStrategy(ISumRounder rounder)
        {
            this._sumRounder = rounder;
        }

        public decimal DoBusiness()
        {
            Console.WriteLine("Context will round something but it does not how");
            return _sumRounder.SumRound(new List<decimal> { 4.2749m, 5.1189m, 7.8993m, 4.2779m, 5.1119m, 17.82293m });
        }
    }
}
