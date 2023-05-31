using Avtomobil.DTO;
using CorrectMistakes.Data.Model;

namespace Avtomobil.Services.MijozServices
{
    public interface IMijozService
    {
        public Task AddAsync(MijozAddDTO mijozAddDTO);
        public Task<IEnumerable<Mijoz>> GetAllAsync();
        public Task UpdateAsync(int id, MijozAddDTO mijozAddDTO);
        public Task DeleteAsync(int id);
    }
}
