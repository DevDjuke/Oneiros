using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Generic;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ITagRepository
        {
            Task<IEnumerable<Tag>> GetAll();
            Task<Tag> GetById(int id);
            Task Delete(int id);

            Task Update(Tag obj);

            Task Create(Tag obj);
        }
    }
