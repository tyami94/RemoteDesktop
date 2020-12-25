namespace WindowsFormsApp2
{
    partial class mainFrm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.winDBtn = new System.Windows.Forms.Button();
            this.taskmgrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(0, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(147, 246);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hideBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.ForeColor = System.Drawing.Color.White;
            this.hideBtn.Location = new System.Drawing.Point(279, 0);
            this.hideBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(147, 246);
            this.hideBtn.TabIndex = 1;
            this.hideBtn.Text = "Show Desktop";
            this.hideBtn.UseVisualStyleBackColor = false;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // winDBtn
            // 
            this.winDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.winDBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.winDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winDBtn.ForeColor = System.Drawing.Color.White;
            this.winDBtn.Location = new System.Drawing.Point(147, 0);
            this.winDBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.winDBtn.Name = "winDBtn";
            this.winDBtn.Size = new System.Drawing.Size(133, 123);
            this.winDBtn.TabIndex = 2;
            this.winDBtn.Text = "Win+D";
            this.winDBtn.UseVisualStyleBackColor = false;
            // 
            // taskmgrBtn
            // 
            this.taskmgrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.taskmgrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskmgrBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.taskmgrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskmgrBtn.ForeColor = System.Drawing.Color.White;
            this.taskmgrBtn.Location = new System.Drawing.Point(147, 123);
            this.taskmgrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.taskmgrBtn.Name = "taskmgrBtn";
            this.taskmgrBtn.Size = new System.Drawing.Size(133, 123);
            this.taskmgrBtn.TabIndex = 3;
            this.taskmgrBtn.Text = "Taskmgr";
            this.taskmgrBtn.UseVisualStyleBackColor = false;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(427, 246);
            this.Controls.Add(this.taskmgrBtn);
            this.Controls.Add(this.winDBtn);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.exitBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 20);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(427, 246);
            this.Name = "mainFrm";
            this.Opacity = 0.8D;
            this.Text = "Remote Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Button winDBtn;
        private System.Windows.Forms.Button taskmgrBtn;
    }
}

