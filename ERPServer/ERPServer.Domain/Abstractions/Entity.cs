
namespace ERPServer.Domain.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public DateTime CreatedDate { get; private set; }
        public DateTime? UpdatedDate { get; private set; }

        public bool IsDeleted { get; private set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }

        public void MarkUpdated()
        {
            UpdatedDate = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            IsDeleted = true;
            MarkUpdated();
        }
    }
}