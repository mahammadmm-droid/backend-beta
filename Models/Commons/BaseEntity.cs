namespace WebApplication4.Models.Commons
{
    public abstract class BaseEntity
    {
        public Guid Id { get; init; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
