[TestCase(1)]
public class SellMyTractor : TestCase
{
    [TestStep(1)]
    public void Step1(ITester t)
    {
        //same precondition as tc001
        //Open Menu -> click Trucks
        //validate browser url switched to trucks
        //click sell now (the one below because the one on top requires a login?)
        //enter some info
        //click next -> check validation messages (with test case images?)
        t.Report.PassStep("Hello World!");
    }
}
