using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DecisionTree.DAL
{
    public interface ISqlDAO
    {
        Response ExecuteSql(string sql);
    }
}
