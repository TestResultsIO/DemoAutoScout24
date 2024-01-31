using System.Collections.Generic;
using System.IO;
using TC007_Rev1;
using Windows_Model;
using static TC007_Rev1.PdfValidationHelper;

[TestCase(1)]
public class PDFValidation
{
    private string _pdfPathOnHost;
    private WindowsApp App;

    [SetupTest]
    public virtual bool Setup(ITester t)
    {
        App = new WindowsApp(t);
        return true;
    }

    [TestStep(1, TestInput = "Make pdf file accessible for Execution Host")]
    public void Step1(ITester t)
    {
        //the goal is to parse the .pdf file with the used iText7 Nuget
        //for that the execution host (where to code is running) needs access to the pdf file
        //the following code copies the file from the System Under Test (SUT) to the Execution host using the RemoteDirectory

        //Make sure the connection string to the RemoteDirectory is correctly set on the Test Environment
        //https://docs.testresults.io/designer/interacting-with-the-sut/tabs-overview/environments#remote-directory-connection-string

        string pdfPath = @"C:\\Temp\\";
        string pdfFileName = "myPdf.pdf";
        App.SystemHelpers.SetUpRemoteDirectory(true);
        App.SystemHelpers.CopyFiles(Path.Combine(pdfPath, pdfFileName), App.SystemHelpers.ArtifactsDirectory);
        var remoteDirectoryOnHost = BaseModelHelpers.MapRemoteDirectoryOnHost(t);
        if (!remoteDirectoryOnHost.Exists || remoteDirectoryOnHost.GetFiles(pdfFileName).Length == 0)
            throw new TestStepAbortedException($"Could not read {pdfFileName} on host from remoteDirectory");

        var _pdfPathOnHost = Path.Combine(remoteDirectoryOnHost.FullName, pdfFileName);
    }


    [TestStep(2,
        TestInput = "Verify the content of the pdf",
        ExpectedResults = "The pdf content is as expected")]
    public void Step2(ITester t)
    {
        var helper = new PdfValidationHelper(t);
        string pdfPath = _pdfPathOnHost ?? "myPdf.pdf"; //the variable set in TestStep 1 should be used, but for demo purposes also the pdf project item works
        var expectedPdfContent = new List<ExpectedPDFContent>() 
        { 
            new ExpectedPDFContent(page: 1, line: 13, "Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus."),                     // expected to pass
            new ExpectedPDFContent(page: 1, line: 13, "Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus"),                      // expected to fail, missing the . at the end
            new ExpectedPDFContent(page: 3, line: 20, "In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat efficitur. Cras aliquam"), // expected to fail, text is different
            new ExpectedPDFContent(page: 3, line: 50, "Lorem ipsum dolor sit amet, consectetur adipiscing elit."),   // expected to fail, only 38 lines on page 3
            new ExpectedPDFContent(page: 5, line: 20, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.")    // expected to fail only 4 pages
        };
        helper.ValidatePDFAndReport(pdfPath, expectedPdfContent);
    }

    [CleanupStep(TestInput = "Unmap the Remote Directory on Host")]
    public virtual void CleanupStep(ITester t)
    {
        BaseModelHelpers.UnmapRemoteDirectoryOnHost(t);
    }
}
