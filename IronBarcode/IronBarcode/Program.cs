using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;

namespace IronBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var barcode = BarcodeWriter.CreateBarcode("This is my first barcode by Iron Barcode", BarcodeEncoding.Code128);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SaveAsPng("Barcode.png");
        }
    }
}
