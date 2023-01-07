using AdvancedWebTechnologies.Shared;
using AdvancedWebTechnologiesHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvancedWebTechnologiesHRM.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
