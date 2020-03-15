using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfferApp.Classes
{
    public class Book
    {
        #region Properties
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int YearOfPublication { get; set; }
        public string Publisher { get; set; }
        public string ImageUrlS { get; set; }
        public string ImageUrlM { get; set; }
        public string ImageUrlL { get; set; }
        public Image Image { get; set; }
        #endregion

        #region Methods
        public static void Insert(Book book)
        {
            
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            
            var commandString = @"INSERT INTO Books(ISBN,
BookTitle,
BookAuthor,
YearOfPublication,
Publisher,
ImageUrlS,
ImageUrlM,
ImageUrlL) VALUES (
@ISBN,
@BookTitle,
@BookAuthor,
@YearOfPublication,
@Publisher,
@ImageUrlS,
@ImageUrlM,
@ImageUrlL)";

            
            using (var con = new SqlConnection(connectionString))
            {
                
                con.Open();
               
                using (var cmd = new SqlCommand(commandString, con))
                {
                    
                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("@BookTitle", book.BookTitle);
                    cmd.Parameters.AddWithValue("@BookAuthor", book.BookAuthor);
                    cmd.Parameters.AddWithValue("@YearOfPublication", book.YearOfPublication);
                    cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("ImageUrlS", book.ImageUrlS);
                    cmd.Parameters.AddWithValue("ImageUrlM", book.ImageUrlM);
                    cmd.Parameters.AddWithValue("ImageUrlL", book.ImageUrlL);

                   
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Book book)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            var commandString = @"UPDATE Books SET 
ISBN=@ISBN,
BookTitle=@BookTitle,
BookAuthor=@BookAuthor,
YearOfPublication=@YearOfPublication,
Publisher=@Publisher,
ImageUrlS=@ImageUrlS,
ImageUrlM=@ImageUrlM,
ImageUrlL=@ImageUrlL 
WHERE BookId=@BookId";

            
            using (var con = new SqlConnection(connectionString))
            {
                
                con.Open();
                
                using (var cmd = new SqlCommand(commandString, con))
                {
                    
                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("@BookTitle", book.BookTitle);
                    cmd.Parameters.AddWithValue("@BookAuthor", book.BookAuthor);
                    cmd.Parameters.AddWithValue("@YearOfPublication", book.YearOfPublication);
                    cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("ImageUrlS", book.ImageUrlS);
                    cmd.Parameters.AddWithValue("ImageUrlM", book.ImageUrlM);
                    cmd.Parameters.AddWithValue("ImageUrlL", book.ImageUrlL);
                    cmd.Parameters.AddWithValue("BookId", book.BookId);

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public static List<Book> GetObjects()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "SELECT * FROM Books";

           
            var items = new List<Book>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {

                    var dr = cmd.ExecuteReader();
                   

                    while (dr.Read())
                    {
                        
                        var item = new Book();
                        item.BookAuthor = dr["BookAuthor"] != DBNull.Value ? dr["BookAuthor"].ToString() : string.Empty;
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.BookTitle = dr["BookTitle"] != DBNull.Value ? dr["BookTitle"].ToString() : string.Empty;
                        item.ImageUrlL = dr["ImageUrlL"] != DBNull.Value ? dr["ImageUrlL"].ToString() : string.Empty;
                        item.ImageUrlM = dr["ImageUrlM"] != DBNull.Value ? dr["ImageUrlM"].ToString() : string.Empty;
                        item.ImageUrlS = dr["ImageUrlS"] != DBNull.Value ? dr["ImageUrlS"].ToString() : string.Empty;
                        item.ISBN = dr["ISBN"] != DBNull.Value ? dr["ISBN"].ToString() : string.Empty;
                        item.YearOfPublication = dr["YearOfPublication"] != DBNull.Value ? Convert.ToInt32(dr["YearOfPublication"]) : default(int);
                        item.Publisher = dr["Publisher"] != DBNull.Value ? dr["Publisher"].ToString() : string.Empty;

                        
                        items.Add(item);
                    }
                }
            }
            
            return items;
        } 

        public static void Delete(int bookId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "DELETE FROM Books WHERE BookId=@BookId";

            using (var con =new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd =new SqlCommand(commandString,con))
                {
                  
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool IsExist(string ISBN)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"SELECT COUNT(*) FROM Books WHERE ISBN=@ISBN";

            bool result = false;

            using (var con =new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd =new SqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@ISBN", ISBN);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                        result = true;
                }
            }

            return result;
        }

        public static List<Book> GetObjectsWithIndex(int startIndex,int endIndex)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "SELECT * FROM Books WHERE BookId>=@StartIndex AND BookId<=@EndIndex";

            var items = new List<Book>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@StartIndex", startIndex);
                    cmd.Parameters.AddWithValue("@EndIndex",endIndex);

                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var item = new Book();
                        item.BookAuthor = dr["BookAuthor"] != DBNull.Value ? dr["BookAuthor"].ToString() : string.Empty;
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.BookTitle = dr["BookTitle"] != DBNull.Value ? dr["BookTitle"].ToString() : string.Empty;
                        item.ImageUrlL = dr["ImageUrlL"] != DBNull.Value ? dr["ImageUrlL"].ToString() : string.Empty;
                        item.ImageUrlM = dr["ImageUrlM"] != DBNull.Value ? dr["ImageUrlM"].ToString() : string.Empty;
                        item.ImageUrlS = dr["ImageUrlS"] != DBNull.Value ? dr["ImageUrlS"].ToString() : string.Empty;
                        item.ISBN = dr["ISBN"] != DBNull.Value ? dr["ISBN"].ToString() : string.Empty;
                        item.YearOfPublication = dr["YearOfPublication"] != DBNull.Value ? Convert.ToInt32(dr["YearOfPublication"]) : default(int);

                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static List<Book> GetNewestBooks()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = "SELECT TOP 5 * FROM Books ORDER BY BookId DESC";

            var items = new List<Book>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var item = new Book();
                        item.BookAuthor = dr["BookAuthor"] != DBNull.Value ? dr["BookAuthor"].ToString() : string.Empty;
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.BookTitle = dr["BookTitle"] != DBNull.Value ? dr["BookTitle"].ToString() : string.Empty;
                        item.ImageUrlL = dr["ImageUrlL"] != DBNull.Value ? dr["ImageUrlL"].ToString() : string.Empty;
                        item.ImageUrlM = dr["ImageUrlM"] != DBNull.Value ? dr["ImageUrlM"].ToString() : string.Empty;
                        item.ImageUrlS = dr["ImageUrlS"] != DBNull.Value ? dr["ImageUrlS"].ToString() : string.Empty;
                        item.ISBN = dr["ISBN"] != DBNull.Value ? dr["ISBN"].ToString() : string.Empty;
                        item.YearOfPublication = dr["YearOfPublication"] != DBNull.Value ? Convert.ToInt32(dr["YearOfPublication"]) : default(int);

                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static List<Book> GetPopularBooks()
        {
            //oylanma sayısı en yüksek olan kitaplar
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"SELECT TOP 10 BS.BookId,COUNT(*) ,B.BookAuthor,B.BookTitle,B.ImageUrlL,B.ImageUrlM,B.ImageUrlS,B.ISBN,B.Publisher,B.YearOfPublication
FROM BookScore AS BS INNER JOIN 
Books AS B ON B.BookId=BS.BookId
GROUP BY BS.BookId ,B.BookAuthor,B.BookTitle,B.ImageUrlL,B.ImageUrlM,B.ImageUrlS,B.ISBN,B.Publisher,B.YearOfPublication
ORDER BY COUNT(*) DESC
";

            var items = new List<Book>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var item = new Book();
                        item.BookAuthor = dr["BookAuthor"] != DBNull.Value ? dr["BookAuthor"].ToString() : string.Empty;
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.BookTitle = dr["BookTitle"] != DBNull.Value ? dr["BookTitle"].ToString() : string.Empty;
                        item.ImageUrlL = dr["ImageUrlL"] != DBNull.Value ? dr["ImageUrlL"].ToString() : string.Empty;
                        item.ImageUrlM = dr["ImageUrlM"] != DBNull.Value ? dr["ImageUrlM"].ToString() : string.Empty;
                        item.ImageUrlS = dr["ImageUrlS"] != DBNull.Value ? dr["ImageUrlS"].ToString() : string.Empty;
                        item.ISBN = dr["ISBN"] != DBNull.Value ? dr["ISBN"].ToString() : string.Empty;
                        item.YearOfPublication = dr["YearOfPublication"] != DBNull.Value ? Convert.ToInt32(dr["YearOfPublication"]) : default(int);

                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static List<Book> GetBestBooks()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @"SELECT TOP 10 BS.BookId,AVG(Score),B.BookAuthor,B.BookTitle,B.ImageUrlL,B.ImageUrlM,B.ImageUrlS,B.ISBN,B.Publisher,B.YearOfPublication
FROM BookScore AS BS INNER JOIN
[Books] AS B ON B.BookId = BS.BookId
            GROUP BY BS.BookId ,B.BookAuthor,B.BookTitle,B.ImageUrlL,B.ImageUrlM,B.ImageUrlS,B.ISBN,B.Publisher,B.YearOfPublication
            ORDER BY AVG(BS.Score)DESC";

            var items = new List<Book>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var item = new Book();
                        item.BookAuthor = dr["BookAuthor"] != DBNull.Value ? dr["BookAuthor"].ToString() : string.Empty;
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.BookTitle = dr["BookTitle"] != DBNull.Value ? dr["BookTitle"].ToString() : string.Empty;
                        item.ImageUrlL = dr["ImageUrlL"] != DBNull.Value ? dr["ImageUrlL"].ToString() : string.Empty;
                        item.ImageUrlM = dr["ImageUrlM"] != DBNull.Value ? dr["ImageUrlM"].ToString() : string.Empty;
                        item.ImageUrlS = dr["ImageUrlS"] != DBNull.Value ? dr["ImageUrlS"].ToString() : string.Empty;
                        item.ISBN = dr["ISBN"] != DBNull.Value ? dr["ISBN"].ToString() : string.Empty;
                        item.YearOfPublication = dr["YearOfPublication"] != DBNull.Value ? Convert.ToInt32(dr["YearOfPublication"]) : default(int);

                        items.Add(item);
                    }
                }
            }
            return items;

        }

        public static List<Book> BookOffer(int userId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            var commandString = @" SELECT * FROM [Books] WHERE  BookId IN(
SELECT DISTINCT BookId
FROM [BookScore] 
WHERE UserId IN(
SELECT TOP 5 UserId
FROM[BookScore]
WHERE[BookId]
IN(SELECT[BookId] FROM[BookScore] WHERE UserId = @UserId)) 
AND BookId NOT IN(SELECT[BookId] FROM[BookScore] WHERE UserId = @UserId) ) 
";

            var items = new List<Book>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var item = new Book();
                        item.BookAuthor = dr["BookAuthor"] != DBNull.Value ? dr["BookAuthor"].ToString() : string.Empty;
                        item.BookId = dr["BookId"] != DBNull.Value ? Convert.ToInt32(dr["BookId"]) : default(int);
                        item.BookTitle = dr["BookTitle"] != DBNull.Value ? dr["BookTitle"].ToString() : string.Empty;
                        item.ImageUrlL = dr["ImageUrlL"] != DBNull.Value ? dr["ImageUrlL"].ToString() : string.Empty;
                        item.ImageUrlM = dr["ImageUrlM"] != DBNull.Value ? dr["ImageUrlM"].ToString() : string.Empty;
                        item.ImageUrlS = dr["ImageUrlS"] != DBNull.Value ? dr["ImageUrlS"].ToString() : string.Empty;
                        item.ISBN = dr["ISBN"] != DBNull.Value ? dr["ISBN"].ToString() : string.Empty;
                        item.YearOfPublication = dr["YearOfPublication"] != DBNull.Value ? Convert.ToInt32(dr["YearOfPublication"]) : default(int);

                        items.Add(item);
                    }
                }
            }
            return items;

        }

        #endregion
    }
}
