using Oneiros.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Repositories.Interfaces
{
    public interface ICampaignRepository
    {
        Task<IEnumerable<Campaign>> GetAll();
    }
}
