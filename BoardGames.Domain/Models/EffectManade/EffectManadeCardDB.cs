using BoardGames.Domain.Enums;

namespace BoardGames.Domain.EffectManade;

public class EffectManadeCardDB: BaseEntity
{
    public string Question { get; set; }
    public EffectManadeType EffectManadeType { get; set; } = EffectManadeType.Default;
}