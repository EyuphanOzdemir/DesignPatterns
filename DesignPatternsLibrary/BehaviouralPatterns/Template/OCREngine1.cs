using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Template
{
    public class OCREngine1 : AbstractOCRClass
    {
        public OCREngine1(string filePath) : base(filePath)
        {

        }
        public override string OCR()
        {
            return $"OCREngine1 did OCR on {FilePath}!";
        }
    }
}
