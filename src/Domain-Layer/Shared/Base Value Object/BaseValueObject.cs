using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared.Base_Value_Object
{
   
    public abstract class BaseValueObject : IEquatable<BaseValueObject>
    {
        
        public static bool operator ==(BaseValueObject? a, BaseValueObject? b)
        {
            if (a is null && b is null)
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(BaseValueObject? a, BaseValueObject? b) =>
            !(a == b);

        public virtual bool Equals(BaseValueObject? other) =>
            other is not null && ValuesAreEqual(other);

        public override bool Equals(object? obj) =>
            obj is BaseValueObject BaseValueObject && ValuesAreEqual(BaseValueObject);

        public override int GetHashCode() =>
            GetAtomicValues().Aggregate(
                default(int),
                (hashcode, value) =>
                    HashCode.Combine(hashcode, value.GetHashCode()));

        protected abstract IEnumerable<object> GetAtomicValues();

        private bool ValuesAreEqual(BaseValueObject valueObject) =>
            GetAtomicValues().SequenceEqual(valueObject.GetAtomicValues());
    }
}
