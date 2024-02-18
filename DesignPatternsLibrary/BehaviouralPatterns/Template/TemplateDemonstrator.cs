using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Template
{
    public class TemplateDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            var filePath = parameters[0].ToString();
            var chosenEngine = parameters[1].ToString();
            AbstractOCRClass ocrEngine = chosenEngine=="Engine1" ? new OCREngine1(filePath) : new OCREngine2(filePath);
            return ocrEngine.DoOCR();
        }
    }
}
