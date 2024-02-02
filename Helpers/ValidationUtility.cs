using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRepositoryArchitecture.Helpers
{
    internal class ValidationUtility
    {
        public static bool IsValidTaskTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title);
        }
    }
}
