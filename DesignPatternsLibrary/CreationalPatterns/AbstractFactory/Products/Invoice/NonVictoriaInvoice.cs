namespace DesignPatternsLibrary.CreationalPatterns.AbstractFactory.Products.Invoice
{
    //Another concrete Invoice class
    public class NonVictoriaInvoice : IInvoice
    {
        public string Print()
        {
            var message = $"{GetType().Name} invoice will be printed...";
            Console.WriteLine(message);
            return message;
        }
    }
}
