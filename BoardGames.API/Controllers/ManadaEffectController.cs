using BoardGames.Application.Services;
using BoardGames.Domain.EffectManade;
using BoardGames.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BoardGames.Controllers
{
    [Route(("api/[controller]"))]
    [ApiController]
    public class ManadaEffectController(EffectManadeCardService service) : ControllerBase
    {
        
        [HttpGet]
        [ProducesResponseType(typeof(List<EffectManadeCardGetDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<EffectManadeCard>> GetList()
        {
            var result = await service.GetList();
            return Ok(result);
        }
        
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(EffectManadeCardGetDTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<EffectManadeCard>> GetById([FromRoute] int id)
        {
            var result = await service.Get(id);
            return Ok(result);
        }
        
        [HttpPost]
        [ProducesResponseType(typeof(EffectManadeCardCreateResponseDTO), StatusCodes.Status201Created)]
        public async Task<ActionResult<EffectManadeCardCreateResponseDTO>> Create([FromBody] EffectManadeCardCreateParamsDTO body)
        {
            var result = await service.Post(body);
            return Created("",result);
        }
        

    }
    
    
    

    
    
}