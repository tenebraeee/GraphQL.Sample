using HotChocolate.Execution;

namespace GraphQL.Sample.Types
{
    [ExtendObjectType("Query")]
    public class EquipmentQuery
    {
        public ICollection<EqupmentModel> GetEquipments()
        {
            var error = ErrorBuilder.New()
                .SetMessage("Equipments not implemented")
                .SetCode("not_implemented")
                .Build();

            throw new QueryException(error);
        }
    }

    public class EqupmentModel
    {
        public string Name { get; set; }
    }
}
