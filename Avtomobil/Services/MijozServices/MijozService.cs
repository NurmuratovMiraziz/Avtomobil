using AutoMapper;
using Avtomobil.DTO;
using CorrectMistakes.Data.Model;
using CorrectMistakes.Services.IRepository;

namespace Avtomobil.Services.MijozServices
{
    public class MijozService : IMijozService
    {
        IMijozRepository mijozRepository;
        ICarRepository carRepository;
        IMapper mapper;
        public MijozService(IMijozRepository mijozRepository, IMapper mapper = null, ICarRepository carRepository = null)
        {
            this.mijozRepository = mijozRepository;
            this.mapper = mapper;
            this.carRepository = carRepository;
        }

        public async Task AddAsync(MijozAddDTO mijozAddDTO)
        {
            var mijoz = mapper.Map<Mijoz>(mijozAddDTO);
            await mijozRepository.Add(mijozAddDTO.CarId, mijoz);
        }

        public async Task DeleteAsync(int id)
        {
            await mijozRepository.Delete(id);
        }

        public async Task<IEnumerable<Mijoz>> GetAllAsync()=>
            await mijozRepository.GetAll();

        public async Task UpdateAsync(int id, MijozAddDTO newMjozAddDTO)
        {
            var mijoz = mapper.Map<Mijoz>(newMjozAddDTO);
            await mijozRepository.Update(id, mijoz);
        }
    }
}
