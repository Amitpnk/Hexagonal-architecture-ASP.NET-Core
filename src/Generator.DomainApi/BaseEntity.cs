using System.ComponentModel.DataAnnotations;

namespace Generator.DomainApi
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
