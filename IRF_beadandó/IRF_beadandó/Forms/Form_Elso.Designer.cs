
namespace IRF_beadandó.Forms
{
    partial class Form_Elso
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSzavaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(226, 467);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 75);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Belépek";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSzavaz
            // 
            this.btnSzavaz.Location = new System.Drawing.Point(788, 467);
            this.btnSzavaz.Name = "btnSzavaz";
            this.btnSzavaz.Size = new System.Drawing.Size(136, 75);
            this.btnSzavaz.TabIndex = 0;
            this.btnSzavaz.Text = "Szavazok";
            this.btnSzavaz.UseVisualStyleBackColor = true;
            this.btnSzavaz.Click += new System.EventHandler(this.btnSzavaz_Click);
            // 
            // Form_Elso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.btnSzavaz);
            this.Controls.Add(this.btnLogin);
            this.MaximumSize = new System.Drawing.Size(1150, 700);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "Form_Elso";
            this.Text = "Form_Elso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSzavaz;
    }
}