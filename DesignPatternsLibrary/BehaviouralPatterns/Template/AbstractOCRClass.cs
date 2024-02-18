using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.Template
{
    public abstract class AbstractOCRClass(string filePath)
    {
        private readonly string filePath="";
        public string FilePath { get; set; } = filePath ?? "";

        private string ocrResult="";
        private void TransformTheImage()
        {
            //do something about the filePath
        }

        protected virtual void BeforeOCRHook()
        {

        }

        public abstract string OCR();

        protected virtual void AfterOCRHook()
        {

        }


        private void SaveOCRResult()
        {
            //do something about ocrResult
        }

        public string DoOCR()
        { 
            TransformTheImage();
            BeforeOCRHook();
            ocrResult = OCR();
            SaveOCRResult();
            AfterOCRHook(); 
            return ocrResult;
        }
    }
}
