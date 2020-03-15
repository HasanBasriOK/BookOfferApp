using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookOfferApp.Classes
{
    public class BookScore
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public DateTime ScoredDate { get; set; }


        public static void Insert(BookScore item)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"INSERT INTO BookScore (BookId,UserId,Score,ScoredDate) VALUES(@BookId,@UserId,@Score,@ScoredDate)";

            using (var con =new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd =new SqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@BookId", item.BookId);
                    cmd.Parameters.AddWithValue("@UserId", item.UserId);
                    cmd.Parameters.AddWithValue("@Score", item.Score);
                    cmd.Parameters.AddWithValue("@ScoredDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(BookScore item)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"UPDATE BookScore SET Score=@Score WHERE BookId=@BookId AND UserId=@UserId";

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@BookId", item.BookId);
                    cmd.Parameters.AddWithValue("@UserId", item.UserId);
                    cmd.Parameters.AddWithValue("@Score", item.Score);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static BookScore GetObject(int bookId,int userId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"SELECT * FROM BookScore WHERE BookId=@BookId AND UserId=@UserId";

            BookScore item = null;

            using (var con =new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd =new SqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    var dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        item = new BookScore();
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.Score = dr["Score"] != DBNull.Value ? Convert.ToInt32(dr["Score"]) : default(int);
                        item.ScoredDate = dr["ScoredDate"] != DBNull.Value ? Convert.ToDateTime(dr["ScoredDate"]) : DateTime.MinValue;
                        item.UserId = dr["UserId"] != DBNull.Value ? Convert.ToInt32(dr["UserId"]) : default(int);
                    }
                }
            }
            return item;
        }

        public static bool IsUserScoredInPast(int userId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"SELECT COUNT(*) FROM BookScore WHERE UserId=@UserId";

            var result = false;

            using (var con =new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd =new SqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    int count =Convert.ToInt32(cmd.ExecuteScalar());
                    if (count >= 10)
                        result = true;
                }
            }
            return result;
        }
    }
}
