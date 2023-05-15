using Avtomobil.DTO;
using CorrectMistakes.Data.Model;

namespace Avtomobil.Services
{
    public interface ICarService
    {
        public Task AddAsync(CarAddDTO carAddDTO);
        public Task UpdateAsync(int id, CarAddDTO carAddDTO);
        public Task DeleteAsync(int id);
        public Task<IEnumerable<Car>> GetAllAsync();
    }
}
