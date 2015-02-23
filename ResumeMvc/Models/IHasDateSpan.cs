using System;

namespace ResumeMvc.Models
{
    public interface IHasDateSpan
    {
        DateTime? EndDate { get; set; }

        DateTime? StartDate { get; set; }
    }
}