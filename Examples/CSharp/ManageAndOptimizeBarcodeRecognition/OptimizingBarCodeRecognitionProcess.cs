﻿using System.IO;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition
{
    class OptimizingBarCodeRecognitionProcess
    {
        public static void Run()
        {
            try
            {                
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition();

                Stopwatch sw = new Stopwatch();
                // Start the stopwatch
                sw.Start();

                // Define the settings to use all of the processor cores, if not then how many to use.
                BarCodeReader.ProcessorSettings.UseAllCores = false;
                BarCodeReader.ProcessorSettings.UseOnlyThisCoresCount = 4;

                // perform the BarCode recognition task Initialize the BarCodeReader object

                using (BarCodeReader reader = new BarCodeReader(dataDir + "code39.png", DecodeType.Code128))
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(" Code Text: " + reader.GetCodeText() + " Type: " + reader.GetCodeType());
                    }
                }

                // Stop the stopwatch
                sw.Stop();

                // Write the Elapsed time to console
                Console.WriteLine("Elapsed: " + sw.Elapsed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}

