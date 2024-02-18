using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class OCRAdapter : IOCR
    {
        private ThirdPartyOCREngine _ocrEngine; 
        public OCRAdapter(ThirdPartyOCREngine ocrEngine)
        {
            _ocrEngine = ocrEngine;
        }
        public string OCR(string filePath)
        {
            return _ocrEngine.RunOCR(Path.GetDirectoryName(filePath)!, Path.GetFileName(filePath));
        }
    }
}
