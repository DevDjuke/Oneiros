using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories.Interfaces;

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
    }
}
