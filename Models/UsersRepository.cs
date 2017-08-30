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

        string sql = "SELECT TOP (1000) [GenKey3],[Test] FROM [master].[dbo].[MyTable]";
      SqlConnection conn = new SqlConnection(_connectionString);
      SqlCommand cmd = new SqlCommand(sql, conn);
      List<String> dbValues = new List<String>();
      
        
      conn.Open();
      cmd.ExecuteNonQuery();
      

      String returnValue = "";

      try
      {
      
          using (SqlDataReader dr = cmd.ExecuteReader())
          {
              while (dr.Read())
              {
                  
                  String dbValue = dr["Test"].ToString();
                  dbValues.Add(dbValue);
              }
          }
         
      }
      catch
      {
          returnValue = "do nothing";
          
      }

      finally
      { 
      conn.Close();
      }


      foreach (var dbValue in dbValues)
      {
          returnValue = returnValue + " " + dbValue;
      }

      return returnValue;
      }
    }
  }