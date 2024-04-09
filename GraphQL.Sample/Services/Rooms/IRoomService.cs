using GraphQL.Sample.DB.Entities;

namespace GraphQL.Sample.Services.Rooms
{
    public interface IRoomService
    {
        IQueryable<Room> GetAll();
    }
}