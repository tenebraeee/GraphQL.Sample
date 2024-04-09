using GraphQL.Sample.DB.Entities;
using GraphQL.Sample.DB;
using GraphQL.Sample.Services.Rooms;

namespace GraphQL.Sample.Types
{
    [ExtendObjectType("Query")]
    public class RoomQuery
    {
        public IQueryable<Room> GetRooms([Service] IRoomService service)
        {
            return service.GetAll();
        }

        public async Task<Room?> GetRoomAsync([Service] SqlContext context, Guid id)
        {
            return await context.FindAsync<Room>(id);
        }
    }
}
