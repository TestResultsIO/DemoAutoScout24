using Progile.ATE.TestFramework;

namespace Windows_Model
{
    public class TestCase
    {
        protected WindowsApp App { get; set; }

        [SetupTest]
        public virtual bool Setup(ITester t)
        {
            App = new WindowsApp(t);
            return true;
        }

        //[PreconditionStep(
        //    TestInput = "",
        //    ExpectedResults = "")]
        //public virtual void PreconditionStep(ITester t)
        //{ }

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
