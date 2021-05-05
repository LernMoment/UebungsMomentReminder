using System.Collections.Generic;
using System.Threading.Tasks;

using UebungsMomentReminder.Core.Models;

namespace UebungsMomentReminder.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
    }
}
