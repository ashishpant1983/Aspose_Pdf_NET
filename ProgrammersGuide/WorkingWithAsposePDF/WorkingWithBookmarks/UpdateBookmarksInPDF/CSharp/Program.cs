//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace UpdateBookmarksInPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //get a bookmark object
            OutlineItemCollection pdfOutline = pdfDocument.Outlines[1];
            pdfOutline.Title = "Updated Outline";
            pdfOutline.Italic = true;
            pdfOutline.Bold = true;
                        
            //save output
            pdfDocument.Save(dataDir + "output.pdf");

        }
    }
}