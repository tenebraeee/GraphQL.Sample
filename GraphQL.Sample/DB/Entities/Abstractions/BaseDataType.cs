using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.Sample.DB.Entities.Abstractions
{
    /// <summary>
    /// Базовый тип для сущностей (таблиц).
    /// </summary>
    public abstract class BaseDataType
    {
        public BaseDataType()
        {
            Id = default;

            CreatedAt = DateTime.UtcNow;
        }


        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Дата и время создания
        /// </summary>
        public DateTime CreatedAt { get; private set; }
    }
}
