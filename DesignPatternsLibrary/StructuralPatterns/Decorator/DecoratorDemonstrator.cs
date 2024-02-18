using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Decorator
{
    public class DecoratorDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var basicNotifier = new ConcreteNotifier();
            ConcreteDecoratorSMS smsNotifier = new ConcreteDecoratorSMS(basicNotifier);
            FacebookDecoratorNotifier facebookNotifier = new FacebookDecoratorNotifier(smsNotifier);
            
            var result = facebookNotifier.Notify("'Hello'");
            Console.WriteLine(result);
            return result;
        }
    }
}
