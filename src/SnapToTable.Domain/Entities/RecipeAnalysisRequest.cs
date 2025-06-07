namespace SnapToTable.Domain.Entities;

public record RecipeAnalysisRequest(
    string Name,
    IReadOnlyList<string> ImageUrls
) : BaseEntity;