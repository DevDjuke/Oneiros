
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetFeatureByIdQuery : IRequest<FeatureDTO>
    {
        public int Id { get; set; }
    }
}