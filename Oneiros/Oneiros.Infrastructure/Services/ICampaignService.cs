using Oneiros.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Services
{
    public interface ICampaignService
    {
        Task<IEnumerable<CampaignDTO>> GetAll(); 
    }
}
