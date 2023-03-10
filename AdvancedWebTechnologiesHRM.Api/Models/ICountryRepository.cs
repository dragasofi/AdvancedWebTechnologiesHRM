using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedWebTechnologies.Shared;
using AdvancedWebTechnologiesHRM.Shared;

namespace AdvancedWebTechnologiesHRM.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
