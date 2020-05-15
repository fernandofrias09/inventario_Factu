namespace Inventario_facturacion
{
    partial class FrmMantenimientoProducto
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
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.GbBotones = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBallonsupp = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.GbProductosRegistrados = new System.Windows.Forms.GroupBox();
            this.chbID = new System.Windows.Forms.CheckBox();
            this.chbPrecio = new System.Windows.Forms.CheckBox();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbDescripcion.SuspendLayout();
            this.GbBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.GbProductosRegistrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Controls.Add(this.txtPrecio);
            this.gbDescripcion.Controls.Add(this.txtCantidad);
            this.gbDescripcion.Controls.Add(this.txtCosto);
            this.gbDescripcion.Controls.Add(this.txtNombre);
            this.gbDescripcion.Controls.Add(this.label5);
            this.gbDescripcion.Controls.Add(this.label4);
            this.gbDescripcion.Controls.Add(this.label3);
            this.gbDescripcion.Controls.Add(this.label2);
            this.gbDescripcion.Controls.Add(this.TxtID);
            this.gbDescripcion.Controls.Add(this.label1);
            this.gbDescripcion.Location = new System.Drawing.Point(1, 106);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(504, 190);
            this.gbDescripcion.TabIndex = 0;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Descripcion";
            this.gbDescripcion.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(85, 37);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(371, 33);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(371, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(205, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // GbBotones
            // 
            this.GbBotones.Controls.Add(this.BtnBorrar);
            this.GbBotones.Controls.Add(this.btnNuevo);
            this.GbBotones.Controls.Add(this.btnEditar);
            this.GbBotones.Location = new System.Drawing.Point(538, 106);
            this.GbBotones.Name = "GbBotones";
            this.GbBotones.Size = new System.Drawing.Size(262, 190);
            this.GbBotones.TabIndex = 1;
            this.GbBotones.TabStop = false;
            this.GbBotones.Text = "Botones";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(100, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(100, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(100, 150);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.LblBallonsupp);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 100);
            this.panel1.TabIndex = 2;
            // 
            // LblBallonsupp
            // 
            this.LblBallonsupp.AutoSize = true;
            this.LblBallonsupp.BackColor = System.Drawing.Color.Transparent;
            this.LblBallonsupp.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBallonsupp.Location = new System.Drawing.Point(3, 28);
            this.LblBallonsupp.Name = "LblBallonsupp";
            this.LblBallonsupp.Size = new System.Drawing.Size(169, 39);
            this.LblBallonsupp.TabIndex = 0;
            this.LblBallonsupp.Text = "Ballonsupp";
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(1, 389);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(799, 123);
            this.dgvProducto.TabIndex = 3;
            // 
            // GbProductosRegistrados
            // 
            this.GbProductosRegistrados.Controls.Add(this.btnBuscar);
            this.GbProductosRegistrados.Controls.Add(this.textBox1);
            this.GbProductosRegistrados.Controls.Add(this.chbNombre);
            this.GbProductosRegistrados.Controls.Add(this.chbPrecio);
            this.GbProductosRegistrados.Controls.Add(this.chbID);
            this.GbProductosRegistrados.Location = new System.Drawing.Point(1, 302);
            this.GbProductosRegistrados.Name = "GbProductosRegistrados";
            this.GbProductosRegistrados.Size = new System.Drawing.Size(799, 81);
            this.GbProductosRegistrados.TabIndex = 4;
            this.GbProductosRegistrados.TabStop = false;
            this.GbProductosRegistrados.Text = "Productos Registrados";
            this.GbProductosRegistrados.Enter += new System.EventHandler(this.GbProductosRegistrados_Enter);
            // 
            // chbID
            // 
            this.chbID.AutoSize = true;
            this.chbID.Location = new System.Drawing.Point(54, 19);
            this.chbID.Name = "chbID";
            this.chbID.Size = new System.Drawing.Size(37, 17);
            this.chbID.TabIndex = 10;
            this.chbID.Text = "ID";
            this.chbID.UseVisualStyleBackColor = true;
            // 
            // chbPrecio
            // 
            this.chbPrecio.AutoSize = true;
            this.chbPrecio.Location = new System.Drawing.Point(504, 19);
            this.chbPrecio.Name = "chbPrecio";
            this.chbPrecio.Size = new System.Drawing.Size(56, 17);
            this.chbPrecio.TabIndex = 11;
            this.chbPrecio.Text = "Precio";
            this.chbPrecio.UseVisualStyleBackColor = true;
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Location = new System.Drawing.Point(281, 19);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(63, 17);
            this.chbNombre.TabIndex = 12;
            this.chbNombre.Text = "Nombre";
            this.chbNombre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(637, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmMantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 514);
            this.Controls.Add(this.GbProductosRegistrados);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GbBotones);
            this.Controls.Add(this.gbDescripcion);
            this.Name = "FrmMantenimientoProducto";
            this.Text = "Producto";
            this.gbDescripcion.ResumeLayout(false);
            this.gbDescripcion.PerformLayout();
            this.GbBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.GbProductosRegistrados.ResumeLayout(false);
            this.GbProductosRegistrados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox GbBotones;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblBallonsupp;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox GbProductosRegistrados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbPrecio;
        private System.Windows.Forms.CheckBox chbID;
    }
}