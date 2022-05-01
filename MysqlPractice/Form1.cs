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
         this.ShowIcon = false;
         this.ControlBox = false;
         this.CenterToScreen();
         this.LblMainStatus.Text = null;
         this.LblMainStatus.TextAlign = ContentAlignment.MiddleCenter;
         this.Size = new Size(500, 350);

         //콤보박스 세팅
         ComBoBoxSetting();

         //데이터그리드뷰 세팅
         DataGridViewSetting();
      }



      #endregion
      #region 버튼
      private void BtnOpen_Click(object sender, EventArgs e)
      {
         if (DataBaseObject.Open())
         {
            MessageBox.Show("DB 열림");
            DBButtonConrol();
            
         }
         else
         {
            MessageBox.Show("DB 닫힘");
         }
      }

     

      private void BtnClose_Click(object sender, EventArgs e)
      {
         DataBaseObject.Close();
         DBButtonConrol();
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
            }
            else
            {
               MessageBox.Show("DB부터 열어주세요");
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"에러 : {ex}");
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
