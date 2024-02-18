using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceSMS
{
    public interface IInvoiceSMS
    {
        string SendSMS();
    }
}
