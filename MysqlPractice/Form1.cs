using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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
         this.LblMainStatus.Text = null;
         this.LblMainStatus.TextAlign = ContentAlignment.MiddleCenter;
         this.WindowState = FormWindowState.Maximized;
         this.BackColor = Color.FromArgb(64, 64, 64);
         //콤보박스 세팅
         UIController.ComBoBoxSetting(CboMain);

         //버튼 세팅
         UIController.ButtonSetting(BtnClear);
         UIController.ButtonSetting(BtnOpen);
         UIController.ButtonSetting(BtnClose);
         UIController.ButtonSetting(BtnLoad);
      }

      #endregion
      #region 버튼
      private void BtnOpen_Click(object sender, EventArgs e)
      {
         if (DataBaseObject.Open())
         {
            DBButtonConrol();
            this.BtnLoad.Show();
            this.CboMain.Show();
            LblMainStatus.Text = "데이터 베이스 열림";
            LblMainStatus.ForeColor = Color.YellowGreen;
            LblMainStatus.Font = new Font("Calibri", 30, FontStyle.Bold);
         }
         else
         {
            LblMainStatus.Text = "데이터 베이스 닫힘";
            LblMainStatus.ForeColor = Color.Red;
            LblMainStatus.Font = new Font("Calibri", 30, FontStyle.Bold);
            LblMainStatus.Font = new Font("Calibri", 30, FontStyle.Bold);
         }
      }
      private void BtnClose_Click(object sender, EventArgs e)
      {
         if (DataBaseObject.IsDBOpen.Equals(false)) MessageBox.Show("DB를 열어주세요");
         else
         {
            DataBaseObject.Close();
            this.BtnLoad.Hide();
            this.CboMain.Hide();
            if (DrgMain.DataSource != null) DrgMain.DataSource = null;
            DBButtonConrol();
            LblMainStatus.Text = "데이터 베이스 닫힘";
            LblMainStatus.ForeColor = Color.Red;
            LblMainStatus.Font = new Font("Calibri", 30, FontStyle.Bold);
         }
      }
      private void BtnLoad_Click(object sender, EventArgs e)
      {
         try
         {
            if (DataBaseObject.IsDBOpen.Equals(true))
            {
               DrgMain.DataSource = null;

               DataTable dt = new DataTable();
               if (String.IsNullOrEmpty(CboMain.SelectedItem.ToString())) MessageBox.Show("불러올 정보를 선택해주세요");
               else dt = DataBaseObject.SelectWhatIWant(CboMain.SelectedItem.ToString());
               DrgMain.DataSource = dt;
               LblMainStatus.Text = $"{CboMain.SelectedItem}";
               LblMainStatus.ForeColor = Color.YellowGreen;
               LblMainStatus.Font = new Font("Calibri", 30, FontStyle.Bold);
               UIController.DataGridViewSetting(DrgMain);
            }
            else
            {
               LblMainStatus.Text = "DB부터 열어주세요";
               LblMainStatus.ForeColor = Color.Red;
               LblMainStatus.Font = new Font("Calibri", 30, FontStyle.Bold);
            }
         }
         catch (NullReferenceException) { MessageBox.Show("불러올 정보를 선택해주세요"); }
         catch (Exception ex)
         {
            LblMainStatus.Text = "에러 발생";
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
      #endregion
   }
}
