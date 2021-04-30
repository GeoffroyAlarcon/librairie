using api.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repository
{
    public class BookRepository : IItem<Book>
    {
        private Conn connection;
        public List<Book> findAll()
        {
            string query = "";
            MySqlConnection conn = connection.connection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            throw new NotImplementedException();
        }

        public Book findById(int id)
        {
            string query = "";
            MySqlConnection conn = connection.connection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            throw new NotImplementedException();
        }
    }
}
