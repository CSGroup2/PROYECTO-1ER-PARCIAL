
namespace CapaPresentacion
{
    partial class FrmAmbulanciaConsul
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnimprimir = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnmostrartodos = new FontAwesome.Sharp.IconButton();
            this.btnconsultar = new FontAwesome.Sharp.IconButton();
            this.cbxbuscarestado = new System.Windows.Forms.ComboBox();
            this.chxestado = new System.Windows.Forms.CheckBox();
            this.opnombres = new System.Windows.Forms.RadioButton();
            this.opcedula = new System.Windows.Forms.RadioButton();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::CapaPresentacion.Properties.Resources._9;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnimprimir);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 419);
            this.panel2.TabIndex = 4;
            // 
            // btnimprimir
            // 
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimprimir.Location = new System.Drawing.Point(357, 343);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnimprimir.Size = new System.Drawing.Size(183, 52);
            this.btnimprimir.TabIndex = 16;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.MouseLeave += new System.EventHandler(this.btnimprimir_MouseLeave);
            this.btnimprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnimprimir_MouseMove);
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(149, 343);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size(183, 52);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Modificar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.checkBox1);
            this.pncontenido.Controls.Add(this.btnmostrartodos);
            this.pncontenido.Controls.Add(this.btnconsultar);
            this.pncontenido.Controls.Add(this.cbxbuscarestado);
            this.pncontenido.Controls.Add(this.chxestado);
            this.pncontenido.Controls.Add(this.opnombres);
            this.pncontenido.Controls.Add(this.opcedula);
            this.pncontenido.Controls.Add(this.txtCriterio);
            this.pncontenido.Controls.Add(this.label14);
            this.pncontenido.Controls.Add(this.dgv_listarTodos);
            this.pncontenido.Location = new System.Drawing.Point(20, 15);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(622, 308);
            this.pncontenido.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(25, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 19);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "Tipo";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btnmostrartodos
            // 
            this.btnmostrartodos.FlatAppearance.BorderSize = 0;
            this.btnmostrartodos.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmostrartodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnmostrartodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmostrartodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmostrartodos.IconSize = 35;
            this.btnmostrartodos.Location = new System.Drawing.Point(420, 43);
            this.btnmostrartodos.Name = "btnmostrartodos";
            this.btnmostrartodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmostrartodos.Size = new System.Drawing.Size(171, 37);
            this.btnmostrartodos.TabIndex = 57;
            this.btnmostrartodos.Text = "Mostrar Todos";
            this.btnmostrartodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnmostrartodos.UseVisualStyleBackColor = true;
            this.btnmostrartodos.MouseLeave += new System.EventHandler(this.btnmostrartodos_MouseLeave);
            this.btnmostrartodos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmostrartodos_MouseMove);
            // 
            // btnconsultar
            // 
            this.btnconsultar.FlatAppearance.BorderSize = 0;
            this.btnconsultar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnconsultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnconsultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnconsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnconsultar.IconSize = 35;
            this.btnconsultar.Location = new System.Drawing.Point(235, 42);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnconsultar.Size = new System.Drawing.Size(168, 37);
            this.btnconsultar.TabIndex = 16;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.MouseLeave += new System.EventHandler(this.btnconsultar_MouseLeave);
            this.btnconsultar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnconsultar_MouseMove);
            // 
            // cbxbuscarestado
            // 
            this.cbxbuscarestado.FormattingEnabled = true;
            this.cbxbuscarestado.Location = new System.Drawing.Point(80, 53);
            this.cbxbuscarestado.Name = "cbxbuscarestado";
            this.cbxbuscarestado.Size = new System.Drawing.Size(145, 21);
            this.cbxbuscarestado.TabIndex = 56;
            // 
            // chxestado
            // 
            this.chxestado.AutoSize = true;
            this.chxestado.BackColor = System.Drawing.Color.Transparent;
            this.chxestado.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxestado.Location = new System.Drawing.Point(448, 17);
            this.chxestado.Name = "chxestado";
            this.chxestado.Size = new System.Drawing.Size(124, 19);
            this.chxestado.TabIndex = 55;
            this.chxestado.Text = "Disponibilidad";
            this.chxestado.UseVisualStyleBackColor = false;
            // 
            // opnombres
            // 
            this.opnombres.AutoSize = true;
            this.opnombres.BackColor = System.Drawing.Color.Transparent;
            this.opnombres.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnombres.Location = new System.Drawing.Point(336, 18);
            this.opnombres.Name = "opnombres";
            this.opnombres.Size = new System.Drawing.Size(67, 19);
            this.opnombres.TabIndex = 52;
            this.opnombres.Text = "Modelo";
            this.opnombres.UseVisualStyleBackColor = false;
            // 
            // opcedula
            // 
            this.opcedula.AutoSize = true;
            this.opcedula.BackColor = System.Drawing.Color.Transparent;
            this.opcedula.Checked = true;
            this.opcedula.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcedula.Location = new System.Drawing.Point(235, 17);
            this.opcedula.Name = "opcedula";
            this.opcedula.Size = new System.Drawing.Size(95, 19);
            this.opcedula.TabIndex = 51;
            this.opcedula.TabStop = true;
            this.opcedula.Text = "Num. Placa";
            this.opcedula.UseVisualStyleBackColor = false;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(80, 18);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(145, 20);
            this.txtCriterio.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Dato: ";
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.AllowUserToAddRows = false;
            this.dgv_listarTodos.AllowUserToDeleteRows = false;
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.estado,
            this.placa,
            this.Modelo,
            this.tipo,
            this.capacidad,
            this.observacion});
            this.dgv_listarTodos.Location = new System.Drawing.Point(25, 96);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listarTodos.Size = new System.Drawing.Size(566, 182);
            this.dgv_listarTodos.TabIndex = 48;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Disponibilidad";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // placa
            // 
            this.placa.HeaderText = "Numero de Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.HeaderText = "Capacidad";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observación";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 63);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta de Ambulancias";
            // 
            // FrmAmbulanciaConsul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAmbulanciaConsul";
            this.Text = "FrmAmbulanciaConsul";
            this.Load += new System.EventHandler(this.FrmAmbulanciaConsul_Load);
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnimprimir;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Panel pncontenido;
        private FontAwesome.Sharp.IconButton btnmostrartodos;
        private FontAwesome.Sharp.IconButton btnconsultar;
        private System.Windows.Forms.ComboBox cbxbuscarestado;
        private System.Windows.Forms.CheckBox chxestado;
        private System.Windows.Forms.RadioButton opnombres;
        private System.Windows.Forms.RadioButton opcedula;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    }
}