using DesignPatternsLibrary;
using DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility;
using DesignPatternsLibrary.BehaviouralPatterns.Observer;
using DesignPatternsLibrary.BehaviouralPatterns.Strategy;
using DesignPatternsLibrary.BehaviouralPatterns.Template;
using DesignPatternsLibrary.CreationalPatterns.AbstractFactory;
using DesignPatternsLibrary.CreationalPatterns.Builder;
using DesignPatternsLibrary.CreationalPatterns.FactoryMethod;
using DesignPatternsLibrary.CreationalPatterns.Singleton;
using DesignPatternsLibrary.StructuralPatterns.Adapter;
using DesignPatternsLibrary.StructuralPatterns.Composite;
using DesignPatternsLibrary.StructuralPatterns.Decorator;
using DesignPatternsLibrary.StructuralPatterns.Facade;
using DesignPatternsLibrary.StructuralPatterns.Proxy;
using System.Data.SqlTypes;
namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestFactoryPattern()
        {
            var pd = new FactoryMethodDemonstrator();
            Assert.True(pd.Demonstrate("Victoria") == "VictoriaInvoice invoice will be printed...");
        }

        [Fact]
        public void TestAbstractFactoryPattern()
        {
            var pd = new AbstractFactoryDemonstrator();
            Assert.Contains("VictoriaInvoiceSMS invoice will be SMSed...", pd.Demonstrate("Victoria"));
        }

        [Fact]
        public void TestBuilderPattern()
        {
            var pd = new BuilderDemonstrator();
            Assert.Contains("Concrete", pd.Demonstrate("Rich"));
        }

        [Fact]
        public void TestSingleton()
        {
            var pd = new SingletonDemonstrator();
            Assert.True("OK" == pd.Demonstrate());
        }

        [Fact]
        public void TestAdapter()
        {
            var pd = new AdapterDemonstrator();
            var filePath = "C:\\ocrtest.jpg";
            var result = pd.Demonstrate(filePath);
            Assert.Contains("3rd party OCR Engine", result);
            Assert.Contains("ocrtest.jpg", result);
        }

        [Fact]
        public void TestComposite()
        {
            var pd = new CompositeDemonstrator();
            Assert.True("285" == pd.Demonstrate());
        }

        [Fact]
        public void TestDecorator()
        {
            var pd = new DecoratorDemonstrator();
            var result = pd.Demonstrate();
            Assert.Contains("SMS notifier", result);
            Assert.Contains("Facebook notifier", result);
        }

        [Fact]
        public void TestFacade()
        {
            var pd = new FacadeDemonstrator();
            var result = pd.Demonstrate();
            Assert.Equal(36, Convert.ToInt32(result));
        }

        [Fact]
        public void TestProxy()
        {
            var pd = new ProxyDemonstrator();
            var result = pd.Demonstrate("salma");
            Assert.Contains("Proxy", result);
            Assert.Contains("refused", result);
        }

        [Fact]
        public void TestChainOfResponsibility()
        {
            var pd = new ChainOfResponsibilityDemonstrator();
            Assert.Equal("TechLead confirmed SickLeave", pd.Demonstrate("techlead", "SickLeave"));
            Assert.Equal("TechLead confirmed AnnualLeave", pd.Demonstrate("techlead", "AnnualLeave"));
            Assert.Equal("TeamLead confirmed SickLeave", pd.Demonstrate("teamlead", "SickLeave"));
            Assert.Equal("TeamLead rejected AnnualLeave", pd.Demonstrate("teamlead", "AnnualLeave"));
            Assert.Equal("DM rejected SickLeave", pd.Demonstrate("dm", "SickLeave"));
            Assert.Equal("DM rejected AnnualLeave", pd.Demonstrate("dm", "AnnualLeave"));
        }

        [Fact]
        public void TestStrategy()
        {
            var pd = new StrategyDemonstrator();
            Assert.Equal("44.50-44.51", pd.Demonstrate());
        }

        [Fact]
        public void TestObserver()
        {
            var pd = new ObserverDemonstrator();
            var result = pd.Demonstrate("3");
            Assert.Contains("ConcreateObserver1 will do something", result);
            Assert.DoesNotContain("ConcreateObserver2 will do something", result);
        }

        [Fact]
        public void TestTemplate()
        {
            var pd = new TemplateDemonstrator();
            var filePath = "C:\\test.jpeg";
            var result = pd.Demonstrate(filePath, "Engine1");
            Assert.Contains($"OCREngine1 did OCR on {filePath}", result);
            result = pd.Demonstrate(filePath, "Engine2");
            Assert.Contains($"OCREngine2 did OCR on {filePath}", result);
        }

    }
}