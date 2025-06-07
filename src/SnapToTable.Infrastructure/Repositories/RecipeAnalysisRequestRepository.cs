using MongoDB.Driver;
using SnapToTable.Domain.Entities;
using SnapToTable.Domain.Repositories;
using SnapToTable.Infrastructure.Data;

namespace SnapToTable.Infrastructure.Repositories;

public class RecipeAnalysisRequestRepository : BaseRepository<RecipeAnalysisRequest>, IRecipeAnalysisRequestRepository
{
    public RecipeAnalysisRequestRepository(IMongoDatabase database) 
        : base(database, "recipeAnalysisRequests")
    {
    }

} 