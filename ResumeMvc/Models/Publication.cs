using System;

namespace ResumeMvc.Models
{
    public class Publication
    {
        public string Name { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Summary { get; set; }

        public string Website { get; set; }
    }
}