using BoardGames.Domain.EffectManade;

namespace BoardGames.Application.Services;

public class EffectManadeCardService
{
    private readonly EffectManadeCardRepository _effectManadeCardRepository;
    
    public async Task<EffectManadeCardGetDTO> Get(Guid id)
    {
        return new EffectManadeCardGetDTO(
        {
            id = new Guid(),
            Question = "sla cu"
        });
    }
}