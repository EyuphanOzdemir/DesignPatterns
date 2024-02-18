using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsLibrary.CreationalPatterns.FactoryMethod.Factories;

namespace DesignPatternsLibrary.CreationalPatterns.FactoryMethod
{
    public class FactoryMethodDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var district = parameters[0];
            BaseInvoiceFactory invoiceCreator = district
            switch
            {
                "Victoria" => new VictoriaInvoiceFactory(),
                _ => new NonVictoriaInvoiceFactory()
            };
            var invoice = invoiceCreator.CreateInvoice();
            return invoice.Print();
        }
    }
}
