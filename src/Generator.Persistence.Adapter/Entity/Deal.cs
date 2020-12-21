namespace Generator.Persistence.Adapter.Entity
{
    public class DealEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
