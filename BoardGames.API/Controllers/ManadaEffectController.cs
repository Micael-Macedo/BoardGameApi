using BoardGames.Domain.EffectManade;
using Microsoft.AspNetCore.Mvc;

namespace BoardGames.Controllers;

public class ManadaEffectController : Controller
{
    [HttpGet]
    [ProducesResponseType(typeof(List<EffectManadeCardGetDTO>), StatusCodes.Status200OK)]
    public async Task<ActionResult<EffectManadeCard>> GetList()
    {
        return View();
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(EffectManadeCardGetDTO), StatusCodes.Status200OK)]
    public async Task<ActionResult<EffectManadeCard>> GetById([FromRoute] int id)
    {
        return View();
    }
    
    [HttpPost]
    public async Task<ActionResult<EffectManadeCard>> Create([FromBody] EffectManadeCardCreateDTO body)
    {
        return View();
    }
    
    [HttpPut]
    public async Task<ActionResult<EffectManadeCard>> Update([FromBody] EffectManadeCardCreateDTO body)
    {
        return View();
    }
    
    
    

    
    
}