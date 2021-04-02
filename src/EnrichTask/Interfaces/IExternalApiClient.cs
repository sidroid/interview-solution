using System.Collections.Generic;
using System.Threading.Tasks;
using EnrichTask.Models;

namespace EnrichTask.Interfaces
{
    public interface IExternalApiClient
    {
        Task<IList<PhoneModel>> GetAllPhonesListAsync();
    }
}