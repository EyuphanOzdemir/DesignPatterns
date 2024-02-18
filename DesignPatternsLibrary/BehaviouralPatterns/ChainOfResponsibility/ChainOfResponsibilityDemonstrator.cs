using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            IManager techLead = new TechLeadManager();
            IManager teamLead = new TeamLeaderManager();
            IManager dm = new DeliveryManager();

            techLead.SetNext(teamLead).SetNext(dm);

            var chosenManagerToAsk = parameters[0];
            var leaveType = parameters[1];

            var managerToAsk = chosenManagerToAsk == "techlead" ? techLead : (chosenManagerToAsk == "teamlead" ? teamLead : dm);

            return managerToAsk.HandleRequest(leaveType).ToString()!;
        }
    }
}
