using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.Invoice;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceEmail;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceSMS;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Factories
{
    public class VictoriaInvoiceAssetFactory : IInvoiceAssetFactory
    {
        public IInvoice CreateInvoice()
        {
            return new VictoriaInvoice();
        }

        public IInvoiceEmail CreateInvoiceEmail()
        {
            return new VictoriaInvoiceEmail();
        }

        public IInvoiceSMS CreateInvoiceSMS()
        {
            return new VictoriaInvoiceSMS();
        }
    }
}
