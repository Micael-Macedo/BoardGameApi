using BoardGames.Domain.EffectManade;
using Microsoft.EntityFrameworkCore;

namespace BoardGames.Infraestructure.DbContext;

public class BoardGameDbContext(DbContextOptions<BoardGameDbContext> options) : Microsoft.EntityFrameworkCore.DbContext(options)
{
    public DbSet<EffectManadeCardDTO> EffectManade => Set<EffectManadeCardDTO>();
    
}