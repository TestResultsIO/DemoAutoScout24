using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TC007_Rev1
{
    public class PdfValidationHelper
    {
        public struct ExpectedPDFContent
        {
            public int Page { get; private set; } //start with 1 not with 0
            public int Line { get; private set; } //start with 1 not with 0
            public string ExpectedText { get; private set; }

            public ExpectedPDFContent(int page, int line, string expectedText)
            {
                Page = page;
                Line = line;
                ExpectedText = expectedText;
            }

        }

        private struct PDFPage
        {
            public readonly string[] Lines { get; }

            public PDFPage(string[] lines)
            {
                Lines = lines;
            }
        }

        private ITester t;
        public PdfValidationHelper(ITester tester)
        {
            t = tester;
        }

        private string GetPdfContentAsString(string pdfFilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var pdfDocument = new PdfDocument(new PdfReader(pdfFilePath));
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                var page = pdfDocument.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page);
                string processed = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                stringBuilder.Append(processed);
            }
            pdfDocument.Close();
            return stringBuilder.ToString();
        }

        private List<PDFPage> GetPDFContent(string pdfFilePath) 
        { 
            var res = new List<PDFPage>();
            var pdfDocument = new PdfDocument(new PdfReader(pdfFilePath));
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                var page = pdfDocument.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page);
                string processed = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                string[] lines = processed.Split(new string[] { "\n" }, StringSplitOptions.None);
                res.Add(new PDFPage(lines));
            }
            return res;
        }

        private bool Validate(List<PDFPage> pdfPages, ExpectedPDFContent expectedPDFContent, out string actualText)
        {
            if(pdfPages.Count < expectedPDFContent.Page)
            {
                actualText = $"Expected {expectedPDFContent.Page} pages in the pdf, but only got {pdfPages.Count}";
                return false;
            }
            PDFPage pdfPage = pdfPages[expectedPDFContent.Page-1];
            if(pdfPage.Lines.Length < expectedPDFContent.Line)
            {
                actualText = $"Expected {expectedPDFContent.Line} lines on pdf page {expectedPDFContent.Page}, but only got {pdfPage.Lines.Length}";
                return false;
            }
            actualText = pdfPage.Lines[expectedPDFContent.Line - 1];
            return actualText.Equals(expectedPDFContent.ExpectedText);
        }

        public void ValidatePDFAndReport(string pdfFilePath, List<ExpectedPDFContent> expectedContent)
        {
            List<PDFPage> pdfContent = GetPDFContent(pdfFilePath);
            foreach (ExpectedPDFContent expected in expectedContent)
            {
                t.Report.PassFailStep(
                    Validate(pdfContent, expected, out string actualText),
                    $"The pdf content was as expected, Page: {expected.Page} Line: {expected.Line} ExpectedText: '{expected.ExpectedText}'",
                    $"The pdf content was not as expected, {expected.Page} Line: {expected.Line} ExpectedText: '{expected.ExpectedText}' ActualText: '{actualText}'",
                    false
                );
            }
        }
    }

}
