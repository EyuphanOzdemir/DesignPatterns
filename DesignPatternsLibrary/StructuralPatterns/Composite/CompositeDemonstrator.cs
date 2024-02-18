using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Composite
{
    public class CompositeDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var backendDevelopment = new Course(100); //registration + service fee for this big course is 100 NZD!
            var azureDevelopment = new Course(50);
            backendDevelopment.Add(azureDevelopment);

            var azureFunctionsSubject = new CourseSubject(25);
            var azureServiceBusSubject = new CourseSubject(15);
            azureDevelopment.Add(azureFunctionsSubject);
            azureDevelopment.Add(azureServiceBusSubject);

            var softwareDesigns = new Course(60);
            var solid = new CourseSubject(15);
            var designPatterns = new CourseSubject(20);
            softwareDesigns.Add(solid);
            softwareDesigns.Add(designPatterns);
            backendDevelopment.Add(softwareDesigns);


            return backendDevelopment.GetPrice().ToString();
        }
    }
}
