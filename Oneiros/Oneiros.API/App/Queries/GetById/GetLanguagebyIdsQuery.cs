
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetLanguageByIdQuery : IRequest<LanguageDTO>
    {
        public int Id { get; set; }
    }
}