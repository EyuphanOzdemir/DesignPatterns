using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceSMS
{
    public class NonVictoriaInvoiceSMS : IInvoiceSMS
    {
        public string SendSMS()
        {
            var message = $"{GetType().Name} invoice will be SMSed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
