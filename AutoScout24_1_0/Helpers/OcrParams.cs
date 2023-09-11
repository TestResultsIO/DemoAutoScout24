using Progile.ATE.Common;
using Progile.TRIO.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScout24_Model.Helpers
{
    [ModelOcrParam]
    public static class OcrParams
    {
        //try for texts where the default settings do not work
        public static OcrEngineParameters TextAlternative => new OcrEngineParameters
        {
            OcrEngine = OcrEngines.LEADEngine,
            SearchLevel = SearchLevel.StringComparison,
            Accuracy = 0.4,
            Preprocessing = new OcrPreprocessingParameters { Upscale = true }
        };
    }
}
