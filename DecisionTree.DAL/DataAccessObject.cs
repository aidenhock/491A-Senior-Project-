namespace DecisionTree.DAL
{
    public class DataAccessObject
    {
        private int _usercount = 0;
        public void Create(string sql)
        {
            _usercount++;
        }
        public int Users{get{ return _usercount; }}
    }
}