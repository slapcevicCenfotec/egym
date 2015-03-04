using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class RuleViolation
    {
        public string ErrorMEssage { get; private set; }
        public string PropertyName { get; private set; }

        public RuleViolation(string errorMessage, string propertyName)
        {
            ErrorMEssage = errorMessage;
            PropertyName = propertyName;
        }
    }
}
