using Domain_Layer.Shared.Base_Value_Object;
using Domain_Layer.Shared.Domain_Exceptios;
using System.Numerics;

namespace Domain_Layer.Shared.Value_Objects
{
    public class Money : BaseValueObject
    {
        public Money(double rialvalue)
        {
            Guard(rialvalue);
            RialValue = rialvalue;
        }
        public double RialValue { get; init; }

        public static Money FromTooman(double Tomn)
        {
            return new Money(Tomn * 10);
        }

        public static Money FromRial(double Tomn)
        {
            return new Money(Tomn);
        }

        public static Money operator +(Money m1, Money m2)
        {

            return new Money(m1.RialValue + m2.RialValue);
        }

        public static Money operator -(Money m1, Money m2)
        {

            return new Money(m1.RialValue - m2.RialValue);
        }

        private void Guard(double value)
        {
            DomainInvalidArgumentException.CheckInvalidIntegerArgs(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
