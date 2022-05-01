using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace MysqlPractice.Controller
{
   class DBController
   {
      MySqlConnection Conn = new MySqlConnection("Server=127.0.0.1;Port=3306;DataBase=classicmodels;Uid=root;Pwd=root");
      internal  bool IsDBOpen=false;
      /// <summary>
      /// DB Open
      /// </summary>
      /// <returns></returns>
      public bool Open()
      {
         try
         {
            if (Conn!=null)
            {
               Conn.Open();
               return true;
            }
            else
            {
               return false;
            }
         }
         catch (Exception ex)
         {
            return false;
         }
      }
      /// <summary>
      /// DB Close
      /// </summary>
      public void Close()
      {
         try
         {
            if (Conn != null)
            {
               Conn.Close();
               MessageBox.Show("연결 닫힘");
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"에러 : {ex}");
         }
      }
      /// <summary>
      /// DB에서 원하는 정보 조회
      /// </summary>
      /// <param name="_table">불러오는 정보 모음집</param>
      /// <returns></returns>
      public DataTable SelectWhatIWant(String _table)
      {
         DataSet ds = new DataSet();
         DataTable resultTable = new DataTable();
         String query = $" SELECT * FROM {_table}; ";
         try
         {
            using(MySqlCommand cmd=new MySqlCommand(query,Conn))
            using(MySqlDataAdapter adt = new MySqlDataAdapter(cmd))
            {
               adt.SelectCommand = cmd;
               adt.Fill(ds);
               resultTable= ds.Tables[0];
               return resultTable;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"에러 : {ex}");
            return null;
         }
      }
   }
}
