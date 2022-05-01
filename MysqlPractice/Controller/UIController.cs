using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using MysqlPractice.Controller;
namespace MysqlPractice.Controller
{
   class UIController
   {
      
      
      internal static void ButtonSetting(Button _button)
      {
         _button.TextAlign = ContentAlignment.MiddleCenter;
         _button.Font = new Font("Calibri", 30, FontStyle.Bold);
         _button.BackColor = Color.FromArgb(64, 64, 64);
         _button.ForeColor = Color.White;
         _button.TabStop = false;
         _button.FlatStyle = FlatStyle.Flat;
         _button.FlatAppearance.BorderSize = 0;
         _button.FlatAppearance.MouseOverBackColor = Color.Green;
      }
      internal static void DataGridViewSetting(DataGridView view)
      {

         view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         view.AllowUserToAddRows = false;
         view.AllowUserToResizeRows = false;
         view.AllowUserToOrderColumns = false;
         view.AllowUserToDeleteRows = false;
         view.ColumnHeadersDefaultCellStyle.BackColor = Color.LightPink;
         view.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
         foreach (DataGridViewColumn item in view.Columns)
         {
            item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         }
      }
   }
}
