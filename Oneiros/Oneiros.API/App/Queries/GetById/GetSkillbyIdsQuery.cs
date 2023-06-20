
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetSkillByIdQuery : IRequest<SkillDTO>
    {
        public int Id { get; set; }
    }
}