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
    public class MijozRepository : IMijozRepository
    {
        AppDbContext appDbContext;
        public MijozRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task Add(int carId, Mijoz mijoz)
        {
            var car = await appDbContext.Cars.FirstOrDefaultAsync(car => car.Id == carId);
            car.Mijoz.Add(mijoz);
            await appDbContext.Mijozs.AddAsync(mijoz);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var mijoz = await appDbContext.Mijozs
                .FirstOrDefaultAsync(mijoz => mijoz.Id == id);

            appDbContext.Mijozs.Remove(mijoz);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Mijoz>> GetAll()=>
            await appDbContext.Mijozs.Include(car => car.Cars).ToListAsync();

        public async Task Update(int id, Mijoz newMijoz)
        {
            var oldMijoz = await appDbContext.Mijozs
                .FirstOrDefaultAsync(mijzo => mijzo.Id == id);

            newMijoz.Id = id;
            appDbContext.Mijozs.Attach(oldMijoz).CurrentValues.SetValues(newMijoz);
            await appDbContext.SaveChangesAsync();
        }
    }
}
