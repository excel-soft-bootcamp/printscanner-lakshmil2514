using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    
    public class PrintScanner : IPrinter, IScanner
    {

        IPrinter _printerReference;
        IScanner _scannerReference;

        public void SetPrinter(IPrinter printerRef)
        {
            this._printerReference = printerRef;
        }
        public void SetScanner(IScanner scanRef)
        {

            this._scannerReference = scanRef;
        }
        public void Print()
        {
           
            this._printerReference.Print();
        }
        public void Scan()
        {
            
            this._scannerReference.Scan();
        }
    }
}

