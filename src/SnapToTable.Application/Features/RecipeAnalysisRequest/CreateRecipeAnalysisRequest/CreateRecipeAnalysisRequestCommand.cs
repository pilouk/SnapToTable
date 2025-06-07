using System;
using MediatR;
using SnapToTable.Application.DTOs;

namespace SnapToTable.Application.Features.RecipeAnalysisRequest.CreateRecipeAnalysisRequest;

public record CreateRecipeAnalysisRequestCommand(string Name, IReadOnlyList<ImageInput> Images) : IRequest<Guid>;