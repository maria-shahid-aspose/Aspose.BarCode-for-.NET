﻿Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode_Image.Utility_Features


    Public Class SaveBarcodeImagesToDifferentFormats
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("barcode-image-format.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            'Save the image to your system and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace