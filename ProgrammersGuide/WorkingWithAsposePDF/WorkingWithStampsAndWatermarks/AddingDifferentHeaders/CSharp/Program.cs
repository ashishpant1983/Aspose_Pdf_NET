//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace AddingDifferentHeaders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open source document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ "input.pdf");

            //create three stamps
            Aspose.Pdf.TextStamp stamp1 = new Aspose.Pdf.TextStamp("Header 1");
            Aspose.Pdf.TextStamp stamp2 = new Aspose.Pdf.TextStamp("Header 2");
            Aspose.Pdf.TextStamp stamp3 = new Aspose.Pdf.TextStamp("Header 3");

            //set stamp alignment (place stamp on page top, centered horiznotally)
            stamp1.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            stamp1.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // specify the font style as Bold
            stamp1.TextState.FontStyle = FontStyles.Bold;
            // set the text fore ground color information as red
            stamp1.TextState.ForegroundColor = Color.Red;
            // specify the font size as 14
            stamp1.TextState.FontSize = 14;

            // now we need to set the vertical alignment of 2nd stamp object as Top
            stamp2.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            // set Horizontal alignment information for stamp as Center aligned
            stamp2.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // set the zooming factor for stamp object
            stamp2.Zoom = 10;

            // set the formatting of 3rd stamp object
            // specify the Vertical alignment information for stamp object as TOP
            stamp3.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            // Set the Horizontal alignment inforamtion for stamp object as Center aligned
            stamp3.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            // set the rotation angle for stamp object
            stamp3.RotateAngle = 35;
            // set pink as background color for stamp
            stamp3.TextState.BackgroundColor = Color.Pink;
            // change the font face information for stamp to Verdana
            stamp3.TextState.Font = FontRepository.FindFont("Verdana");

            //first stamp is added on first page;
            doc.Pages[1].AddStamp(stamp1);
            //second stamp is added on second page;
            doc.Pages[2].AddStamp(stamp2);
            //third stamp is added on third page.
            doc.Pages[3].AddStamp(stamp3);
            // save the updated document
            doc.Save(dataDir + "multiheader.pdf");
            
            
        }
    }
}