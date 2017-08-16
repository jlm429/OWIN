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
      _connectionString = connectionString;
    }

    public String GetTableData()
    {

      using (var conn = new SqlConnection(_connectionString))
      using (var cmd = conn.CreateCommand())
      {
        conn.Open();
        cmd.CommandText = "Select * from dbo.Table_1";
        conn.Close();
        //cmd.Parameters.AddWithValue("@id", id);
       }
      return "";
      }
    }
  }