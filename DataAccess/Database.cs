using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class Database: IDatabase
    {
        protected string name;

        public Database(string newName)
        {
            this.name = newName;
        }


        /// <summary>
        /// Retrieves data from database.
        /// Thrown exceptions:
        /// - ConnectionClosedException - Attempt to retieve data from a closed connection.
        /// </summary>
        /// <param name="connection">Connection to database</param>
        /// <returns>Dane
        /// Data is retrieved as ten dictonaries. Each contains 3 keys: IdNumber, FirstName, FamilyName.
        /// Subsequent keys values are:
        /// - idNumber (int): subsequent numbers from 0 to 9
        /// - firstName (string): First_name_0, First_name_1, ..., First_name_9
        /// - familyName (string): Family_name_0, Family_name_1, ..., Family_name_9</returns>

        public List<Dictionary<string, object>> GetData(IConnection connection)
        {
            List<Dictionary<string, object>> outputData = new List<Dictionary<string, object>>();       
            
            if (connection.IsOpen() == false)
            {
                throw new ConnectionClosedException();
            }
            else
            {
                return outputData;
            }            
        }

        
        public string GetDatabaseName()
        {
            return this.name;
        }

      
        public IConnection GetNewConnection(string userName, string password)
        {
            Connection getNewConnecttion = new Connection(userName, password);
            return getNewConnecttion;
        }

        
    }
}
