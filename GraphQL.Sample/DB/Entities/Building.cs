using GraphQL.Sample.DB.Entities.Abstractions;

namespace GraphQL.Sample.DB.Entities
{
    public class Building : BaseDataType
    {
        public Building()
        {
            Rooms = new List<Room>();
        }


        public string Address { get; set; }


        public virtual ICollection<Room> Rooms { get; set; }
    }
}
