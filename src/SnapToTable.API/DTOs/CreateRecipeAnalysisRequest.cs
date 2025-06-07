namespace SnapToTable.API.DTOs;

public record CreateRecipeAnalysisRequest(
    string Name,
    IReadOnlyList<IFormFile> Images
);