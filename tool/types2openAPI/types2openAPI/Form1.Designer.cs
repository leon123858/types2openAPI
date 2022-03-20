
namespace types2openAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertBtn = new System.Windows.Forms.Button();
            this.origin = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(193, 320);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(391, 79);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // origin
            // 
            this.origin.Location = new System.Drawing.Point(23, 103);
            this.origin.Multiline = true;
            this.origin.Name = "origin";
            this.origin.PlaceholderText = "put types in it";
            this.origin.Size = new System.Drawing.Size(354, 192);
            this.origin.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(230, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 32);
            this.title.TabIndex = 2;
            this.title.Text = "convert type to openAPI";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(399, 103);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(380, 192);
            this.result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.title);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.convertBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox origin;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox result;
    }
}

