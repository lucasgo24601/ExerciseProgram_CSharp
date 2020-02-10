namespace WordBook
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    /// 
    partial class InclusionWords
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.btnTranslation = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(12, 12);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(760, 107);
            this.txtEnglish.TabIndex = 0;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChinese.Location = new System.Drawing.Point(3, 355);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(760, 107);
            this.txtChinese.TabIndex = 2;
            // 
            // btnTranslation
            // 
            this.btnTranslation.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTranslation.Location = new System.Drawing.Point(12, 165);
            this.btnTranslation.Name = "btnTranslation";
            this.btnTranslation.Size = new System.Drawing.Size(222, 150);
            this.btnTranslation.TabIndex = 3;
            this.btnTranslation.Text = "Translation";
            this.btnTranslation.UseVisualStyleBackColor = true;
            this.btnTranslation.Click += new System.EventHandler(this.btnTranslation_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(361, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 150);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InclusionWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTranslation);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtEnglish);
            this.Name = "InclusionWords";
            this.Size = new System.Drawing.Size(775, 642);
            this.Load += new System.EventHandler(this.InclusionWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnTranslation;
    }
}