using AutoMapper;
using Avtomobil.DTO;
using CorrectMistakes.Data.Model;
using CorrectMistakes.Services.IRepository;

namespace Avtomobil.Services.AutosalonServices
{
    public class AutosalonServices : IAutosalonService
    {
        IAutosalonRepository autosalonRepository;
        IMapper mapper;
        public AutosalonServices(IAutosalonRepository autosalonRepository, IMapper mapper = null)
        {
            this.autosalonRepository = autosalonRepository;
            this.mapper = mapper;
        }

        public async Task AddAsync(AddAutosalonDTO addAutosalonDTO)
        {
            var autosalon =  mapper.Map<Autosalon>(addAutosalonDTO);
            await autosalonRepository.Add(autosalon);
        }

        public async Task DeleteAsync(int id)
        {
            await autosalonRepository.Delete(id);
        }

        public async Task<IEnumerable<Autosalon>> GetAllAsync()=>
            await autosalonRepository.GetAll();

        public async Task UpdateAsync(int id, AddAutosalonDTO newAutosalonDTO)
        {
            var autosalon = mapper.Map<Autosalon>(newAutosalonDTO);
            await autosalonRepository.Update(id, autosalon);
        }
    }
}
