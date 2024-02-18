using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Products
{
    //Interface that will be implemented concerete invoice classes
    public interface IInvoice
    {
        string InvoiceJson { get; init; }
        string Print();
    }
}
