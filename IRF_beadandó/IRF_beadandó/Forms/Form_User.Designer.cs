
namespace IRF_beadandó
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
            this.txtFelhasznalo = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.lblSzavazat = new System.Windows.Forms.Label();
            this.cmbJelolt = new System.Windows.Forms.ComboBox();
            this.canditeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSzavazas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canditeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFelhasznalo
            // 
            this.txtFelhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFelhasznalo.Location = new System.Drawing.Point(379, 177);
            this.txtFelhasznalo.Multiline = true;
            this.txtFelhasznalo.Name = "txtFelhasznalo";
            this.txtFelhasznalo.Size = new System.Drawing.Size(224, 50);
            this.txtFelhasznalo.TabIndex = 0;
            this.txtFelhasznalo.TextChanged += new System.EventHandler(this.txtFelhasznalo_TextChanged);
            this.txtFelhasznalo.Validating += new System.ComponentModel.CancelEventHandler(this.txtFelhasznalo_Validating);
            // 
            // txtJelszo
            // 
            this.txtJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtJelszo.Location = new System.Drawing.Point(379, 284);
            this.txtJelszo.Multiline = true;
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.Size = new System.Drawing.Size(224, 51);
            this.txtJelszo.TabIndex = 0;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.lblNev.Location = new System.Drawing.Point(102, 191);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(68, 36);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "Név";
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.lblJelszo.Location = new System.Drawing.Point(102, 299);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(100, 36);
            this.lblJelszo.TabIndex = 1;
            this.lblJelszo.Text = "Jelszó";
            // 
            // lblSzavazat
            // 
            this.lblSzavazat.AutoSize = true;
            this.lblSzavazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.lblSzavazat.Location = new System.Drawing.Point(102, 398);
            this.lblSzavazat.Name = "lblSzavazat";
            this.lblSzavazat.Size = new System.Drawing.Size(136, 36);
            this.lblSzavazat.TabIndex = 1;
            this.lblSzavazat.Text = "Szavazat";
            // 
            // cmbJelolt
            // 
            this.cmbJelolt.DataSource = this.canditeBindingSource;
            this.cmbJelolt.DisplayMember = "Jelöltek";
            this.cmbJelolt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJelolt.FormattingEnabled = true;
            this.cmbJelolt.Location = new System.Drawing.Point(379, 413);
            this.cmbJelolt.Name = "cmbJelolt";
            this.cmbJelolt.Size = new System.Drawing.Size(224, 21);
            this.cmbJelolt.TabIndex = 2;
            this.cmbJelolt.ValueMember = "Candites_ID";
            // 
            // canditeBindingSource
            // 
            this.canditeBindingSource.DataSource = typeof(IRF_beadandó.Candite);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(IRF_beadandó.User);
            // 
            // btnSzavazas
            // 
            this.btnSzavazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSzavazas.Location = new System.Drawing.Point(754, 413);
            this.btnSzavazas.Name = "btnSzavazas";
            this.btnSzavazas.Size = new System.Drawing.Size(237, 135);
            this.btnSzavazas.TabIndex = 3;
            this.btnSzavazas.Text = "Szavazok";
            this.btnSzavazas.UseVisualStyleBackColor = true;
            this.btnSzavazas.Click += new System.EventHandler(this.btnSzavazas_Click);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.btnSzavazas);
            this.Controls.Add(this.cmbJelolt);
            this.Controls.Add(this.lblSzavazat);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.txtFelhasznalo);
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

        private System.Windows.Forms.TextBox txtFelhasznalo;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Label lblSzavazat;
        private System.Windows.Forms.ComboBox cmbJelolt;
        private System.Windows.Forms.BindingSource canditeBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnSzavazas;
    }
}