using BoardGames.Domain.EffectManade;
using BoardGames.Repositories;

namespace BoardGames.Application.Services;

public class EffectManadeCardService(EffectManadeCardRepository repository)
{
    private readonly EffectManadeCardRepository _repository;
    
    public async Task<EffectManadeCardGetDTO> Get(Guid id)
    {
        return await repository.GetCard(id);
    }
    
    public async Task<EffectManadeCardCreateResponseDTO> Post(EffectManadeCardCreateParamsDTO body)
    {
        return await repository.PostCard(body);
    }
    
    public async Task<List<EffectManadeCardGetDTO>> GetList()
    {
        return await repository.GetCards();
    }
}