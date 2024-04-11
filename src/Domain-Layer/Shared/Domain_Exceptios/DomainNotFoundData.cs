using Domain_Layer.Shared.Base_Exceptions;
namespace Domain_Layer.Shared.Domain_Exceptios
{
    public class DomainNotFoundData:BaseException 
    {
        public DomainNotFoundData()
        {

        }
        public DomainNotFoundData(string Message) : base(Message)
        {

        }


    }

}
