using DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory
{
    public class AbstractFactoryDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            string result = "";
            var district = parameters[0];
            IInvoiceAssetFactory invoiceAssetFactory = district == "Victoria" ? new VictoriaInvoiceAssetFactory() : new NonVictoriaInvoiceAssetFactory();
            var invoice = invoiceAssetFactory.CreateInvoice();
            result = invoice.Print();
            var invoiceSMS = invoiceAssetFactory.CreateInvoiceSMS();
            result += Environment.NewLine + invoiceSMS.SendSMS();
            var invoiceEmail = invoiceAssetFactory.CreateInvoiceEmail();
            result += Environment.NewLine + invoiceEmail.SendEmail();
            return result;
        }
    }
}
