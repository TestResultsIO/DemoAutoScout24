using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;

namespace AutoScout24_Model
{
    public class TestCase
    {
        protected AutoScout24App App { get; set; }


	    [SetupTest]
        public virtual bool Setup(ITester t)
        {
            App = new AutoScout24App(t);
            return true;
        }

        [PreconditionStep(
            TestInput = "Load AutoScout24 and accept cookies.",
            ExpectedResults = "AutoScout24 main page is displayed")]
        public virtual void PreconditionStep(ITester t)
        {
            t.Optional(() =>
                App.MainPage.AcceptAllCookies.Click(App.MainPage.AcceptAllCookies.WaitForDisappear));
        }

        //[CleanupStep(
        //    TestInput = "",
        //    ExpectedResults = "")]
        //public virtual void CleanupStep(ITester t)
        //{ }

        //[TearDownTest]
        //public virtual bool TearDown(ITester t)
        //{
        //    return true;
        //}
    }
}
