using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MysqlPractice.Controller;

namespace MysqlPractice
{
   public partial class FrmMain : Form
   {
      private DBController DataBaseObject = new DBController();

      public FrmMain()
      {
         InitializeComponent();
      }
      #region 이벤트
      private void FrmMain_Load(object sender, EventArgs e)
      {
         // 메인 세팅
         this.ShowIcon = false;
         this.ControlBox = false;
         this.CenterToScreen();
         this.LblMainStatus.Text = null;
         this.LblMainStatus.TextAlign = ContentAlignment.MiddleCenter;
         this.WindowState = FormWindowState.Maximized;
         this.BackColor = Color.FromArgb(64, 64, 64);
         //콤보박스 세팅
         ComBoBoxSetting();
      }



      #endregion
      #region 버튼
      private void BtnOpen_Click(object sender, EventArgs e)
      {
         if (DataBaseObject.Open())
         {
            DBButtonConrol();
            LblMainStatus.Text = "데이터 베이스 열림";
            LblMainStatus.ForeColor = Color.YellowGreen;
         }
         else
         {
            LblMainStatus.Text = "데이터 베이스 닫힘";
            LblMainStatus.ForeColor = Color.Red;
         }
      }

     

      private void BtnClose_Click(object sender, EventArgs e)
      {
         DataBaseObject.Close();
         if (DrgMain.DataSource != null) DrgMain.DataSource = null;
         DBButtonConrol();
         LblMainStatus.Text = "데이터 베이스 닫힘";
         LblMainStatus.ForeColor = Color.Red;
      }

      private void BtnLoad_Click(object sender, EventArgs e)
      {
         try
         {
            if (DataBaseObject.IsDBOpen.Equals(true))
            {
               DrgMain.DataSource = null;
               
               DataTable dt = new DataTable();
               dt = DataBaseObject.SelectWhatIWant(CboMain.SelectedItem.ToString());
              
               DrgMain.DataSource = dt;
               LblMainStatus.Text = $"{CboMain.SelectedItem}";
               LblMainStatus.ForeColor = Color.YellowGreen;
               DataGridViewSetting();
            }
            else
            {
               LblMainStatus.Text = "DB부터 열어주세요";
               LblMainStatus.ForeColor = Color.Red;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"에러 : {ex}"); LblMainStatus.Text = "에러 발생";
            LblMainStatus.ForeColor = Color.Red;
         }
      }
      private void BtnClear_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      #endregion


      #region 메서드
      private void DBButtonConrol()
      {
         if (DataBaseObject.IsDBOpen.Equals(false))
         {
            BtnOpen.Enabled = false;
            BtnClose.Enabled = true;
            DataBaseObject.IsDBOpen = true;
         }
         else
         {
            BtnOpen.Enabled = true;
            BtnClose.Enabled = false;
            DataBaseObject.IsDBOpen = false;
         }
      }

      private void ComBoBoxSetting()
      {
         CboMain.Items.Add("customers");
         CboMain.Items.Add("employees");
         CboMain.Items.Add("offices");
         CboMain.Items.Add("orderdetails");
         CboMain.Items.Add("orders");
         CboMain.Items.Add("payments");
         CboMain.Items.Add("productlines");
         CboMain.Items.Add("products");
         CboMain.SelectedIndex = 0;
      }
      private void DataGridViewSetting()
      {
         DrgMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         DrgMain.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         DrgMain.AllowUserToAddRows = false;
         DrgMain.AllowUserToResizeRows = false;
         DrgMain.AllowUserToOrderColumns = false;
         DrgMain.AllowUserToDeleteRows = false;
         foreach (DataGridViewColumn item in DrgMain.Columns) {
            item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         }
      }
      #endregion
   }
}
