namespace DecisionTree.DAL
{
    public class DataAccessShould
    {
        [Fact]
        public CreateNewRecordInDataStore()
        {
            var dao = new DataAccessObject();
            var insertSql = "INSERT INTO users VALUES ('john', 'smith')";
            dao.Create(insertSql);
            Assert.True(dao.users == 1);
        }
    }
}

