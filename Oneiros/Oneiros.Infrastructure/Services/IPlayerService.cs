using Oneiros.Data.DTO;
using Oneiros.Domain.Model;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Services
{
    public interface IPlayerService
    {
        Task<Player> AddNewPlayer(NewPlayerDTO newPlayer);
    }
}
