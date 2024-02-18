namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.InvoiceSMS
{
    public class VictoriaInvoiceSMS : IInvoiceSMS
    {
        public string SendSMS()
        {
            var message = $"{GetType().Name} invoice will be SMSed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
