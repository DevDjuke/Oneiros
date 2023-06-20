
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetClasseByIdQuery : IRequest<ClasseDTO>
    {
        public int Id { get; set; }
    }
}