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
        var newAnalysis = new Domain.Entities.RecipeAnalysisRequest(request.Name, ["test"]);
        await _repository.AddAsync(newAnalysis);
        return newAnalysis.Id;
    }
}