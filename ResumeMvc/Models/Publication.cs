using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeMvc.Models
{
public    class Publication
    {
        public string Name { get; set; }
        public string  Publisher { get; set; }
        public string Website { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Summary { get; set; }
    }
}
