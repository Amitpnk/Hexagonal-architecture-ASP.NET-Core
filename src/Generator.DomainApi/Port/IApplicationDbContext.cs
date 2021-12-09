namespace Generator.DomainApi.Port
{
    public interface IApplicationDbContext
    {
        public IDealSet Deals { get; set; }
    }
}