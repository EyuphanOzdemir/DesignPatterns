using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Template
{
    public class OCREngine2 : AbstractOCRClass
    {
        public OCREngine2(string filePath) : base(filePath)
        {

        }
        public override string OCR()
        {
            return $"OCREngine2 did OCR on {FilePath}!";
        }
    }
}
