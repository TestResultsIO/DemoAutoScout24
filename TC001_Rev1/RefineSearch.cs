[TestCase(1)]
public class RefineSearch : TestCase
{
    [TestStep(1)]
    public void Step1(ITester t)
    {
        t.Report.PassStep("Hello World!");
    }
}
