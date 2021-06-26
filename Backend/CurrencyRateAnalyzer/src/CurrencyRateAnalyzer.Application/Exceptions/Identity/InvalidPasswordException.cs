using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Exceptions.Identity
{
    public class InvalidPasswordException : AppException
    {
        public override string Code { get; } = "invalid_password";

        public InvalidPasswordException() : base($"Invalid password.")
        {
        }
    }
}
