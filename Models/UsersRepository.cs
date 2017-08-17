using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Linq;

namespace WebApplication5.Models
{
  public class UsersRepository : IUsersRepository
  {
    private readonly string _connectionString;
    public UsersRepository(string connectionString)
    {
        _connectionString = "Data Source=HOME-LAPTOP\\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }

    public UsersRepository()
    {
        _connectionString = "Data Source=HOME-LAPTOP\\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }

    public String GetTableData()
    {

      string sql = "Select * from dbo.table_1";
      SqlConnection conn = new SqlConnection(_connectionString);
      SqlCommand cmd = new SqlCommand(sql, conn);
      
        
      conn.Open();
      cmd.ExecuteNonQuery();
      

      String returnValue = "";

      try
      {
          returnValue = cmd.ExecuteNonQuery().ToString();
      }
      catch
      {
          returnValue = "do nothing";
          
      }

      conn.Close();
        //conn.Open();
        //cmd.CommandText = "Select * from dbo.Table_1";
        //cmd.ExecuteNonQuery(
        //conn.Close();
        //cmd.Parameters.AddWithValue("@id", id);

      return returnValue;
      }
    }
  }