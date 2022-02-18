
namespace Visual {
    partial class Frm_Recuperar_Password {
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
            this.label1 = new System.Windows.Forms.Label ();
            this.txtuserrequesting = new System.Windows.Forms.TextBox ();
            this.btnrecuperar = new System.Windows.Forms.Button ();
            this.lblmensaje = new System.Windows.Forms.Label ();
            this.pictureBox1 = new System.Windows.Forms.PictureBox ();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ();
            this.SuspendLayout ();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point (24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (256, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese su usuario o correo:";
            // 
            // txtuserrequesting
            // 
            this.txtuserrequesting.Font = new System.Drawing.Font ("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserrequesting.Location = new System.Drawing.Point (30, 113);
            this.txtuserrequesting.Name = "txtuserrequesting";
            this.txtuserrequesting.Size = new System.Drawing.Size (334, 26);
            this.txtuserrequesting.TabIndex = 5;
            // 
            // btnrecuperar
            // 
            this.btnrecuperar.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnrecuperar.FlatAppearance.BorderSize = 0;
            this.btnrecuperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb (((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnrecuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb (((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecuperar.ForeColor = System.Drawing.Color.LightGray;
            this.btnrecuperar.Location = new System.Drawing.Point (396, 88);
            this.btnrecuperar.Name = "btnrecuperar";
            this.btnrecuperar.Size = new System.Drawing.Size (179, 51);
            this.btnrecuperar.TabIndex = 7;
            this.btnrecuperar.Text = "Recuperar";
            this.btnrecuperar.UseVisualStyleBackColor = false;
            this.btnrecuperar.Click += new System.EventHandler (this.btnrecuperar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font ("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.DarkGray;
            this.lblmensaje.Location = new System.Drawing.Point (26, 162);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size (0, 22);
            this.lblmensaje.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Visual.Properties.Resources.Letra_Solo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point (178, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size (275, 63);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Recuperar_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size (603, 272);
            this.Controls.Add (this.pictureBox1);
            this.Controls.Add (this.lblmensaje);
            this.Controls.Add (this.btnrecuperar);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.txtuserrequesting);
            this.Name = "Frm_Recuperar_Password";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecuperarContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserrequesting;
        private System.Windows.Forms.Button btnrecuperar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}