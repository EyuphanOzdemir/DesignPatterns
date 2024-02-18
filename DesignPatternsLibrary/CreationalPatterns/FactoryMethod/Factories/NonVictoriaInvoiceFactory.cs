using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Factories
{
    public class NonVictoriaInvoiceFactory : BaseInvoiceFactory
    {
        public override IInvoice CreateInvoice()
        {
            return new VictoriaInvoice(RetrieveDataForInvoicePrinting());
        }
    }
}
