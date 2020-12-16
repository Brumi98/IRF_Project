
namespace IRF_beadandó.Forms
{
    partial class Form_User
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
            this.components = new System.ComponentModel.Container();
            this.btnSzavazas = new System.Windows.Forms.Button();
            this.txtFelhasznalo = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.cmbJelolt = new System.Windows.Forms.ComboBox();
            this.canditeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.lblSzavazat = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnKijelentkezes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canditeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSzavazas
            // 
            this.btnSzavazas.Location = new System.Drawing.Point(701, 279);
            this.btnSzavazas.Name = "btnSzavazas";
            this.btnSzavazas.Size = new System.Drawing.Size(263, 184);
            this.btnSzavazas.TabIndex = 0;
            this.btnSzavazas.Text = "Szavazok";
            this.btnSzavazas.UseVisualStyleBackColor = true;
            this.btnSzavazas.Click += new System.EventHandler(this.btnSzavazas_Click);
            // 
            // txtFelhasznalo
            // 
            this.txtFelhasznalo.Location = new System.Drawing.Point(272, 265);
            this.txtFelhasznalo.Name = "txtFelhasznalo";
            this.txtFelhasznalo.Size = new System.Drawing.Size(100, 20);
            this.txtFelhasznalo.TabIndex = 1;
            // 
            // txtJelszo
            // 
            this.txtJelszo.Location = new System.Drawing.Point(272, 355);
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.Size = new System.Drawing.Size(100, 20);
            this.txtJelszo.TabIndex = 1;
            // 
            // cmbJelolt
            // 
            this.cmbJelolt.DataSource = this.canditeBindingSource;
            this.cmbJelolt.DisplayMember = "Jelöltek";
            this.cmbJelolt.FormattingEnabled = true;
            this.cmbJelolt.Location = new System.Drawing.Point(272, 442);
            this.cmbJelolt.Name = "cmbJelolt";
            this.cmbJelolt.Size = new System.Drawing.Size(121, 21);
            this.cmbJelolt.TabIndex = 2;
            this.cmbJelolt.ValueMember = "Candites_ID";
            // 
            // canditeBindingSource
            // 
            this.canditeBindingSource.DataSource = typeof(IRF_beadandó.Candite);
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(139, 260);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(53, 24);
            this.lblNev.TabIndex = 3;
            this.lblNev.Text = "Név:";
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJelszo.Location = new System.Drawing.Point(139, 350);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(75, 24);
            this.lblJelszo.TabIndex = 3;
            this.lblJelszo.Text = "Jelszó:";
            // 
            // lblSzavazat
            // 
            this.lblSzavazat.AutoSize = true;
            this.lblSzavazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzavazat.Location = new System.Drawing.Point(139, 439);
            this.lblSzavazat.Name = "lblSzavazat";
            this.lblSzavazat.Size = new System.Drawing.Size(97, 24);
            this.lblSzavazat.TabIndex = 3;
            this.lblSzavazat.Text = "Szavazat:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(IRF_beadandó.User);
            // 
            // btnKijelentkezes
            // 
            this.btnKijelentkezes.Location = new System.Drawing.Point(1025, 12);
            this.btnKijelentkezes.Name = "btnKijelentkezes";
            this.btnKijelentkezes.Size = new System.Drawing.Size(97, 47);
            this.btnKijelentkezes.TabIndex = 4;
            this.btnKijelentkezes.Text = "Kijelentkezés";
            this.btnKijelentkezes.UseVisualStyleBackColor = true;
            this.btnKijelentkezes.Click += new System.EventHandler(this.btnKijelentkezes_Click);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.btnKijelentkezes);
            this.Controls.Add(this.lblSzavazat);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.cmbJelolt);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.txtFelhasznalo);
            this.Controls.Add(this.btnSzavazas);
            this.MaximumSize = new System.Drawing.Size(1150, 700);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "Form_User";
            this.Text = "Form_User";
            ((System.ComponentModel.ISupportInitialize)(this.canditeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzavazas;
        private System.Windows.Forms.TextBox txtFelhasznalo;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.ComboBox cmbJelolt;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Label lblSzavazat;
        private System.Windows.Forms.BindingSource canditeBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnKijelentkezes;
    }
}