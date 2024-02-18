using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.Invoice
{

    //A concrete Invoice class
    public class VictoriaInvoice : IInvoice
    {
        public string Print()
        {
            var message = $"{GetType().Name} invoice will be printed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
