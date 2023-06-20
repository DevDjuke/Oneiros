using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private OneirosContext context;

        public CampaignRepository(OneirosContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Campaign>> GetAll()
        {
            return await context.Campaigns.ToListAsync();
        }

        public async Task<Campaign> GetById(int id)
        {
            return await context.Campaigns.FindAsync(id);
        }

        public async Task Delete(int id)
        {
            Campaign result = await GetById(id);
            if (result != null)
            {
                context.Remove(result);
                await context.SaveChangesAsync();
            }
        }

        public async Task Update(Campaign obj)
        {
            context.Campaigns.Update(obj);
            await context.SaveChangesAsync();
        }

        public async Task Create(Campaign obj)
        {
            context.Campaigns.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}
