using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree.DAL
{
    public class LogRepo
    {
        private readonly ISqlDAO _sqlDAO;
        public LogRepo(ISqlDAO sqlDAO)
        {
            _sqlDAO = sqlDAO;
        }
        public bool Log(string logLevel, string category, string message)
        {
            _sqlDAO.ExecuteSQL($"Insert into dbo.Logs values({logLevel}, {DateTime.UtcNow}, {category}, {message})");
            return true;
        }
    }
}
