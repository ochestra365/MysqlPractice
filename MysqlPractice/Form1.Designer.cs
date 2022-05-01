
namespace MysqlPractice
{
   partial class FrmMain
   {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent()
      {
         this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
         this.DrgMain = new System.Windows.Forms.DataGridView();
         this.TplMenu = new System.Windows.Forms.TableLayoutPanel();
         this.BtnClear = new System.Windows.Forms.Button();
         this.BtnLoad = new System.Windows.Forms.Button();
         this.BtnClose = new System.Windows.Forms.Button();
         this.BtnOpen = new System.Windows.Forms.Button();
         this.LblMainStatus = new System.Windows.Forms.Label();
         this.CboMain = new System.Windows.Forms.ComboBox();
         this.TlpMain.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DrgMain)).BeginInit();
         this.TplMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // TlpMain
         // 
         this.TlpMain.ColumnCount = 1;
         this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TlpMain.Controls.Add(this.DrgMain, 0, 1);
         this.TlpMain.Controls.Add(this.TplMenu, 0, 0);
         this.TlpMain.Controls.Add(this.LblMainStatus, 0, 2);
         this.TlpMain.Controls.Add(this.CboMain, 0, 3);
         this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TlpMain.Location = new System.Drawing.Point(0, 0);
         this.TlpMain.Name = "TlpMain";
         this.TlpMain.RowCount = 4;
         this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
         this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
         this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.183674F));
         this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.183674F));
         this.TlpMain.Size = new System.Drawing.Size(800, 450);
         this.TlpMain.TabIndex = 0;
         // 
         // DrgMain
         // 
         this.DrgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DrgMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.DrgMain.Location = new System.Drawing.Point(3, 94);
         this.DrgMain.Name = "DrgMain";
         this.DrgMain.RowTemplate.Height = 23;
         this.DrgMain.Size = new System.Drawing.Size(794, 269);
         this.DrgMain.TabIndex = 0;
         // 
         // TplMenu
         // 
         this.TplMenu.ColumnCount = 4;
         this.TplMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.TplMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.TplMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.TplMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.TplMenu.Controls.Add(this.BtnClear, 3, 0);
         this.TplMenu.Controls.Add(this.BtnLoad, 2, 0);
         this.TplMenu.Controls.Add(this.BtnClose, 1, 0);
         this.TplMenu.Controls.Add(this.BtnOpen, 0, 0);
         this.TplMenu.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TplMenu.Location = new System.Drawing.Point(3, 3);
         this.TplMenu.Name = "TplMenu";
         this.TplMenu.RowCount = 1;
         this.TplMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TplMenu.Size = new System.Drawing.Size(794, 85);
         this.TplMenu.TabIndex = 1;
         // 
         // BtnClear
         // 
         this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnClear.Location = new System.Drawing.Point(597, 3);
         this.BtnClear.Name = "BtnClear";
         this.BtnClear.Size = new System.Drawing.Size(194, 79);
         this.BtnClear.TabIndex = 3;
         this.BtnClear.Text = "닫기";
         this.BtnClear.UseVisualStyleBackColor = true;
         this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
         // 
         // BtnLoad
         // 
         this.BtnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnLoad.Location = new System.Drawing.Point(399, 3);
         this.BtnLoad.Name = "BtnLoad";
         this.BtnLoad.Size = new System.Drawing.Size(192, 79);
         this.BtnLoad.TabIndex = 2;
         this.BtnLoad.Text = "불러오기";
         this.BtnLoad.UseVisualStyleBackColor = true;
         this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
         // 
         // BtnClose
         // 
         this.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnClose.Location = new System.Drawing.Point(201, 3);
         this.BtnClose.Name = "BtnClose";
         this.BtnClose.Size = new System.Drawing.Size(192, 79);
         this.BtnClose.TabIndex = 1;
         this.BtnClose.Text = "데이터베이스 닫기";
         this.BtnClose.UseVisualStyleBackColor = true;
         this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
         // 
         // BtnOpen
         // 
         this.BtnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnOpen.Location = new System.Drawing.Point(3, 3);
         this.BtnOpen.Name = "BtnOpen";
         this.BtnOpen.Size = new System.Drawing.Size(192, 79);
         this.BtnOpen.TabIndex = 0;
         this.BtnOpen.Text = "데이터베이스 열기";
         this.BtnOpen.UseVisualStyleBackColor = true;
         this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
         // 
         // LblMainStatus
         // 
         this.LblMainStatus.AutoSize = true;
         this.LblMainStatus.Dock = System.Windows.Forms.DockStyle.Fill;
         this.LblMainStatus.Location = new System.Drawing.Point(3, 366);
         this.LblMainStatus.Name = "LblMainStatus";
         this.LblMainStatus.Size = new System.Drawing.Size(794, 41);
         this.LblMainStatus.TabIndex = 2;
         this.LblMainStatus.Text = "상태라벨";
         this.LblMainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // CboMain
         // 
         this.CboMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.CboMain.FormattingEnabled = true;
         this.CboMain.Location = new System.Drawing.Point(3, 410);
         this.CboMain.Name = "CboMain";
         this.CboMain.Size = new System.Drawing.Size(794, 20);
         this.CboMain.TabIndex = 3;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.TlpMain);
         this.Name = "FrmMain";
         this.Text = "데이터베이스 연습장";
         this.Load += new System.EventHandler(this.FrmMain_Load);
         this.TlpMain.ResumeLayout(false);
         this.TlpMain.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DrgMain)).EndInit();
         this.TplMenu.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel TlpMain;
      private System.Windows.Forms.DataGridView DrgMain;
      private System.Windows.Forms.TableLayoutPanel TplMenu;
      private System.Windows.Forms.Button BtnClear;
      private System.Windows.Forms.Button BtnLoad;
      private System.Windows.Forms.Button BtnClose;
      private System.Windows.Forms.Button BtnOpen;
      private System.Windows.Forms.Label LblMainStatus;
      private System.Windows.Forms.ComboBox CboMain;
   }
}

