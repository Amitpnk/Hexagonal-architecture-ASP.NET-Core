using System.ComponentModel.DataAnnotations;

namespace Generator.Persistence.Adapter
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
