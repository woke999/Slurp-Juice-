
namespace Slurp_Juice_.Forms.Controls
{
    partial class Theme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slurpThemeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.blackThemeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // slurpThemeBtn
            // 
            this.slurpThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.slurpThemeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.slurpThemeBtn.CheckedState.Parent = this.slurpThemeBtn;
            this.slurpThemeBtn.CustomImages.Parent = this.slurpThemeBtn;
            this.slurpThemeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.slurpThemeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.slurpThemeBtn.ForeColor = System.Drawing.Color.White;
            this.slurpThemeBtn.HoverState.Parent = this.slurpThemeBtn;
            this.slurpThemeBtn.Location = new System.Drawing.Point(3, 0);
            this.slurpThemeBtn.Name = "slurpThemeBtn";
            this.slurpThemeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.slurpThemeBtn.ShadowDecoration.Parent = this.slurpThemeBtn;
            this.slurpThemeBtn.Size = new System.Drawing.Size(130, 48);
            this.slurpThemeBtn.TabIndex = 1;
            this.slurpThemeBtn.Text = "Slurp Juice Theme";
            this.slurpThemeBtn.Click += new System.EventHandler(this.slurpThemeBtn_Click);
            // 
            // blackThemeBtn
            // 
            this.blackThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blackThemeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blackThemeBtn.CheckedState.Parent = this.blackThemeBtn;
            this.blackThemeBtn.CustomImages.Parent = this.blackThemeBtn;
            this.blackThemeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blackThemeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blackThemeBtn.ForeColor = System.Drawing.Color.White;
            this.blackThemeBtn.HoverState.Parent = this.blackThemeBtn;
            this.blackThemeBtn.Location = new System.Drawing.Point(139, 0);
            this.blackThemeBtn.Name = "blackThemeBtn";
            this.blackThemeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blackThemeBtn.ShadowDecoration.Parent = this.blackThemeBtn;
            this.blackThemeBtn.Size = new System.Drawing.Size(130, 48);
            this.blackThemeBtn.TabIndex = 2;
            this.blackThemeBtn.Text = "Black Theme";
            this.blackThemeBtn.Click += new System.EventHandler(this.blackThemeBtn_Click);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.blackThemeBtn);
            this.Controls.Add(this.slurpThemeBtn);
            this.Name = "Theme";
            this.Size = new System.Drawing.Size(769, 443);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button slurpThemeBtn;
        public Guna.UI2.WinForms.Guna2Button blackThemeBtn;
    }
}
