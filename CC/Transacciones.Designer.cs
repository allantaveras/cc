namespace CC
{
    partial class Transacciones
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
            this.txtCuentaC = new System.Windows.Forms.ComboBox();
            this.txtEstado2 = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvTipoDoc = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCuentaC
            // 
            this.txtCuentaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCuentaC.FormattingEnabled = true;
            this.txtCuentaC.Items.AddRange(new object[] {
            "00001",
            "00002",
            "00003"});
            this.txtCuentaC.Location = new System.Drawing.Point(118, 50);
            this.txtCuentaC.Name = "txtCuentaC";
            this.txtCuentaC.Size = new System.Drawing.Size(170, 21);
            this.txtCuentaC.TabIndex = 34;
            // 
            // txtEstado2
            // 
            this.txtEstado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado2.FormattingEnabled = true;
            this.txtEstado2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado2.Location = new System.Drawing.Point(118, 24);
            this.txtEstado2.Name = "txtEstado2";
            this.txtEstado2.Size = new System.Drawing.Size(171, 21);
            this.txtEstado2.TabIndex = 33;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(586, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(319, 20);
            this.txtBuscar.TabIndex = 32;
            // 
            // dgvTipoDoc
            // 
            this.dgvTipoDoc.AllowUserToAddRows = false;
            this.dgvTipoDoc.AllowUserToDeleteRows = false;
            this.dgvTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTipoDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDoc.Location = new System.Drawing.Point(586, 53);
            this.dgvTipoDoc.Name = "dgvTipoDoc";
            this.dgvTipoDoc.ReadOnly = true;
            this.dgvTipoDoc.Size = new System.Drawing.Size(400, 175);
            this.dgvTipoDoc.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseCompatibleTextRendering = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(911, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseCompatibleTextRendering = true;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(118, 353);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseCompatibleTextRendering = true;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(37, 353);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 30;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseCompatibleTextRendering = true;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo de Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cuenta Contable";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(118, 227);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(171, 101);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Privilegios:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(267, 417);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(38, 15);
            this.lblAdmin.TabIndex = 43;
            this.lblAdmin.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(51, 417);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Text = "label1";
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCuentaC);
            this.Controls.Add(this.txtEstado2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvTipoDoc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtCuentaC;
        private System.Windows.Forms.ComboBox txtEstado2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvTipoDoc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblNombre;
    }
}