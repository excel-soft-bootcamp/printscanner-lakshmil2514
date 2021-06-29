using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    
        public class PrintScanner
        {
            IPrinter _printer;
            IScanner _scanner;

            public PrintScanner(IPrinter printer, IScanner scanner)
            {
                this._printer = printer;
                this._scanner = scanner;
            }

            public void PrintScan()
            {
                _printer.Print();
                _scanner.Scan();
            }

        }
    }

