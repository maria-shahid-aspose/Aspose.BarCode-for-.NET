﻿
using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.Programming.BarCode
{
    class CreateQRbarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "QR.jpg";

            Aspose.BarCode.BarCodeBuilder b;
            b = new Aspose.BarCode.BarCodeBuilder();
            b.SymbologyType = Aspose.BarCode.Symbology.QR;
            b.CodeText = "1234567890";
            b.Save(dst, BarCodeImageFormat.Bmp);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
