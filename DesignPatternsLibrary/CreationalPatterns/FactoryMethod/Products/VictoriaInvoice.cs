using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Products
{

    //A concrete Invoice class
    public class VictoriaInvoice(string invoiceJson) : IInvoice
    {
        public string InvoiceJson { get; init; } = invoiceJson; //primary constructor

        public string Print()
        {
            var message = $"{GetType().Name} invoice will be printed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
