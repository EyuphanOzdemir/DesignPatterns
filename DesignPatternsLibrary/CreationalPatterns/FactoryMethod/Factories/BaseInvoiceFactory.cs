using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Factories
{
    //Abstract base invoice creator. Concrete creator classes, which will create concrete invoices, will inherit from this.
    public abstract class BaseInvoiceFactory
    {
        //the method that will be implemented by concrete creator classes
        public abstract IInvoice CreateInvoice();

        //This class can do some common things
        public string RetrieveDataForInvoicePrinting()
        {
            Console.WriteLine($"RetrieveDataForInvoicePrinting for {GetType().Name}");
            return "invoice json";
        }

    }
}
