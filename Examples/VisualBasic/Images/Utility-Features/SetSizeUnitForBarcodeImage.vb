﻿'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode_Image.Utility_Features

    Public Class SetSizeUnitForBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("barcode-size-unit.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            'Set the bar height to 3 points
            bb.BarHeight = 3.0F

            'Set the measuring unit of barcode to point
            bb.GraphicsUnit = System.Drawing.GraphicsUnit.Point

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace