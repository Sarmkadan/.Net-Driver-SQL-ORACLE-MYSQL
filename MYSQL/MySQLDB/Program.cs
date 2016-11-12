using System;
using MySql.Data.MySqlClient;

namespace MySQLDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost; Database=database; Uid=USER; Pwd=PASSWORD");

            //OPEN CONNECTION
            myConnection.Open();

            //-------------------------------------------------------
            //CREATE TABLE STATEMENT
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = " CREATE TABLE TestTable " +
                                    " ( " +
                                        " ID INT(5) NOT NULL AUTO_INCREMENT, " +
                                        " Name VARCHAR(255) NOT NULL, " +
                                        " Category VARCHAR(255), " +
                                        " PRIMARY KEY (ID)" +
                                    " ) ";

            myCommand.ExecuteNonQuery();

            //-------------------------------------------------------
            //INSERT STATEMENT
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = "NAME_VALUE";
            myCommand.Parameters.Add("@Category", MySqlDbType.VarChar).Value = "CATEGORY_VALUE";

            myCommand.CommandText = "INSERT INTO TestTable (Name, Category) VALUES (@Name, @Category);";
            myCommand.ExecuteNonQuery();

            //------------------------------------------------------
            //UPDATE STATEMENT
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = "OLD_VALUE";
            myCommand.Parameters.Add("@NewName", MySqlDbType.VarChar).Value = "NEW_VALUE";
            myCommand.CommandText = "UPDATE TestTable SET Name = @NewName WHERE Name =  @Name;";
            myCommand.ExecuteNonQuery();

            //------------------------------------------------------
            //SELECT STATEMENT
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.Parameters.Add("@Category", MySqlDbType.VarChar).Value = "SEARCH_VALUE";
            myCommand.CommandText = "SELECT Name FROM TestTable WHERE Category = @Category;";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }
            reader.Close();

            //-----------------------------------------------------
            //DELETE STATEMENT
            myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            myCommand.Parameters.Add("@Category", MySqlDbType.VarChar).Value = "DELETE_VALUE";
            myCommand.CommandText = "DELETE FROM TestTable WHERE Category = @Category;";
            myCommand.ExecuteNonQuery();

            myCommand.CommandText = "DROP TABLE TestTable;";
            myCommand.ExecuteNonQuery();

            Console.ReadLine();

            //CLOSE CONNECTION
            myConnection.Close();
        }
    }
}