using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories.Interfaces
{
    public interface ICampaignRepository
    {
        Task<IEnumerable<Campaign>> GetAll();
        Task<Campaign> GetById(int id);
        Task Delete(int id);

        Task Update(Campaign obj);

        Task Create(Campaign obj);
    }
}