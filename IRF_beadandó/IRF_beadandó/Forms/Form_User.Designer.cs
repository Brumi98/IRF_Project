
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
            this.lblFelhasznalo_Info = new System.Windows.Forms.Label();
            this.lblJelszo_Info = new System.Windows.Forms.Label();
            this.pictureBox_Felhasznalo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Jelszo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canditeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Felhasznalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Jelszo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSzavazas
            // 
            this.btnSzavazas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSzavazas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSzavazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzavazas.Location = new System.Drawing.Point(812, 279);
            this.btnSzavazas.Name = "btnSzavazas";
            this.btnSzavazas.Size = new System.Drawing.Size(263, 184);
            this.btnSzavazas.TabIndex = 0;
            this.btnSzavazas.Text = "Szavazok";
            this.btnSzavazas.UseVisualStyleBackColor = false;
            this.btnSzavazas.Click += new System.EventHandler(this.btnSzavazas_Click);
            // 
            // txtFelhasznalo
            // 
            this.txtFelhasznalo.Location = new System.Drawing.Point(209, 265);
            this.txtFelhasznalo.Multiline = true;
            this.txtFelhasznalo.Name = "txtFelhasznalo";
            this.txtFelhasznalo.Size = new System.Drawing.Size(100, 25);
            this.txtFelhasznalo.TabIndex = 1;
            // 
            // txtJelszo
            // 
            this.txtJelszo.Location = new System.Drawing.Point(209, 355);
            this.txtJelszo.Multiline = true;
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.Size = new System.Drawing.Size(100, 25);
            this.txtJelszo.TabIndex = 1;
            // 
            // cmbJelolt
            // 
            this.cmbJelolt.DataSource = this.canditeBindingSource;
            this.cmbJelolt.DisplayMember = "Jelöltek";
            this.cmbJelolt.FormattingEnabled = true;
            this.cmbJelolt.Location = new System.Drawing.Point(209, 442);
            this.cmbJelolt.Name = "cmbJelolt";
            this.cmbJelolt.Size = new System.Drawing.Size(100, 21);
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
            this.lblNev.Location = new System.Drawing.Point(76, 260);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(53, 24);
            this.lblNev.TabIndex = 3;
            this.lblNev.Text = "Név:";
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJelszo.Location = new System.Drawing.Point(76, 350);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(75, 24);
            this.lblJelszo.TabIndex = 3;
            this.lblJelszo.Text = "Jelszó:";
            // 
            // lblSzavazat
            // 
            this.lblSzavazat.AutoSize = true;
            this.lblSzavazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzavazat.Location = new System.Drawing.Point(76, 439);
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
            // lblFelhasznalo_Info
            // 
            this.lblFelhasznalo_Info.AutoSize = true;
            this.lblFelhasznalo_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblFelhasznalo_Info.Location = new System.Drawing.Point(340, 265);
            this.lblFelhasznalo_Info.Name = "lblFelhasznalo_Info";
            this.lblFelhasznalo_Info.Size = new System.Drawing.Size(202, 13);
            this.lblFelhasznalo_Info.TabIndex = 5;
            this.lblFelhasznalo_Info.Text = "Csak keresztnév, nagybetűvel kezdődjön!";
            this.lblFelhasznalo_Info.Visible = false;
            // 
            // lblJelszo_Info
            // 
            this.lblJelszo_Info.AutoSize = true;
            this.lblJelszo_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lblJelszo_Info.Location = new System.Drawing.Point(343, 355);
            this.lblJelszo_Info.Name = "lblJelszo_Info";
            this.lblJelszo_Info.Size = new System.Drawing.Size(391, 13);
            this.lblJelszo_Info.TabIndex = 6;
            this.lblJelszo_Info.Text = "A jelszónak tartalmaznia kell legalább egy nagy betűt, egy kis betűt és egy számo" +
    "t!";
            this.lblJelszo_Info.Visible = false;
            // 
            // pictureBox_Felhasznalo
            // 
            this.pictureBox_Felhasznalo.Image = global::IRF_beadandó.Properties.Resources.Info_Icon;
            this.pictureBox_Felhasznalo.Location = new System.Drawing.Point(315, 265);
            this.pictureBox_Felhasznalo.Name = "pictureBox_Felhasznalo";
            this.pictureBox_Felhasznalo.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Felhasznalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Felhasznalo.TabIndex = 7;
            this.pictureBox_Felhasznalo.TabStop = false;
            this.pictureBox_Felhasznalo.MouseEnter += new System.EventHandler(this.pictureBox_Felhasznalo_MouseEnter);
            this.pictureBox_Felhasznalo.MouseLeave += new System.EventHandler(this.pictureBox_Felhasznalo_MouseLeave);
            // 
            // pictureBox_Jelszo
            // 
            this.pictureBox_Jelszo.Image = global::IRF_beadandó.Properties.Resources.Info_Icon;
            this.pictureBox_Jelszo.Location = new System.Drawing.Point(315, 355);
            this.pictureBox_Jelszo.Name = "pictureBox_Jelszo";
            this.pictureBox_Jelszo.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Jelszo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Jelszo.TabIndex = 7;
            this.pictureBox_Jelszo.TabStop = false;
            this.pictureBox_Jelszo.MouseEnter += new System.EventHandler(this.pictureBox_Jelszo_MouseEnter);
            this.pictureBox_Jelszo.MouseLeave += new System.EventHandler(this.pictureBox_Jelszo_MouseLeave);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.pictureBox_Jelszo);
            this.Controls.Add(this.pictureBox_Felhasznalo);
            this.Controls.Add(this.lblJelszo_Info);
            this.Controls.Add(this.lblFelhasznalo_Info);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Felhasznalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Jelszo)).EndInit();
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
        private System.Windows.Forms.Label lblFelhasznalo_Info;
        private System.Windows.Forms.Label lblJelszo_Info;
        private System.Windows.Forms.PictureBox pictureBox_Felhasznalo;
        private System.Windows.Forms.PictureBox pictureBox_Jelszo;
    }
}