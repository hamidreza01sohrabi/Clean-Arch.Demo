using System.ComponentModel.DataAnnotations.Schema;

namespace Domain_Layer.Shared.Base_Classes
{
    public class AggregateRoot:BaseEntity
    {
       
            //...
        private List<BaseDomainEvent> _domainEvents = new List<BaseDomainEvent>();
        
        //نات مپد برای اینکه ای اف بعنوان رابطه یا ریلیشن درنظر نگیره
        [NotMapped]    
        public List<BaseDomainEvent> DomainEvents => _domainEvents;

            public void AddDomainEvent(BaseDomainEvent eventItem)
            {
               /// _domainEvents = _domainEvents ?? new List<BaseDomainEvent>();
                _domainEvents.Add(eventItem);
            }

            public void RemoveDomainEvent(BaseDomainEvent eventItem)
            {
                _domainEvents?.Remove(eventItem);
            }
            //... Additional code
        
    }
}
