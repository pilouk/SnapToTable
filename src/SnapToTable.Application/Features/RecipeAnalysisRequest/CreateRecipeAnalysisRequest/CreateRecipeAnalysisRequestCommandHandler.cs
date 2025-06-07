using MediatR;
using SnapToTable.Domain.Repositories;

namespace SnapToTable.Application.Features.RecipeAnalysisRequest.CreateRecipeAnalysisRequest;

public class CreateRecipeAnalysisRequestCommandHandler : IRequestHandler<CreateRecipeAnalysisRequestCommand, Guid>
{
    private readonly IRecipeAnalysisRequestRepository _repository;

    public CreateRecipeAnalysisRequestCommandHandler(IRecipeAnalysisRequestRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateRecipeAnalysisRequestCommand request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(Guid.CreateVersion7());
    }
}