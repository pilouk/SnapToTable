namespace SnapToTable.Domain.Entities;

public record Recipe(
    Guid RecipeAnalysisRequestId,
    string Title,
    string Description,
    IReadOnlyList<string> Ingredients,
    string Instructions,
    int PrepTimeMinutes,
    int CookTimeMinutes
) : BaseEntity;