using CorrectMistakes.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectMistakes.Services.IRepository
{
    public interface IMijozRepository
    {
        public Task Add(int carId, Mijoz mijoz);
        public Task<IEnumerable<Mijoz>> GetAll();
        public Task Update(int id, Mijoz mijoz);
        public Task Delete(int id);

    }
}
