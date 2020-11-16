using System.ComponentModel.DataAnnotations;

namespace LogisticProcessor.DataAccess.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
