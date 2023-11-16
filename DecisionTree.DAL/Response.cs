using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree.DAL
{
    public class Response
    {
        public Response()
        {
            HasError = true;
            //etc.
        }
        public bool HasError { get; set; } = true;
        public string? ErrorMessage { get; set; } = null;
        //public Nullable<string>
        public ICollection<object> ReturnValue { get; set; } = null;//can also call returnval Output or something
        public int RetryAttempts { get; set; } = 0;
        public bool isSafeToRetry { get; set; } = false;
    }
}
