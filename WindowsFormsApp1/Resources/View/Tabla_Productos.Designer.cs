namespace WindowsFormsApp1
{
    partial class Tabla_Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIngresarEmpleados = new System.Windows.Forms.Button();
            this.BtnIngresarMascotas = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "VetManager";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(192)))));
            this.btnIngresar.Location = new System.Drawing.Point(726, 41);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(122, 35);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar Cita";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(192)))));
            this.btnActualizar.Location = new System.Drawing.Point(598, 41);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(122, 35);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar Cita";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnIngresarEmpleados);
            this.panel2.Controls.Add(this.BtnIngresarMascotas);
            this.panel2.Controls.Add(this.btnRegistro);
            this.panel2.Controls.Add(this.btnHistorial);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnCitas);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 460);
            this.panel2.TabIndex = 1;
            // 
            // btnIngresarEmpleados
            // 
            this.btnIngresarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.btnIngresarEmpleados.Location = new System.Drawing.Point(0, 347);
            this.btnIngresarEmpleados.Name = "btnIngresarEmpleados";
            this.btnIngresarEmpleados.Size = new System.Drawing.Size(152, 46);
            this.btnIngresarEmpleados.TabIndex = 4;
            this.btnIngresarEmpleados.Text = "Ingresar Empleados";
            this.btnIngresarEmpleados.UseVisualStyleBackColor = false;
            // 
            // BtnIngresarMascotas
            // 
            this.BtnIngresarMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.BtnIngresarMascotas.Location = new System.Drawing.Point(0, 305);
            this.BtnIngresarMascotas.Name = "BtnIngresarMascotas";
            this.BtnIngresarMascotas.Size = new System.Drawing.Size(152, 46);
            this.BtnIngresarMascotas.TabIndex = 5;
            this.BtnIngresarMascotas.Text = "Ingresar Mascotas";
            this.BtnIngresarMascotas.UseVisualStyleBackColor = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.btnRegistro.Location = new System.Drawing.Point(0, 265);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(152, 46);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.btnHistorial.Location = new System.Drawing.Point(0, 225);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(152, 49);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.btnProductos.Location = new System.Drawing.Point(0, 183);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(152, 49);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.btnCitas.Location = new System.Drawing.Point(0, 143);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(152, 49);
            this.btnCitas.TabIndex = 4;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.btnUsuario.Location = new System.Drawing.Point(0, 103);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(152, 49);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.NombreProducto,
            this.PrecioProducto,
            this.idProveedor,
            this.Codigo});
            this.dtgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductos.Location = new System.Drawing.Point(151, 113);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.Size = new System.Drawing.Size(709, 460);
            this.dtgvProductos.TabIndex = 2;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID de Producto";
            this.idProducto.Name = "idProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio del Producto";
            this.PrecioProducto.Name = "PrecioProducto";
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "ID del Proveedor";
            this.idProveedor.Name = "idProveedor";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo de Barras";
            this.Codigo.Name = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(151, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(709, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_08_07_173046;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.png_transparent_profile_logo_computer_icons_user_user_blue_heroes_logo_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(21, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Tabla_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 573);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Tabla_Productos";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnIngresarEmpleados;
        private System.Windows.Forms.Button BtnIngresarMascotas;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

