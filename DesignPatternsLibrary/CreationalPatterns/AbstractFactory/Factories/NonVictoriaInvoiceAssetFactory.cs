using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.Invoice;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceEmail;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceSMS;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Factories
{
    internal class NonVictoriaInvoiceAssetFactory : IInvoiceAssetFactory
    {
        public IInvoice CreateInvoice()
        {
            return new NonVictoriaInvoice();
        }

        public IInvoiceEmail CreateInvoiceEmail()
        {
            return new NonVictoriaInvoiceEmail();
        }

        public IInvoiceSMS CreateInvoiceSMS()
        {
            return new VictoriaInvoiceSMS();  
        }
    }
}
