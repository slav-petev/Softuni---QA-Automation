using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Tests.Common;
using ToolsQA.Tests.Models;

namespace ToolsQA.Tests.Factories
{
    public static class UserFactory
    {
        public static User CreateUser(string key)
        {
            User user = default(User);
            using (var connection = new OleDbConnection(
                Settings.TestData.TestDataConnectionString))
            {
                var userSelectStatement = string.Format(@"
                    SELECT [FirstName], [LastName], [MartialStatus],
                           [Country], [Birthday], [PhoneNumber],
                           [UserName], [Email], [Picture],
                           [Description], [Password]
                    FROM [Sheet1$]
                    WHERE [Key] = '{0}'", key);

                connection.Open();
                user = connection.QuerySingle<User>(userSelectStatement);
                user.Hobbies = GetHobbies(connection);
            }

            return user;
        }

        private static IEnumerable<string> GetHobbies(OleDbConnection connection)
        {
            var hobbies = 
                connection.QuerySingle<string>("SELECT [Hobbies] FROM [Sheet1$]");

            return hobbies?.Split(';');
        }
    }
}
