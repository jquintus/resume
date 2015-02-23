using System.Collections.Generic;
namespace ResumeMvc.Models
{
    public class Basics
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Summary { get; set; }
        public Location Location { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}