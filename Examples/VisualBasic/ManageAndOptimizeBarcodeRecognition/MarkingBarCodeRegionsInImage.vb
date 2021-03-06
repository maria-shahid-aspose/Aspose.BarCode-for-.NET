﻿Imports System.IO
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class MarkingBarCodeRegionsInImage
        Public Shared Sub Run()
            
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Create an instance of BarCodeReader and set image and symbology type to recognize
            Dim barCodeReader As New BarCodeReader(dataDir & Convert.ToString("code39.png"), DecodeType.Code39Standard)

            Dim counter As Integer = 0
            ' Read all the barcodes from the images
            While barCodeReader.Read()
                ' Display the symbology type
                Console.WriteLine("BarCode Type: " & barCodeReader.GetCodeType().ToString())
                ' Display the codetext
                Console.WriteLine("BarCode CodeText: " & barCodeReader.GetCodeText().ToString())
                ' Get the barcode region

                Dim region As BarCodeRegion = barCodeReader.GetRegion()
                If region IsNot Nothing Then
                    ' Initialize an object of type Image to get the Graphics object
                    Dim image__1 As Image = Image.FromFile(dataDir & Convert.ToString("code39.png"))

                    ' Initialize graphics object from the image
                    Dim graphics__2 As Graphics = Graphics.FromImage(image__1)

                    ' Draw the barcode edges
                    region.DrawBarCodeEdges(graphics__2, New Pen(Color.Red, 1.0F))

                    ' Save the image
                    image__1.Save(dataDir & String.Format("edge_{0}.png", System.Math.Max(System.Threading.Interlocked.Increment(counter), counter - 1)))

                    ' Fill the barcode area with some color
                    region.FillBarCodeRegion(graphics__2, Brushes.Green)
                    image__1.Save(dataDir & String.Format("fill_{0}.png", System.Math.Max(System.Threading.Interlocked.Increment(counter), counter - 1)))
                End If
            End While
            barCodeReader.Close()
        End Sub
    End Class
End Namespace