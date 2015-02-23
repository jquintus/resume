using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeMvc.Models
{
    public class Resume
    {
        public Resume()
    {
        Name = "Josh";
        Title = "Senior Software Engineer";
    }
        public string Name { get; set; }
        public string Title { get; set; }

    }
}
