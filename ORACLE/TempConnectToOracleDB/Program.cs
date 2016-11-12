using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Text;
//oracle
using System.Data.SqlClient;
namespace TempConnectToOracleDB
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //OPEN CONNECTION
            string oradb = "User Id=system; Password=123; Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)))";
            OracleConnection conn = new OracleConnection(oradb); 
            conn.Open();

            /*
            //-------------------------------------------------------
            //CREATE TABLE STATEMENT
            OracleCommand commCreate = new OracleCommand();
            commCreate.Connection = conn;           
            commCreate.CommandType = CommandType.Text;

            commCreate.CommandText =    " CREATE TABLE TestTable " +
                                    " ( " +
                                    "  ID  NUMBER not null primary key, " +
                                        " Name varchar2(50) not null, " +
                                        " Category varchar2(50) " + 
                                    " ) ";
        
            commCreate.ExecuteNonQuery();

            //-------------------------------------------------------
            //INSERT STATEMENT
            OracleCommand commInsert = new OracleCommand();
            commInsert.Connection = conn;
            commInsert.CommandType = CommandType.Text;

            commInsert.Parameters.Add(new OracleParameter("Name", "varchar2")).Value = "NAME_VALUE";
            commInsert.Parameters.Add(new OracleParameter("Category", "varchar2")).Value = "CATEGORY";

            commInsert.CommandText = "INSERT INTO TestTable (ID, Name, Category) VALUES (1,:Name, :Category)";
            commInsert.ExecuteNonQuery();

            //------------------------------------------------------
            //UPDATE STATEMENT
            OracleCommand commUpdate = new OracleCommand();
            commUpdate.Connection = conn;
            commUpdate.CommandType = CommandType.Text;
            commUpdate.Parameters.Add(new OracleParameter("NewName", "varchar2")).Value = "NEW_VALUE";
            commUpdate.Parameters.Add(new OracleParameter("Name", "varchar2")).Value = "OLD_VALUE";

            commUpdate.CommandText = "UPDATE TestTable SET TestTable.Name = :NewName WHERE TestTable.Name =  :Name";
            commUpdate.ExecuteNonQuery();

            //------------------------------------------------------
            //SELECT STATEMENT
            OracleCommand commSelect = new OracleCommand();
            commSelect.Connection = conn;
            commSelect.CommandType = CommandType.Text;
            commSelect.Parameters.Add(new OracleParameter("Category", "varchar2")).Value = "SEARCH_VALUE";
            commSelect.CommandText = "SELECT Name FROM TestTable WHERE Category = :Category";

            OracleDataReader reader = commSelect.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }
            reader.Close();

            //-----------------------------------------------------
            //DELETE STATEMENT
            OracleCommand commDelete = new OracleCommand();
            commDelete.Connection = conn;
            commDelete.CommandType = CommandType.Text;
            commDelete.Parameters.Add(new OracleParameter("Category", "varchar2")).Value = "DELETE_VALUE";

            commDelete.CommandText = "DELETE FROM TestTable WHERE Category = :Category";
            commDelete.ExecuteNonQuery();

            //-----------------------------------------------------
            //EXTERMINATUS STATEMENT
            OracleCommand commDrop = new OracleCommand();
            commDrop.Connection = conn;
            commDrop.CommandType = CommandType.Text;

            commDrop.CommandText = "DROP TABLE TestTable";
            commDrop.ExecuteNonQuery();

            */

            //CLOSE CONNECTION
            conn.Close();
           
     
            Console.WriteLine("The End");
            Console.Read();

        }
    }
}
