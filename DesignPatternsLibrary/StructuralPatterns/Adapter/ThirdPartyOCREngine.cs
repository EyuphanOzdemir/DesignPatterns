using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Adapter
{
    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.    
    public class ThirdPartyOCREngine
    {
        public string RunOCR(string fileDirectory, string fileName)
        {
            return $"OCR result from 3rd party OCR Engine on {fileName}";
        }
    }
}
