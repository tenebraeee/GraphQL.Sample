using GraphQL.Sample.DB.Entities;
using GraphQL.Sample.DB;

namespace GraphQL.Sample.Types
{
    [ExtendObjectType("Query")]
    public class RoomQuery
    {
        public async Task<IQueryable<Room>> GetRoomsAsync([Service] SqlContext context)
        {
            return context.Set<Room>();
        }

        public async Task<Room?> GetRoomAsync([Service] SqlContext context, Guid id)
        {
            return await context.FindAsync<Room>(id);
        }
    }
}
