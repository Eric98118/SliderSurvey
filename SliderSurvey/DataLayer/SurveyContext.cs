﻿using SliderSurvey.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SliderSurvey.DataLayer {
    public class SurveyContext : DbContext {
        public DbSet<SurveyResult> SurveyResults { get; set; }
        public DbSet<ValueCard> ValueCards { get; set; }
    }
}