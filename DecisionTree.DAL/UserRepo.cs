namespace DecisionTree.DAL
{
    public class UserRepo
    {
        private readonly ISqlDAO _sqlDAO;
        public UserRepo(ISqlDAO sqlDao)
        {
            _sqlDAO = sqlDAO;
        }
        public Response GetUsers()
        {
            var userSelect = "Select * from Users";
            return _sqlDao.ExecuteSQL(userSelect);
        }
    }
}