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
    public class CarRepository : ICarRepository
    {
        AppDbContext appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task Add(int autosalonId, Car car)
        {
            var autosalon = await appDbContext.Autosalons.FirstOrDefaultAsync(autosalon => autosalon.Id == autosalonId);
            autosalon.Cars.Add(car);
            await appDbContext.Cars.AddAsync(car);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var car = await appDbContext.Cars
                .FirstOrDefaultAsync(car => car.Id == id);

            appDbContext.Cars.Remove(car);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Car>> GetAll()=>
            await appDbContext.Cars.ToListAsync();

        public async Task Update(int id, Car newCar)
        {
            var oldCar = await appDbContext.Cars
                .FirstOrDefaultAsync(car => car.Id == id);
            
            newCar.Id = id;
            appDbContext.Cars.Attach(oldCar).CurrentValues.SetValues(newCar);
            await appDbContext.SaveChangesAsync();
        }
    }
}
