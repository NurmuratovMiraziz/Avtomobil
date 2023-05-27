using AutoMapper;
using Avtomobil.DTO;
using CorrectMistakes.Data.Model;
using CorrectMistakes.Services.IRepository;

namespace Avtomobil.Services
{
    public class CarService : ICarService
    {
        ICarRepository carRepository;
        IAutosalonRepository autosalonRepository;
        IMapper mapper;

        public CarService(IMapper mapper, ICarRepository carRepository, IAutosalonRepository autosalonRepository)
        {
            this.mapper = mapper;
            this.carRepository = carRepository;
            this.autosalonRepository = autosalonRepository;
        }

        public async Task AddAsync(CarAddDTO carAddDTO)
        {
            var car = mapper.Map<Car>(carAddDTO);
            await carRepository.Add(carAddDTO.AutosalonId, car);
        }

        public async Task DeleteAsync(int id)
        {
            await carRepository.Delete(id);
        }

        public async Task<IEnumerable<Car>> GetAllAsync()=>
            await carRepository.GetAll();

        public async Task UpdateAsync(int id, CarAddDTO carAddDTO)
        {
            var car = mapper.Map<Car>(carAddDTO);
            await carRepository.Update(id, car);
        }
    }
}
