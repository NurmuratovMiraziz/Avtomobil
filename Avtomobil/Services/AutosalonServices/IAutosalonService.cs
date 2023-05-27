using Avtomobil.DTO;
using CorrectMistakes.Data.Model;

namespace Avtomobil.Services.AutosalonServices
{
    public interface IAutosalonService
    {
        public Task AddAsync(AddAutosalonDTO addAutosalonDTO);
        public Task<IEnumerable<Autosalon>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, AddAutosalonDTO newAutosalonDTO);
    }
}
