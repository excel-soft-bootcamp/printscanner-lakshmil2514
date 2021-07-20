using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    
        public class ScanManager 
        {
            public void ScanDocument(IScanner scaner)
            {
            scaner.Scan();
        }
        }
}
