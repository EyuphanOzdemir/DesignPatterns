using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Observer
{
    internal class ConcreateObserver1 : IObserver
    {
        private List<string> _logList;
        public ConcreateObserver1(List<string> logList)
        {
            _logList = logList;
        }
        public void Update(ISubject subject)
        {
            int state;
            var _subject = subject as Subject;

            if (_subject != null)
            {
                state = _subject.State;

                _logList.Add($"ConcreateObserver1 received an update, the state is {state}");
                _logList.Add(state > 2 ? "ConcreateObserver1 will do something" : "ConcreateObserver1 will NOT do anything");
            }
            else
                _logList.Add("subject cannot be resolved");
        }
    }
}
