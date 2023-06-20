
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetBackGroundByIdQuery : IRequest<BackGroundDTO>
    {
        public int Id { get; set; }
    }
}