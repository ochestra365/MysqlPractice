using System.Drawing;
using System.Windows.Forms;

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
         if (_button.Name.Equals("BtnLoad")) _button.Hide();
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
      internal static  void ComBoBoxSetting(ComboBox combo)
      {
         combo.Items.Add("customers");
         combo.Items.Add("employees");
         combo.Items.Add("offices");
         combo.Items.Add("orderdetails");
         combo.Items.Add("orders");
         combo.Items.Add("payments");
         combo.Items.Add("productlines");
         combo.Items.Add("products");
         combo.SelectedIndex = 0;
         combo.Hide();
      }
   }
}
