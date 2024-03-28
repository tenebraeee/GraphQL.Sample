using GraphQL.Sample.DB;
using GraphQL.Sample.DB.Entities;

namespace GraphQL.Sample.Types
{
    public class BuildingQuery
    {
        public async Task<IQueryable<Building>> GetBuildingsAsync([Service] SqlContext context)
        {
            return context.Set<Building>();
        }

        public async Task<Building?> GetBuildingAsync([Service] SqlContext context, Guid id)
        {
            return await context.FindAsync<Building>(id);
        }
    }
}
