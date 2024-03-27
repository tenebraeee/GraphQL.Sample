using GraphQL.Sample.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.Sample.DB.Entities
{
    public class Room : BaseDataType
    {
        public int Floor { get; set; }



        [ForeignKey(nameof(Building))]
        public Guid BuildingId { get; set; }
        public virtual Building Building { get; set; }
    }
}
