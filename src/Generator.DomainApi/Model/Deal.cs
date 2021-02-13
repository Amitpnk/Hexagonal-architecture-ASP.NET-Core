namespace Generator.DomainApi.Model
{
    public class Deal : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
