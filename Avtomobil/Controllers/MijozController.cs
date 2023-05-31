using Avtomobil.DTO;
using Avtomobil.Services.MijozServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avtomobil.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MijozController : ControllerBase
    {
        IMijozService mijozService;

        public MijozController(IMijozService mijozService)
        {
            this.mijozService = mijozService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(MijozAddDTO mijozAddDTO)
        {
            if (mijozAddDTO is not  null)
            {
                await mijozService.AddAsync(mijozAddDTO);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await  mijozService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id, MijozAddDTO mijozAddDTO)
        {
            await mijozService.UpdateAsync(id, mijozAddDTO);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await mijozService.DeleteAsync(id);

            return Ok();
        }
    }
}
