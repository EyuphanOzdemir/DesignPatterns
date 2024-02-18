using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility
{
    public interface IManager
    {
        IManager SetNext(IManager nextManager);
        object HandleRequest(object request);
    }
}
