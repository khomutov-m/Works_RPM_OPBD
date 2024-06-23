using Microsoft.Data.SqlClient;
using System.Data;

namespace Task1
{
    public static class DataAccessLayer
    {
        public static string DataSource { get; set; } = @"prserver\SQLEXPRESS";
        public static string UserID { get; set; } = "ispp2114";
        public static string Password { get; set; } = "2114";
        public static string InitialCatalog { get; set; } = "ispp2114";
        public static SqlConnectionStringBuilder Builder { get; } = new SqlConnectionStringBuilder()
        {
            DataSource = DataSource,
            UserID = UserID,
            Password = Password,
            InitialCatalog = InitialCatalog,
            TrustServerCertificate = true,
        };

        public static string GetSelection(string query)
        {

            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            SqlCommand command = new(query, connection);
            try
            {
                return command.ExecuteScalar().ToString();
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }

        public static DataTable GetTable(string query)
        {
            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            DataTable table = new();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            try
            {
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }

        public static List<Book> GetList(string query)
        {
            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            SqlCommand cmd = new(query, connection);
            try
            {
                var reader = cmd.ExecuteReader();
                List<Book> books = new();
                while (reader.Read())
                {
                    Book book = new Book()
                    {
                        Id = reader.GetInt32("BookId"),
                        Price = Convert.ToDouble(reader.GetDecimal("Price")),
                        Title = reader.GetString("Title"),
                    };
                    books.Add(book);
                }
                return books;
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }

        public static int Update(string query)
        {
            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            SqlCommand command = new(query, connection);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }

        public static bool ChangePrice(int id, double price)
        {
            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            var query = $"UPDATE Book SET Price = {price} WHERE BookId = {id}";
            SqlCommand command = new(query, connection);
            try
            {
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }

        public static DataTable GetAll(string column)
        {
            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            var query = $"SELECT * FROM {column}";
            DataTable table = new();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            try
            {
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }

        public static void UpdateFromTable(ref DataTable table, string nameTable)
        {
            using SqlConnection connection = new(Builder.ToString());
            connection.Open();
            var query = $"UPDATE {nameTable} SET *";
            using SqlDataAdapter adapter = new(query, connection);
            try
            {
                adapter.Update(table);
            }
            catch
            {
                throw new Exception("Неверный sql-запрос");
            }
        }
    }
}
