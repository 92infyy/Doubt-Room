using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace LoginPage
{
    public class DataAccess
    {

        public List<User> getUser(string userName,string password )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                
                 

                return connection.Query<User>("dbo.searchname @userName", new { userName = userName}).ToList();

                //  @userName nvarchar(50),
                //  @passsadas nvarchar(50),
                // @realName nvarchar(50)
            }
        }

        public void insertUser(User user1)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                
                List<User> list = new List<User>();
                list.Add(user1);




                var result = connection.Execute("dbo.insertdata @userName,@pass,@realName ", list);
                

              


            }


        }


    }
}
