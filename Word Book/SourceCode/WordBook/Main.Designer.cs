namespace WordBook
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLanguage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStatistics = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWordBook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMinimized = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblNowPage = new System.Windows.Forms.Label();
            this.lblTipNowPage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnLanguage);
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 730);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanguage.BorderRadius = 0;
            this.btnLanguage.ButtonText = "Language";
            this.btnLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguage.DisabledColor = System.Drawing.Color.Gray;
            this.btnLanguage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLanguage.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLanguage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLanguage.Iconimage")));
            this.btnLanguage.Iconimage_right = null;
            this.btnLanguage.Iconimage_right_Selected = null;
            this.btnLanguage.Iconimage_Selected = null;
            this.btnLanguage.IconMarginLeft = 0;
            this.btnLanguage.IconMarginRight = 0;
            this.btnLanguage.IconRightVisible = true;
            this.btnLanguage.IconRightZoom = 0D;
            this.btnLanguage.IconVisible = true;
            this.btnLanguage.IconZoom = 0D;
            this.btnLanguage.IsTab = false;
            this.btnLanguage.Location = new System.Drawing.Point(0, 630);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnLanguage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
            this.btnLanguage.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLanguage.selected = false;
            this.btnLanguage.Size = new System.Drawing.Size(233, 100);
            this.btnLanguage.TabIndex = 7;
            this.btnLanguage.Text = "Language";
            this.btnLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLanguage.Textcolor = System.Drawing.Color.White;
            this.btnLanguage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnLanguage.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistics.BorderRadius = 0;
            this.btnStatistics.ButtonText = "Statistics";
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatistics.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Iconimage")));
            this.btnStatistics.Iconimage_right = null;
            this.btnStatistics.Iconimage_right_Selected = null;
            this.btnStatistics.Iconimage_Selected = null;
            this.btnStatistics.IconMarginLeft = 0;
            this.btnStatistics.IconMarginRight = 0;
            this.btnStatistics.IconRightVisible = true;
            this.btnStatistics.IconRightZoom = 0D;
            this.btnStatistics.IconVisible = true;
            this.btnStatistics.IconZoom = 0D;
            this.btnStatistics.IsTab = false;
            this.btnStatistics.Location = new System.Drawing.Point(0, 288);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnStatistics.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
            this.btnStatistics.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnStatistics.selected = false;
            this.btnStatistics.Size = new System.Drawing.Size(233, 100);
            this.btnStatistics.TabIndex = 6;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistics.Textcolor = System.Drawing.Color.White;
            this.btnStatistics.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnTest
            // 
            this.btnTest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTest.BorderRadius = 0;
            this.btnTest.ButtonText = "Test";
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.DisabledColor = System.Drawing.Color.Gray;
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTest.Iconimage")));
            this.btnTest.Iconimage_right = null;
            this.btnTest.Iconimage_right_Selected = null;
            this.btnTest.Iconimage_Selected = null;
            this.btnTest.IconMarginLeft = 0;
            this.btnTest.IconMarginRight = 0;
            this.btnTest.IconRightVisible = true;
            this.btnTest.IconRightZoom = 0D;
            this.btnTest.IconVisible = true;
            this.btnTest.IconZoom = 0D;
            this.btnTest.IsTab = false;
            this.btnTest.Location = new System.Drawing.Point(0, 188);
            this.btnTest.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.btnTest.Name = "btnTest";
            this.btnTest.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnTest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
            this.btnTest.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnTest.selected = false;
            this.btnTest.Size = new System.Drawing.Size(233, 100);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTest.Textcolor = System.Drawing.Color.White;
            this.btnTest.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.BorderRadius = 0;
            this.btnEnter.ButtonText = "Enter";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnter.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnter.Iconimage")));
            this.btnEnter.Iconimage_right = null;
            this.btnEnter.Iconimage_right_Selected = null;
            this.btnEnter.Iconimage_Selected = null;
            this.btnEnter.IconMarginLeft = 0;
            this.btnEnter.IconMarginRight = 0;
            this.btnEnter.IconRightVisible = true;
            this.btnEnter.IconRightZoom = 0D;
            this.btnEnter.IconVisible = true;
            this.btnEnter.IconZoom = 0D;
            this.btnEnter.IsTab = false;
            this.btnEnter.Location = new System.Drawing.Point(0, 88);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnEnter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(233, 100);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnter.Textcolor = System.Drawing.Color.White;
            this.btnEnter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.lblWordBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 88);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // lblWordBook
            // 
            this.lblWordBook.AutoSize = true;
            this.lblWordBook.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWordBook.ForeColor = System.Drawing.Color.White;
            this.lblWordBook.Location = new System.Drawing.Point(37, 21);
            this.lblWordBook.Name = "lblWordBook";
            this.lblWordBook.Size = new System.Drawing.Size(169, 37);
            this.lblWordBook.TabIndex = 0;
            this.lblWordBook.Text = "WordBook";
            this.lblWordBook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.lblWordBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.lblWordBook.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picMinimized);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Controls.Add(this.lblNowPage);
            this.panel2.Controls.Add(this.lblTipNowPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 88);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // picMinimized
            // 
            this.picMinimized.Image = ((System.Drawing.Image)(resources.GetObject("picMinimized.Image")));
            this.picMinimized.Location = new System.Drawing.Point(675, 12);
            this.picMinimized.Name = "picMinimized";
            this.picMinimized.Size = new System.Drawing.Size(36, 36);
            this.picMinimized.TabIndex = 3;
            this.picMinimized.TabStop = false;
            this.picMinimized.Click += new System.EventHandler(this.picMinimized_Click);
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(727, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(36, 36);
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblNowPage
            // 
            this.lblNowPage.AutoSize = true;
            this.lblNowPage.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.lblNowPage.Location = new System.Drawing.Point(239, 21);
            this.lblNowPage.Name = "lblNowPage";
            this.lblNowPage.Size = new System.Drawing.Size(189, 41);
            this.lblNowPage.TabIndex = 1;
            this.lblNowPage.Text = "Temp Page";
            this.lblNowPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.lblNowPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.lblNowPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // lblTipNowPage
            // 
            this.lblTipNowPage.AutoSize = true;
            this.lblTipNowPage.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipNowPage.Location = new System.Drawing.Point(6, 21);
            this.lblTipNowPage.Name = "lblTipNowPage";
            this.lblTipNowPage.Size = new System.Drawing.Size(227, 41);
            this.lblTipNowPage.TabIndex = 0;
            this.lblTipNowPage.Text = "Now Page : ";
            this.lblTipNowPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.lblTipNowPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.lblTipNowPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(233, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 642);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAllPanel_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWordBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatistics;
        private Bunifu.Framework.UI.BunifuFlatButton btnTest;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
        private System.Windows.Forms.Label lblNowPage;
        private System.Windows.Forms.Label lblTipNowPage;
        private System.Windows.Forms.PictureBox picMinimized;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnLanguage;
    }
}

