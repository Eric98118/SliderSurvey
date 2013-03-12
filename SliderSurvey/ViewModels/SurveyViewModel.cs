using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SliderSurvey.ViewModels {
    public class SurveyViewModel {
        public int              MinSelectedItems;
        public int              MaxSelectedItems;
        public List<string>     AllValues;
        public string           UserID;
    }
}