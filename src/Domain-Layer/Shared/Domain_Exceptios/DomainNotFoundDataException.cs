using Domain_Layer.Shared.Base_Exceptions;
namespace Domain_Layer.Shared.Domain_Exceptios
{
    public class DomainNotFoundDataException:BaseException 
    {
        public DomainNotFoundDataException()
        {

        }
        public DomainNotFoundDataException(string Message) : base(Message)
        {

        }


    }

}
