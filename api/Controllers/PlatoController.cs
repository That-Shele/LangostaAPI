using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Plato;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/plato")]
    [ApiController]
    public class PlatoController : ControllerBase
    {
        private readonly IPlatoRepository _platRepo;
        public PlatoController(IPlatoRepository platRepo)
        {
            _platRepo = platRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlatos() {
            var platos = await _platRepo.GetPlatosAsync();
            var platosDto = platos.Select(p => p.ToPlatoDto());
            return Ok(platos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlato([FromRoute] int id) {
            var plato = await _platRepo.GetPlatoAsync(id);

            if(plato == null){
                return NotFound();
            }

            return Ok(plato.ToPlatoDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlato([FromBody] CreatePlatoRequestDto createDto) {
            var platoModel = createDto.ToCreatePlatoRequestDto();
            await _platRepo.CreatePlatoAsync(platoModel);
            return CreatedAtAction(nameof(GetPlato), new {id = platoModel.IdPlato}, platoModel.ToPlatoDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdatePlato([FromRoute] int id, [FromBody] UpdatePlatoRequestDto updateDto) {
            var platoModel = await _platRepo.UpdatePlatoAsync(id, updateDto);

            if(platoModel == null){
                return NotFound();
            }

            return Ok(platoModel.ToPlatoDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletePlato([FromRoute] int id) {
            var platoModel = await _platRepo.DeletePlatoAsync(id);

            if(platoModel == null) {
                return NotFound();
            }

            return NoContent();
        }
    }
}