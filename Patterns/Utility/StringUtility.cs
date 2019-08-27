using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Utility
{
    public static class StringUtility
    {
        public static string AnyContains(string stringTerm, string insertedValue) => !string.IsNullOrEmpty(insertedValue) ? string.Format(stringTerm, insertedValue) : string.Empty;
    }
}
