namespace Domain_Layer.Shared.Base_Classes
{
    public class BaseDomainEvent
    {
        public BaseDomainEvent()
        {
            CreationDate = new DateTime();
        }

        public DateTime CreationDate { get; }
    }
}
