'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace EncryptPDFFile
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim document As New Document(dataDir & "input.pdf")
			'encrypt PDF
			document.Encrypt("user", "owner", 0, CryptoAlgorithm.RC4x128)
			'save updated PDF
			document.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace