using System.Collections.Generic;

namespace DataStructures
{
    public class MyOwnListComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're 
                    // equal.  
                    return 0;
                }
                // If x is null and y is not null, y 
                // is greater.  
                return -1;
            }
            // If x is not null... 
            if (y == null)
                // ...and y is null, x is greater.
            {
                return 1;
            }
            // ...and y is not null, compare the  
            // lengths of the two strings. 
            var retval = x.Length.CompareTo(y.Length);

            return retval != 0 ? retval : System.String.Compare(x, y, System.StringComparison.Ordinal);
        }
    }
}