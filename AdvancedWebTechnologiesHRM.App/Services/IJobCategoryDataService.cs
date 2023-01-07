using AdvancedWebTechnologiesHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvancedWebTechnologiesHRM.App.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
