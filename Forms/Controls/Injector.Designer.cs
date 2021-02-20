
namespace Slurp_Juice_.Forms.Controls
{
    partial class Injector
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.attachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.injectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.openBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(763, 383);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // attachBtn
            // 
            this.attachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.attachBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.attachBtn.CheckedState.Parent = this.attachBtn;
            this.attachBtn.CustomImages.Parent = this.attachBtn;
            this.attachBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.attachBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.attachBtn.ForeColor = System.Drawing.Color.White;
            this.attachBtn.HoverState.Parent = this.attachBtn;
            this.attachBtn.Location = new System.Drawing.Point(0, 392);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.attachBtn.ShadowDecoration.Parent = this.attachBtn;
            this.attachBtn.Size = new System.Drawing.Size(130, 48);
            this.attachBtn.TabIndex = 3;
            this.attachBtn.Text = "Attach";
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // injectBtn
            // 
            this.injectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.injectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.injectBtn.CheckedState.Parent = this.injectBtn;
            this.injectBtn.CustomImages.Parent = this.injectBtn;
            this.injectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.injectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.injectBtn.ForeColor = System.Drawing.Color.White;
            this.injectBtn.HoverState.Parent = this.injectBtn;
            this.injectBtn.Location = new System.Drawing.Point(272, 392);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.injectBtn.ShadowDecoration.Parent = this.injectBtn;
            this.injectBtn.Size = new System.Drawing.Size(130, 48);
            this.injectBtn.TabIndex = 4;
            this.injectBtn.Text = "Inject";
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.openBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.openBtn.CheckedState.Parent = this.openBtn;
            this.openBtn.CustomImages.Parent = this.openBtn;
            this.openBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.openBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.HoverState.Parent = this.openBtn;
            this.openBtn.Location = new System.Drawing.Point(136, 392);
            this.openBtn.Name = "openBtn";
            this.openBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.openBtn.ShadowDecoration.Parent = this.openBtn;
            this.openBtn.Size = new System.Drawing.Size(130, 48);
            this.openBtn.TabIndex = 5;
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // Injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.webBrowser1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "Injector";
            this.Size = new System.Drawing.Size(769, 443);
            this.Load += new System.EventHandler(this.Injector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button attachBtn;
        private Guna.UI2.WinForms.Guna2Button injectBtn;
        private Guna.UI2.WinForms.Guna2Button openBtn;
    }
}
