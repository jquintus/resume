using System;
using System.Collections.Generic;

namespace ResumeMvc.Models
{
    public class Volunteer
    {
        public DateTime EndDate { get; set; }

        public List<string> Highlights { get; set; }

        public string Organization { get; set; }

        public string Position { get; set; }

        public DateTime StartDate { get; set; }

        public string Summary { get; set; }

        public string Website { get; set; }
    }
}