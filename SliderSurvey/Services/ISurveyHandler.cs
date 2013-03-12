using SliderSurvey.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliderSurvey.Services {
    interface ISurveyHandler {
        SurveyViewModel PopulateInitialSurvey(string userId);
        SurveyViewModel PopulateContinuingSurvey(string userId, List<string> options);
    }
}
