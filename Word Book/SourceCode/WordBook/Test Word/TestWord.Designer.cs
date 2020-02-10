namespace WordBook
{
    partial class TestWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblChineseTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(12, 12);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(731, 157);
            this.txtEnglish.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Location = new System.Drawing.Point(12, 297);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(181, 83);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblChineseTopic
            // 
            this.lblChineseTopic.AutoSize = true;
            this.lblChineseTopic.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChineseTopic.Location = new System.Drawing.Point(6, 220);
            this.lblChineseTopic.Name = "lblChineseTopic";
            this.lblChineseTopic.Size = new System.Drawing.Size(147, 32);
            this.lblChineseTopic.TabIndex = 4;
            this.lblChineseTopic.Text = "中文提示";
            // 
            // TestWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChineseTopic);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnglish);
            this.Name = "TestWord";
            this.Size = new System.Drawing.Size(775, 642);
            this.Load += new System.EventHandler(this.TestWord_Load);
            this.Leave += new System.EventHandler(this.TestWord_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblChineseTopic;
    }
}