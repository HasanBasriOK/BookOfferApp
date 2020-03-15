using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfferApp.Classes
{
    public class User
    {
        #region Properties
        public int UserId { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion

        #region Methods
        public static void Insert(User user)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"INSERT INTO [User](Location,
Age,
FirstName,
LastName,
Username,
Password) VALUES (@Location,
@Age,
@FirstName,
@LastName,
@Username,
@Password)";

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Location", user.Location);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(User user)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"UPDATE [User] SET 
Location=@Location,
Age=@Age,
FirstName=@FirstName,
LastName=@LastName,
Username=@Username,
Password=@Password 
WHERE UserId=@UserId";

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Location", user.Location);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@UserId", user.UserId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<User> GetObjects()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "SELECT * FROM [User]";

            List<User> items = new List<User>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var item = new User();
                        item.Age = dr["Age"] != DBNull.Value ? Convert.ToInt32(dr["Age"]) : default(int);
                        item.FirstName = dr["FirstName"] != DBNull.Value ? dr["FirstName"].ToString() : string.Empty;
                        item.LastName = dr["LastName"] != DBNull.Value ? dr["LastName"].ToString() : string.Empty;
                        item.Location = dr["Location"] != DBNull.Value ? dr["Location"].ToString() : string.Empty;
                        item.Password = dr["Password"] != DBNull.Value ? dr["Password"].ToString() : string.Empty;
                        item.UserId = dr["UserId"] != DBNull.Value ? Convert.ToInt32(dr["UserId"]) : default(int);
                        item.Username = dr["Username"] != DBNull.Value ? dr["Username"].ToString() : string.Empty;

                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static bool IsExist(string username)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "SELECT COUNT(*) FROM [User] WHERE Username=@Username";

            var result = false;

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        result = true;
                }
            }
            return result;
        }

        //public static bool IsExist(string username,string password)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        //    string commandString = "SELECT COUNT(*) FROM [User] WHERE Username=@Username AND Password=@Password";

        //    bool result = false;

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(commandString, con))
        //        {
        //            cmd.Parameters.AddWithValue("@Username", username);
        //            cmd.Parameters.AddWithValue("@Password", password);

        //            int count = (int)cmd.ExecuteScalar();
        //            if (count > 0)
        //                result = true;
        //        }
        //    }
        //    return result;
        //}

        public static void Delete(int userId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "DELETE FROM [User] WHERE UserId=@UserId";

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static User GetUser(string username, string password)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "SELECT * FROM [User] WHERE Username=@Username AND Password=@Password";

            User item = null;

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    var dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        item = new User();
                        item.Age = dr["Age"] != DBNull.Value ? Convert.ToInt32(dr["Age"]) : default(int);
                        item.FirstName = dr["FirstName"] != DBNull.Value ? dr["FirstName"].ToString() : string.Empty;
                        item.LastName = dr["LastName"] != DBNull.Value ? dr["LastName"].ToString() : string.Empty;
                        item.Location = dr["Location"] != DBNull.Value ? dr["Location"].ToString() : string.Empty;
                        item.Password = dr["Password"] != DBNull.Value ? dr["Password"].ToString() : string.Empty;
                        item.UserId = dr["UserId"] != DBNull.Value ? Convert.ToInt32(dr["UserId"]) : default(int);
                        item.Username = dr["Username"] != DBNull.Value ? dr["Username"].ToString() : string.Empty;
                    }
                }
            }
            return item;
        }
        #endregion
    }
}
