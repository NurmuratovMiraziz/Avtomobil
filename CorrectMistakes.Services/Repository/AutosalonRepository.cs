using CorrectMistakes.Data.DBContext;
using CorrectMistakes.Data.Model;
using CorrectMistakes.Services.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectMistakes.Services.Repository
{
    public class AutosalonRepository : IAutosalonRepository
    {
        AppDbContext appDbContext;

        public AutosalonRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task Add(Autosalon autosalon)
        {
            await appDbContext.Autosalons.AddAsync(autosalon);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var autosalon = await appDbContext.Autosalons
                .FirstOrDefaultAsync(autosalon => autosalon.Id == id);
                
            appDbContext.Autosalons.Remove(autosalon);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Autosalon>> GetAll() =>
            await appDbContext.Autosalons.Include(car => car.Cars).ToListAsync();


        public async Task Update(int id, Autosalon newAutosalon)
        {
            var oldAutosalon = await appDbContext.Autosalons
                .FirstOrDefaultAsync(autosalon => autosalon.Id == id);

            newAutosalon.Id = id;
            appDbContext.Autosalons.Attach(oldAutosalon).CurrentValues.SetValues(newAutosalon);
            await appDbContext.SaveChangesAsync();
        }
    }
}
