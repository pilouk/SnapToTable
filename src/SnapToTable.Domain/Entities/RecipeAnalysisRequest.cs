namespace SnapToTable.Domain.Entities;

public record RecipeAnalysisRequest(
    DateTime CreateDateTime,
    Guid Id,
    string Name,
    IReadOnlyList<string> ImageUrls
);