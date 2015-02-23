using System;
using System.Collections.Generic;

namespace ResumeMvc.Models
{
    public class Education
    {
        public string Area { get; set; }

        public List<string> Courses { get; set; }

        public DateTime EndtDate { get; set; }

        public string Gpa { get; set; }

        public string Institution { get; set; }

        public DateTime StartDate { get; set; }

        public string StudyType { get; set; }
    }
}