using CorrectMistakes.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectMistakes.Services.IRepository
{
    public interface IAutosalonRepository
    {
        public Task Add(Autosalon autosalon);
        public Task<IEnumerable<Autosalon>> GetAll();
        public Task Update(int id, Autosalon autosalon);
        public Task Delete(int id);

    }
}
