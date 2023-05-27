using Avtomobil.DTO;
using Avtomobil.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avtomobil.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddAsync(CarAddDTO car)
        {
            if (car is not null)
            {
                await carService.AddAsync(car);
                return Ok();
            }
            return BadRequest();
        }

        //[Authorize(Roles = "Admin, User")]
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await carService.GetAllAsync());
        }

        //[Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, CarAddDTO carAddDTO)
        {
            await carService.UpdateAsync(id, carAddDTO);
            return Ok();
        }

        //[Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<IActionResult> Deleteasync(int Id)
        {
            await carService.DeleteAsync(Id);
            return Ok();
        }
    }
}
