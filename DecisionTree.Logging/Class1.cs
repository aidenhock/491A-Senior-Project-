using DecisionTree.DataAccess;

namespace DecisionTree.Logging
{
    public class Logging
    {
        //Creates a separate info to be inputted into the table from a single Error output
        public static void CreateLog(string Log)
        {
            //Separates between new lines
            char[] separator = { '\n' };
            //Splites the string into separate parts
            String[] LogInfo = Log.Split(separator);
            //Console.WriteLine(LogInfo[0]);
            //Runs the InsertData method using the info we separated
            Data.InsertData(LogInfo[0], LogInfo[1]);
        }
    }
}