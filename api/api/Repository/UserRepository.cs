using api.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace api.Repository
{
    public class UserRepository
    {
        private Conn connection;
        public  User auth(User user)
        {
            string email = user.Email;
            string password =   SHA1.Create(user.Password).ToString(); ;
            string query = "select email, password from  user where password = 'test' && where email = 'geoffroy.alarcon@gmail.com'";
            MySqlConnection conn = connection.connection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
         
            MySqlDataReader rdr = cmd.ExecuteReader();
            User result = new User();
            while (rdr.Read())
            {
              result.Email = rdr.GetString(1);
                result.Password = rdr.GetString(2);
            }
            return result;

        }


    }
}
