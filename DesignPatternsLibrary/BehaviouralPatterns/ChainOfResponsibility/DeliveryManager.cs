using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility
{
    public class DeliveryManager:AbstractManager
    {
        public override object HandleRequest(object request)
        {
            //dm confirms rejects all sick leaves and annual leave if the decision is left to her
            var leaveType = (string)request;

            if (leaveType == "SickLeave" || leaveType == "AnnualLeave")
            {
                return $"DM rejected {leaveType}";
            }
            else
            {
                return base.HandleRequest(request);
            }
        }
    }
}
