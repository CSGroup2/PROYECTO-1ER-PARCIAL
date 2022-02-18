
namespace Visual {
    partial class Frm_Conductor_Registrar {
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
            this.panel1 = new System.Windows.Forms.Panel ();
            this.label2 = new System.Windows.Forms.Label ();
            this.panel2 = new System.Windows.Forms.Panel ();
            this.btnguardar = new FontAwesome.Sharp.IconButton ();
            this.pncontenido = new System.Windows.Forms.Panel ();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker ();
            this.label11 = new System.Windows.Forms.Label ();
            this.textBox7 = new System.Windows.Forms.TextBox ();
            this.label10 = new System.Windows.Forms.Label ();
            this.textBox6 = new System.Windows.Forms.TextBox ();
            this.label9 = new System.Windows.Forms.Label ();
            this.daterfechanac = new System.Windows.Forms.DateTimePicker ();
            this.label8 = new System.Windows.Forms.Label ();
            this.oprfemenino = new System.Windows.Forms.RadioButton ();
            this.oprmasculino = new System.Windows.Forms.RadioButton ();
            this.label7 = new System.Windows.Forms.Label ();
            this.groupBox1 = new System.Windows.Forms.GroupBox ();
            this.textBox4 = new System.Windows.Forms.TextBox ();
            this.label1 = new System.Windows.Forms.Label ();
            this.textBox5 = new System.Windows.Forms.TextBox ();
            this.label6 = new System.Windows.Forms.Label ();
            this.textBox3 = new System.Windows.Forms.TextBox ();
            this.label5 = new System.Windows.Forms.Label ();
            this.gboxnombres = new System.Windows.Forms.GroupBox ();
            this.textBox2 = new System.Windows.Forms.TextBox ();
            this.label3 = new System.Windows.Forms.Label ();
            this.textBox1 = new System.Windows.Forms.TextBox ();
            this.label4 = new System.Windows.Forms.Label ();
            this.btncancelar = new FontAwesome.Sharp.IconButton ();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton ();
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            this.pncontenido.SuspendLayout ();
            this.groupBox1.SuspendLayout ();
            this.gboxnombres.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add (this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (662, 63);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point (117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (461, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de Conductores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._8;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add (this.btnguardar);
            this.panel2.Controls.Add (this.pncontenido);
            this.panel2.Controls.Add (this.btncancelar);
            this.panel2.Controls.Add (this.btnlimpiar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point (0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (662, 419);
            this.panel2.TabIndex = 1;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font ("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point (38, 346);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size (183, 52);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.MouseLeave += new System.EventHandler (this.btnguardar_MouseLeave);
            this.btnguardar.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btnguardar_MouseMove_1);
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add (this.dateTimePicker1);
            this.pncontenido.Controls.Add (this.label11);
            this.pncontenido.Controls.Add (this.textBox7);
            this.pncontenido.Controls.Add (this.label10);
            this.pncontenido.Controls.Add (this.textBox6);
            this.pncontenido.Controls.Add (this.label9);
            this.pncontenido.Controls.Add (this.daterfechanac);
            this.pncontenido.Controls.Add (this.label8);
            this.pncontenido.Controls.Add (this.oprfemenino);
            this.pncontenido.Controls.Add (this.oprmasculino);
            this.pncontenido.Controls.Add (this.label7);
            this.pncontenido.Controls.Add (this.groupBox1);
            this.pncontenido.Controls.Add (this.textBox3);
            this.pncontenido.Controls.Add (this.label5);
            this.pncontenido.Controls.Add (this.gboxnombres);
            this.pncontenido.Location = new System.Drawing.Point (20, 38);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size (622, 284);
            this.pncontenido.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point (158, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size (242, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point (16, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size (120, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fech. Contrato:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point (85, 133);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size (222, 26);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextChanged += new System.EventHandler (this.textBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point (15, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size (64, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point (408, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size (197, 26);
            this.textBox6.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point (324, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size (78, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Num. Telf:";
            // 
            // daterfechanac
            // 
            this.daterfechanac.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daterfechanac.Location = new System.Drawing.Point (158, 198);
            this.daterfechanac.Name = "daterfechanac";
            this.daterfechanac.Size = new System.Drawing.Size (242, 26);
            this.daterfechanac.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point (16, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size (142, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fech. Nacimiento:";
            // 
            // oprfemenino
            // 
            this.oprfemenino.AutoSize = true;
            this.oprfemenino.BackColor = System.Drawing.Color.Transparent;
            this.oprfemenino.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oprfemenino.Location = new System.Drawing.Point (209, 168);
            this.oprfemenino.Name = "oprfemenino";
            this.oprfemenino.Size = new System.Drawing.Size (98, 24);
            this.oprfemenino.TabIndex = 14;
            this.oprfemenino.Text = "Femenino";
            this.oprfemenino.UseVisualStyleBackColor = false;
            // 
            // oprmasculino
            // 
            this.oprmasculino.AutoSize = true;
            this.oprmasculino.BackColor = System.Drawing.Color.Transparent;
            this.oprmasculino.Checked = true;
            this.oprmasculino.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oprmasculino.Location = new System.Drawing.Point (85, 168);
            this.oprmasculino.Name = "oprmasculino";
            this.oprmasculino.Size = new System.Drawing.Size (102, 24);
            this.oprmasculino.TabIndex = 13;
            this.oprmasculino.TabStop = true;
            this.oprmasculino.Text = "Masculino";
            this.oprmasculino.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point (17, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size (48, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add (this.textBox4);
            this.groupBox1.Controls.Add (this.label1);
            this.groupBox1.Controls.Add (this.textBox5);
            this.groupBox1.Controls.Add (this.label6);
            this.groupBox1.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point (322, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size (289, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apellidos";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point (146, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size (137, 26);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point (2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Segundo Apellido:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point (146, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size (137, 26);
            this.textBox5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font ("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point (2, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size (127, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primer Apellido:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point (138, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size (169, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point (16, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (109, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num. Cédula:";
            // 
            // gboxnombres
            // 
            this.gboxnombres.BackColor = System.Drawing.Color.Transparent;
            this.gboxnombres.Controls.Add (this.textBox2);
            this.gboxnombres.Controls.Add (this.label3);
            this.gboxnombres.Controls.Add (this.textBox1);
            this.gboxnombres.Controls.Add (this.label4);
            this.gboxnombres.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxnombres.Location = new System.Drawing.Point (11, 44);
            this.gboxnombres.Name = "gboxnombres";
            this.gboxnombres.Size = new System.Drawing.Size (303, 85);
            this.gboxnombres.TabIndex = 4;
            this.gboxnombres.TabStop = false;
            this.gboxnombres.Text = "Nombres";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point (147, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size (149, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point (4, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (142, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Segundo Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font ("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point (147, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (149, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font ("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point (6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (128, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Nombre:";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.Font = new System.Drawing.Font ("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point (237, 346);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btncancelar.Size = new System.Drawing.Size (183, 52);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.MouseLeave += new System.EventHandler (this.btncancelar_MouseLeave);
            this.btncancelar.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btncancelar_MouseMove);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.Font = new System.Drawing.Font ("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiar.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.Location = new System.Drawing.Point (440, 346);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btnlimpiar.Size = new System.Drawing.Size (183, 52);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler (this.btnlimpiar_Click);
            this.btnlimpiar.MouseLeave += new System.EventHandler (this.btnlimpiar_MouseLeave);
            this.btnlimpiar.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btnlimpiar_MouseMove);
            // 
            // Frm_Conductor_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (662, 482);
            this.Controls.Add (this.panel2);
            this.Controls.Add (this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Conductor_Registrar";
            this.Text = "FrmConductorReg";
            this.Load += new System.EventHandler (this.FrmConductorReg_Load);
            this.panel1.ResumeLayout (false);
            this.panel1.PerformLayout ();
            this.panel2.ResumeLayout (false);
            this.pncontenido.ResumeLayout (false);
            this.pncontenido.PerformLayout ();
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ();
            this.gboxnombres.ResumeLayout (false);
            this.gboxnombres.PerformLayout ();
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxnombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.Panel pncontenido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton oprfemenino;
        private System.Windows.Forms.RadioButton oprmasculino;
        private System.Windows.Forms.DateTimePicker daterfechanac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
    }
}