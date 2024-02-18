using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Products
{
    //Another concrete Invoice class
    public class NonVictoriaInvoice : IInvoice
    {
        public string InvoiceJson { get; init; }
        public NonVictoriaInvoice(string invoiceJson)
        {
            InvoiceJson = invoiceJson;
        }

        public string Print()
        {
            var message = $"{GetType().Name} invoice will be printed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
