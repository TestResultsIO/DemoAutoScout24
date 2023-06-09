using Progile.ATE.TestFramework;

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
