using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceEmail
{
    public class NonVictoriaInvoiceEmail : IInvoiceEmail
    {
        public string SendEmail()
        {
            var message = $"{GetType().Name} invoice will be emailed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
