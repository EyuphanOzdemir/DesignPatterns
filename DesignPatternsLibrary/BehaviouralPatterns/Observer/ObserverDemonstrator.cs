using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Observer
{
    public class ObserverDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var state =int.Parse(parameters[0]);
            var subject = new Subject();
            var logList = new List<string>();
            var observer1 = new ConcreateObserver1(logList);
            var observer2 = new ConcreateObserver1(logList);
            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.State = state;
            return String.Join(Environment.NewLine, logList);
        }
    }
}
