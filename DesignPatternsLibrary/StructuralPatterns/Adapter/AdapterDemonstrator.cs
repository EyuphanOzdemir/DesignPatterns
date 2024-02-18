using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Adapter
{
    public class AdapterDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            return new OCRAdapter(new ThirdPartyOCREngine()).OCR(parameters[0]); 
        }
    }
}
