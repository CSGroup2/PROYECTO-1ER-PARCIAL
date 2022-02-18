
namespace Visual {
    partial class Frm_Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.txtusuario = new System.Windows.Forms.TextBox ();
            this.txtcontra = new System.Windows.Forms.TextBox ();
            this.btnacceder = new System.Windows.Forms.Button ();
            this.panel1 = new System.Windows.Forms.Panel ();
            this.pictureBox1 = new System.Windows.Forms.PictureBox ();
            this.label1 = new System.Windows.Forms.Label ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.lklblrecuperar = new System.Windows.Forms.LinkLabel ();
            this.panel1.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ();
            this.SuspendLayout ();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point (367, 74);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size (198, 20);
            this.txtusuario.TabIndex = 0;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point (367, 136);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size (198, 20);
            this.txtcontra.TabIndex = 1;
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnacceder.FlatAppearance.BorderSize = 0;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb (((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb (((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnacceder.Location = new System.Drawing.Point (261, 190);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size (304, 40);
            this.btnacceder.TabIndex = 2;
            this.btnacceder.Text = "Acceder";
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler (this.btnacceder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add (this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (177, 272);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Visual.Properties.Resources.LosRapidos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point (7, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size (162, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point (257, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (65, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point (257, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (98, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font ("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point (345, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (105, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // lklblrecuperar
            // 
            this.lklblrecuperar.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lklblrecuperar.AutoSize = true;
            this.lklblrecuperar.Font = new System.Drawing.Font ("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblrecuperar.LinkColor = System.Drawing.Color.DarkGray;
            this.lklblrecuperar.Location = new System.Drawing.Point (318, 243);
            this.lklblrecuperar.Name = "lklblrecuperar";
            this.lklblrecuperar.Size = new System.Drawing.Size (189, 17);
            this.lklblrecuperar.TabIndex = 7;
            this.lklblrecuperar.TabStop = true;
            this.lklblrecuperar.Text = "¿Ha olvidado la contraseña?";
            this.lklblrecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.lklblrecuperar_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size (603, 272);
            this.Controls.Add (this.lklblrecuperar);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.panel1);
            this.Controls.Add (this.btnacceder);
            this.Controls.Add (this.txtcontra);
            this.Controls.Add (this.txtusuario);
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler (this.FrmLogin_Load);
            this.panel1.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lklblrecuperar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}