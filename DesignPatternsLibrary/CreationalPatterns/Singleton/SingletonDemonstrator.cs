using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.Singleton
{
    public class SingletonDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var logger = ThreadSafeLogger.Instance;
            logger.Log("cool");
            return "OK";
        }
    }
}
