using System.Diagnostics.CodeAnalysis;
using Demo;

namespace session3_LinQ
{
    internal class CustomerEqualityCompare : IEqualityComparer<Customer>
    {
        public bool Equals(Customer? x, Customer? y)
        {
            if (x == null || y == null)
                return false;

          
            return x.City == y.City&& 
                x.CustomerName==y.CustomerName&&
                x.CustomerID==y.CustomerID&&
                x.Fax==y.Fax&&
                x.PostalCode==y.PostalCode
                && x.Address==y.Address;
        }

        public int GetHashCode([DisallowNull] Customer obj)
        {
            return obj?.City?.GetHashCode() ?? 0;
        }
    }
}