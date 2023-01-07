using System.Collections.Generic;
using AdvancedWebTechnologiesHRM.Shared;

namespace AdvancedWebTechnologiesHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
