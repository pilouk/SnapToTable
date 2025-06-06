namespace SnapToTable.Domain.Entities;

public record Recipe(
    DateTime CreatedAt,
    Guid Id,
    Guid RecipeAnalysisRequestId,
    string Title,
    string Description,
    IReadOnlyList<string> Ingredients,
    string Instructions,
    int PrepTimeMinutes,
    int CookTimeMinutes
);