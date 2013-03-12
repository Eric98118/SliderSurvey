using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SliderSurvey.ViewModels {
    public class SurveyViewModel {
        public int                          MinSelectedItems;
        public int                          MaxSelectedItems;
        public Dictionary<string, string>   AllValues;
        public string                       UserID;
    }
}