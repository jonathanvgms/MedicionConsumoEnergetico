﻿namespace ConsumoEnergetico.Mediciones
{
    partial class ucMedicion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHistorialAgua = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreEje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalleMedicion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtDatoMedicion = new System.Windows.Forms.TextBox();
            this.dtpFechaMedicion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcionMedidor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoMedidor = new System.Windows.Forms.Button();
            this.cboMedidor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAgua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorialAgua
            // 
            this.dgvHistorialAgua.AllowUserToAddRows = false;
            this.dgvHistorialAgua.AllowUserToDeleteRows = false;
            this.dgvHistorialAgua.AllowUserToResizeColumns = false;
            this.dgvHistorialAgua.AllowUserToResizeRows = false;
            this.dgvHistorialAgua.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorialAgua.ColumnHeadersHeight = 22;
            this.dgvHistorialAgua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialAgua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Fecha,
            this.Dato,
            this.Unidad,
            this.Detalle,
            this.Editar,
            this.Borrar});
            this.dgvHistorialAgua.Location = new System.Drawing.Point(9, 163);
            this.dgvHistorialAgua.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorialAgua.MultiSelect = false;
            this.dgvHistorialAgua.Name = "dgvHistorialAgua";
            this.dgvHistorialAgua.ReadOnly = true;
            this.dgvHistorialAgua.RowHeadersVisible = false;
            this.dgvHistorialAgua.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistorialAgua.RowTemplate.Height = 28;
            this.dgvHistorialAgua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistorialAgua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialAgua.Size = new System.Drawing.Size(1344, 450);
            this.dgvHistorialAgua.TabIndex = 0;
            this.dgvHistorialAgua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgHistorialAgua_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Medidor";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Dato
            // 
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            this.Dato.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreEje);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDetalleMedicion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblUnidad);
            this.groupBox1.Controls.Add(this.txtDatoMedicion);
            this.groupBox1.Controls.Add(this.dtpFechaMedicion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDescripcionMedidor);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevoMedidor);
            this.groupBox1.Controls.Add(this.cboMedidor);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1344, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Medición";
            // 
            // lblNombreEje
            // 
            this.lblNombreEje.AutoSize = true;
            this.lblNombreEje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEje.Location = new System.Drawing.Point(76, 30);
            this.lblNombreEje.Name = "lblNombreEje";
            this.lblNombreEje.Size = new System.Drawing.Size(73, 16);
            this.lblNombreEje.TabIndex = 14;
            this.lblNombreEje.Text = "Indicador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Indicador";
            // 
            // txtDetalleMedicion
            // 
            this.txtDetalleMedicion.Location = new System.Drawing.Point(650, 65);
            this.txtDetalleMedicion.Multiline = true;
            this.txtDetalleMedicion.Name = "txtDetalleMedicion";
            this.txtDetalleMedicion.Size = new System.Drawing.Size(338, 52);
            this.txtDetalleMedicion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Detalle";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(796, 32);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 13);
            this.lblUnidad.TabIndex = 6;
            // 
            // txtDatoMedicion
            // 
            this.txtDatoMedicion.Location = new System.Drawing.Point(650, 29);
            this.txtDatoMedicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatoMedicion.Name = "txtDatoMedicion";
            this.txtDatoMedicion.Size = new System.Drawing.Size(141, 20);
            this.txtDatoMedicion.TabIndex = 10;
            // 
            // dtpFechaMedicion
            // 
            this.dtpFechaMedicion.Location = new System.Drawing.Point(1079, 29);
            this.dtpFechaMedicion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaMedicion.Name = "dtpFechaMedicion";
            this.dtpFechaMedicion.Size = new System.Drawing.Size(246, 20);
            this.dtpFechaMedicion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1022, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medidor";
            // 
            // lblDescripcionMedidor
            // 
            this.lblDescripcionMedidor.AutoSize = true;
            this.lblDescripcionMedidor.Location = new System.Drawing.Point(258, 53);
            this.lblDescripcionMedidor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionMedidor.Name = "lblDescripcionMedidor";
            this.lblDescripcionMedidor.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionMedidor.TabIndex = 5;
            this.lblDescripcionMedidor.Text = "Descripción";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1224, 89);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevoMedidor
            // 
            this.btnNuevoMedidor.Location = new System.Drawing.Point(423, 25);
            this.btnNuevoMedidor.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoMedidor.Name = "btnNuevoMedidor";
            this.btnNuevoMedidor.Size = new System.Drawing.Size(107, 28);
            this.btnNuevoMedidor.TabIndex = 2;
            this.btnNuevoMedidor.Text = "Agregar Medidor";
            this.btnNuevoMedidor.UseVisualStyleBackColor = true;
            this.btnNuevoMedidor.Click += new System.EventHandler(this.btnNuevoMedidor_Click);
            // 
            // cboMedidor
            // 
            this.cboMedidor.FormattingEnabled = true;
            this.cboMedidor.Location = new System.Drawing.Point(261, 30);
            this.cboMedidor.Margin = new System.Windows.Forms.Padding(2);
            this.cboMedidor.Name = "cboMedidor";
            this.cboMedidor.Size = new System.Drawing.Size(141, 21);
            this.cboMedidor.TabIndex = 1;
            this.cboMedidor.SelectedIndexChanged += new System.EventHandler(this.ActualizarDescripcionMedidor);
            // 
            // ucMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHistorialAgua);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMedicion";
            this.Size = new System.Drawing.Size(1366, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAgua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHistorialAgua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetalleMedicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtDatoMedicion;
        private System.Windows.Forms.DateTimePicker dtpFechaMedicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcionMedidor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevoMedidor;
        private System.Windows.Forms.ComboBox cboMedidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.Label lblNombreEje;
        private System.Windows.Forms.Label label4;
    }
}
