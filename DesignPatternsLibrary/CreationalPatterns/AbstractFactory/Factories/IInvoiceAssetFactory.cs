using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceEmail;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.Invoice;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceSMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Factories
{
    public interface IInvoiceAssetFactory
    {
        IInvoice CreateInvoice();
        IInvoiceSMS CreateInvoiceSMS();
        IInvoiceEmail CreateInvoiceEmail();
    }
}
