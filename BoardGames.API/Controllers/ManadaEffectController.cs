using BoardGames.Application.Services;
using BoardGames.Domain.EffectManade;
using BoardGames.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BoardGames.Controllers;

public class ManadaEffectController(EffectManadeCardService service) : Controller
{
    private readonly EffectManadeCardService _service;
    
    [HttpGet]
    [ProducesResponseType(typeof(List<EffectManadeCardGetDTO>), StatusCodes.Status200OK)]
    public async Task<ActionResult<EffectManadeCard>> GetList()
    {
        var result = await _service.GetList();
        return Ok(result);
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(EffectManadeCardGetDTO), StatusCodes.Status200OK)]
    public async Task<ActionResult<EffectManadeCard>> GetById([FromRoute] int id)
    {
        var result = await _service.GetList();
        return Ok(result);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(EffectManadeCardCreateResponseDTO), StatusCodes.Status201Created)]
    public async Task<ActionResult<EffectManadeCardCreateResponseDTO>> Create([FromBody] EffectManadeCardCreateParamsDTO body)
    {
        var result = await _service.Post(body);
        return Created("",result);
    }
    

    
    
    

    
    
}