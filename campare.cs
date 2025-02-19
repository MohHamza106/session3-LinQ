using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_LinQ
{
    public class campare : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            if (x == null || y == null) return false;
            return GetSortedString(x) == GetSortedString(y);
        }

        public int GetHashCode(string obj)
        {
            return GetSortedString(obj).GetHashCode();
        }

        private string GetSortedString(string str)
        {
            return new string(str.Trim().OrderBy(c => c).ToArray()); 
        }
    }
}
