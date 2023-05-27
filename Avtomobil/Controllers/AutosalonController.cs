using Avtomobil.DTO;
using Avtomobil.Services.AutosalonServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avtomobil.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutosalonController : ControllerBase
    {
        IAutosalonService autosalonService;

        public AutosalonController(IAutosalonService autosalonService)
        {
            this.autosalonService = autosalonService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddAutosalonDTO addAutosalonDTO)
        {
            if (addAutosalonDTO is not null)
            {
                await autosalonService.AddAsync(addAutosalonDTO);

                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await autosalonService.GetAllAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, AddAutosalonDTO addAutosalonDTO)
        {
            await autosalonService.UpdateAsync(id, addAutosalonDTO);
            
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await autosalonService.DeleteAsync(id);

            return Ok();
        }
    }
}
