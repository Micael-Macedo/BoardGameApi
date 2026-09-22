using BoardGames.Domain.EffectManade;
using BoardGames.Infraestructure.DbContext;
using Microsoft.EntityFrameworkCore;

namespace BoardGames.Repositories;

public class EffectManadeCardRepository(BoardGameDbContext context)
{
    private readonly BoardGameDbContext _dbContext;
    public async Task<List<EffectManadeCardGetDTO>> GetCards()
    {
        var result = await this._dbContext.EffectManade.Select(c => new EffectManadeCardGetDTO()
        {
            Id = c.Id,
            Question = c.Question
        }).ToListAsync();

        return result;
    }
    
    public async Task<EffectManadeCardGetDTO> GetCard(Guid id)
    {
        var result = await this._dbContext.EffectManade.FirstOrDefaultAsync(c => c.Id == id && c.IsActive);

        if (result == null)
        {
            throw new KeyNotFoundException($"Effect manade card with id {id} not found");
        }

        return new EffectManadeCardGetDTO()
        {
            Id = result.Id,
            Question = result.Question
        };
    }

    public async Task<EffectManadeCardCreateResponseDTO> PostCard(EffectManadeCardCreateParamsDTO body)
    {
        var result = await this._dbContext.EffectManade.FirstOrDefaultAsync(c => c.Question.Equals(body.Question));

        if (result != null)
        {
            throw new KeyNotFoundException($"Effect manade card with id not found");
        }

        var effectManadeCard = new EffectManadeCardDB()
        {
            Question = body.Question,
            IsActive = true,
            IsDeleted = false,
            CreatedAt = DateTime.Now,
            CreatedByUserId = "",
            Id = new Guid(),
        };
        
        this._dbContext.EffectManade.Add(effectManadeCard);
        await this._dbContext.SaveChangesAsync();
        
        return new EffectManadeCardCreateResponseDTO()
        {
            Guid = effectManadeCard.Id,
            Question = effectManadeCard.Question,
        };
    }
}