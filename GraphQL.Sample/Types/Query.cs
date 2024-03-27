using GraphQL.Sample.DB;
using GraphQL.Sample.DB.Entities;

namespace GraphQL.Sample.Types
{
    public class Query
    {
        
        public async Task<IQueryable<Building>> GetBuildingsAsync([Service] SqlContext context)
        {
            return context.Set<Building>();
        }
    }
}
