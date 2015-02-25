using System.Collections.Generic;

namespace ResumeMvc.Models
{
    public class Resume
    {
        public List<Award> Awards { get; set; }

        public Basics Basics { get; set; }

        public List<Education> Education { get; set; }

        public List<Interest> Interests { get; set; }

        public List<ResumeLanguage> Languages { get; set; }

        public List<Publication> Publications { get; set; }

        public List<ResumeReference> References { get; set; }

        public List<Skill> Skills { get; set; }

        public List<Volunteer> Volunteer { get; set; }

        public List<Work> Work { get; set; }
    }
}