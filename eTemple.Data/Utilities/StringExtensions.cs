using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Utilities
{
    public static class StringExtensions
    {
        public static string NullString(this string s)
        {
            return string.IsNullOrEmpty(s) ? null : s;
        }
    }
}
