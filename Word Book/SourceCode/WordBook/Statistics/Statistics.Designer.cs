namespace WordBook {
    partial class Statistics {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Statistics));
            this.lvWords = new System.Windows.Forms.ListView ();
            this.colEnglish = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.colChinese = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.colCount = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.colSuccess = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.colTestCount = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.CirPrgSuccessRate = new Bunifu.Framework.UI.BunifuCircleProgressbar ();
            this.CirPrgFailRate = new Bunifu.Framework.UI.BunifuCircleProgressbar ();
            this.label1 = new System.Windows.Forms.Label ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.CirPrgHitRate = new Bunifu.Framework.UI.BunifuCircleProgressbar ();
            this.SuspendLayout ();
            // 
            // lvWords
            // 
            this.lvWords.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvWords.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
                this.colEnglish,
                    this.colChinese,
                    this.colCount,
                    this.colSuccess,
                    this.colTestCount
            });
            this.lvWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvWords.Font = new System.Drawing.Font ("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (136)));
            this.lvWords.GridLines = true;
            this.lvWords.Location = new System.Drawing.Point (0, 0);
            this.lvWords.Name = "lvWords";
            this.lvWords.Size = new System.Drawing.Size (775, 194);
            this.lvWords.TabIndex = 51;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            this.lvWords.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler (this.lvWords_ColumnClick);
            this.lvWords.ItemActivate += new System.EventHandler (this.lvWords_ItemActivate);
            // 
            // colEnglish
            // 
            this.colEnglish.Text = "English";
            this.colEnglish.Width = 207;
            // 
            // colChinese
            // 
            this.colChinese.Text = "Chinese";
            this.colChinese.Width = 229;
            // 
            // colCount
            // 
            this.colCount.Text = "Count";
            this.colCount.Width = 102;
            // 
            // colSuccess
            // 
            this.colSuccess.Text = "Success";
            this.colSuccess.Width = 110;
            // 
            // colTestCount
            // 
            this.colTestCount.Text = "Test Count";
            this.colTestCount.Width = 116;
            // 
            // CirPrgSuccessRate
            // 
            this.CirPrgSuccessRate.animated = false;
            this.CirPrgSuccessRate.animationIterval = 5;
            this.CirPrgSuccessRate.animationSpeed = 300;
            this.CirPrgSuccessRate.BackColor = System.Drawing.Color.White;
            this.CirPrgSuccessRate.BackgroundImage = ((System.Drawing.Image) (resources.GetObject ("CirPrgSuccessRate.BackgroundImage")));
            this.CirPrgSuccessRate.Font = new System.Drawing.Font ("Microsoft Sans Serif", 26.25F);
            this.CirPrgSuccessRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.CirPrgSuccessRate.LabelVisible = true;
            this.CirPrgSuccessRate.LineProgressThickness = 8;
            this.CirPrgSuccessRate.LineThickness = 5;
            this.CirPrgSuccessRate.Location = new System.Drawing.Point (21, 280);
            this.CirPrgSuccessRate.Margin = new System.Windows.Forms.Padding (10, 9, 10, 9);
            this.CirPrgSuccessRate.MaxValue = 100;
            this.CirPrgSuccessRate.Name = "CirPrgSuccessRate";
            this.CirPrgSuccessRate.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CirPrgSuccessRate.ProgressColor = System.Drawing.Color.Green;
            this.CirPrgSuccessRate.Size = new System.Drawing.Size (143, 143);
            this.CirPrgSuccessRate.TabIndex = 52;
            this.CirPrgSuccessRate.Value = 0;
            // 
            // CirPrgFailRate
            // 
            this.CirPrgFailRate.animated = false;
            this.CirPrgFailRate.animationIterval = 5;
            this.CirPrgFailRate.animationSpeed = 300;
            this.CirPrgFailRate.BackColor = System.Drawing.Color.White;
            this.CirPrgFailRate.BackgroundImage = ((System.Drawing.Image) (resources.GetObject ("CirPrgFailRate.BackgroundImage")));
            this.CirPrgFailRate.Font = new System.Drawing.Font ("Microsoft Sans Serif", 26.25F);
            this.CirPrgFailRate.ForeColor = System.Drawing.Color.Red;
            this.CirPrgFailRate.LabelVisible = true;
            this.CirPrgFailRate.LineProgressThickness = 8;
            this.CirPrgFailRate.LineThickness = 5;
            this.CirPrgFailRate.Location = new System.Drawing.Point (285, 280);
            this.CirPrgFailRate.Margin = new System.Windows.Forms.Padding (10, 9, 10, 9);
            this.CirPrgFailRate.MaxValue = 100;
            this.CirPrgFailRate.Name = "CirPrgFailRate";
            this.CirPrgFailRate.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CirPrgFailRate.ProgressColor = System.Drawing.Color.Red;
            this.CirPrgFailRate.Size = new System.Drawing.Size (143, 143);
            this.CirPrgFailRate.TabIndex = 53;
            this.CirPrgFailRate.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (136)));
            this.label1.Location = new System.Drawing.Point (17, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (151, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Success Rates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (136)));
            this.label2.Location = new System.Drawing.Point (281, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (111, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fail Rates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font ("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (136)));
            this.label3.Location = new System.Drawing.Point (530, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (103, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "Hit Rates";
            // 
            // CirPrgHitRate
            // 
            this.CirPrgHitRate.animated = false;
            this.CirPrgHitRate.animationIterval = 5;
            this.CirPrgHitRate.animationSpeed = 300;
            this.CirPrgHitRate.BackColor = System.Drawing.Color.White;
            this.CirPrgHitRate.BackgroundImage = ((System.Drawing.Image) (resources.GetObject ("CirPrgHitRate.BackgroundImage")));
            this.CirPrgHitRate.Font = new System.Drawing.Font ("Microsoft Sans Serif", 26.25F);
            this.CirPrgHitRate.ForeColor = System.Drawing.Color.Goldenrod;
            this.CirPrgHitRate.LabelVisible = true;
            this.CirPrgHitRate.LineProgressThickness = 8;
            this.CirPrgHitRate.LineThickness = 5;
            this.CirPrgHitRate.Location = new System.Drawing.Point (534, 280);
            this.CirPrgHitRate.Margin = new System.Windows.Forms.Padding (10, 9, 10, 9);
            this.CirPrgHitRate.MaxValue = 100;
            this.CirPrgHitRate.Name = "CirPrgHitRate";
            this.CirPrgHitRate.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CirPrgHitRate.ProgressColor = System.Drawing.Color.Goldenrod;
            this.CirPrgHitRate.Size = new System.Drawing.Size (143, 143);
            this.CirPrgHitRate.TabIndex = 59;
            this.CirPrgHitRate.Value = 0;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add (this.label3);
            this.Controls.Add (this.CirPrgHitRate);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.CirPrgFailRate);
            this.Controls.Add (this.CirPrgSuccessRate);
            this.Controls.Add (this.lvWords);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size (775, 642);
            this.Load += new System.EventHandler (this.Statistics_Load);
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion
        private System.Windows.Forms.ListView lvWords;
        private System.Windows.Forms.ColumnHeader colEnglish;
        private System.Windows.Forms.ColumnHeader colChinese;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colSuccess;
        private System.Windows.Forms.ColumnHeader colTestCount;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CirPrgSuccessRate;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CirPrgFailRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CirPrgHitRate;
    }
}