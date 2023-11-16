using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree.DAL
{
    public class Logservice
    {
        private readonly LogRepo _logRepo;
        public bool Log(string logLevel, string category, string? message)
        { _logRepo.Log(DateTime.UtcNow, logLevel, category, message); }


    }
}
