using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Exceptions
{
    [Serializable]
    public class AppChurchValidatorException : Exception 
    {
        public AppChurchValidatorException(Dictionary<string, IEnumerable<string>> errors) : base("Invalid data")
            => Errors = errors;

        public Dictionary<string, IEnumerable<string>> Errors { get;}
    }
}
