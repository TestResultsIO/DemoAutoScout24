using Progile.ATE.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScout24_Model.Helpers
{
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

        //Setting with enabled anchors
        //for example "Farmyard Tractor" is no longer a match if we look for "Tractor"
        public static OcrEngineParameters WithAnchors => new OcrEngineParameters
        {
            SearchLevel = SearchLevel.Words,
            EnableStartStringAnchor = true,
            EnableEndStringAnchor = true
        };
    }
}
