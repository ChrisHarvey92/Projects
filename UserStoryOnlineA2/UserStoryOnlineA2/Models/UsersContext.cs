using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace UserStoryOnlineA2.Models
{
    public class UsersContext
    {
        public string ConnectionString { get; set; }
        public UsersContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }




        public List<Users> GetAllUsers()
        {
            List<Users> list = new List<Users>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Users()
                        {
                            User_Id = Convert.ToInt32(reader["user_id"]),
                            Firstname = reader["firstname"].ToString(),
                            Surname = reader["surname"].ToString(),
                            Username = reader["username"].ToString(),
                            Email = reader["email"].ToString(),
                            Password = reader["password"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
    }
    

    
}

   
