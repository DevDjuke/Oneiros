using Oneiros.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Web
{
    public interface ICampaignWebService
    {
        Task<List<CampaignDTO>> GetAll();
        Task<CampaignDTO> GetById(int id);
    }
}
