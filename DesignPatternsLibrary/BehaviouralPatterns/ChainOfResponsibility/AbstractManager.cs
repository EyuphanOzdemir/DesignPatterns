using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility
{
    public class AbstractManager : IManager
    {
        private IManager _nextManager = null!;
        public IManager SetNext(IManager nextManager)
        {
            _nextManager = nextManager;
            return _nextManager;
        }
        public virtual object HandleRequest(object request)
        {
            if (this._nextManager != null)
            {
                return this._nextManager.HandleRequest(request);
            }
            else
            {
                //if there is no manager to ask, reject the leave request
                return "rejected";
            }
        }
    }
}
