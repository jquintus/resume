using System;

namespace ResumeMvc.Models
{
    public class Award
    {
        public string Awarder { get; set; }

        public DateTime Date { get; set; }

        public string Summary { get; set; }

        public string Title { get; set; }
    }
}