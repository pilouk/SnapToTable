using MongoDB.Driver;
using SnapToTable.Domain.Entities;
using SnapToTable.Domain.Repositories;
using SnapToTable.Infrastructure.Data;

namespace SnapToTable.Infrastructure.Repositories;

public class RecipeRepository : BaseRepository<Recipe>, IRecipeRepository
{
    public RecipeRepository(IMongoDatabase database) 
        : base(database, "recipes")
    {
    }

} 