﻿using CorrectMistakes.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectMistakes.Services.IRepository
{
    public interface ICarRepository
    {
        public Task Add(int autosalonId, Car car);
        public Task Update(int id, Car car);
        public Task Delete(int id);
        public Task<IEnumerable<Car>> GetAll();
        public Task<IEnumerable<Car>> GetAllModel(string model);
    }
}
