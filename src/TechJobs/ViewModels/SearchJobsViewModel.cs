using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel : BaseViewModel
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        // The search results
        public List<Job> Jobs { get; set; }

        // The current column to search, defaults to all
        //override from baseviewmodel class
        //public JobFieldType Column { get; set; } = JobFieldType.All;
        public override JobFieldType Column { get; set; } = JobFieldType.All;

        // The search value
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";

        // All columns, for display
        //public List<JobFieldType> Columns { get; set; }

        // View title
        //public string Title { get; set; } = "";

        public SearchJobsViewModel() : base()
        {
            // Populate the list of all columns
        }
    }
}
