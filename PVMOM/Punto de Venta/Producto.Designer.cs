namespace Punto_de_Venta
{
    partial class Producto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Altas = new System.Windows.Forms.TabPage();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Bajas = new System.Windows.Forms.TabPage();
            this.dgBaja = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgModificacion = new System.Windows.Forms.DataGridView();
            this.btnModifiacion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModificacion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Altas.SuspendLayout();
            this.Bajas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaja)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModificacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Altas);
            this.tabControl1.Controls.Add(this.Bajas);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // Altas
            // 
            this.Altas.BackgroundImage = global::Punto_de_Venta.Properties.Resources.background;
            this.Altas.Controls.Add(this.label11);
            this.Altas.Controls.Add(this.txtCodigo);
            this.Altas.Controls.Add(this.btnAlta);
            this.Altas.Controls.Add(this.label4);
            this.Altas.Controls.Add(this.label3);
            this.Altas.Controls.Add(this.label2);
            this.Altas.Controls.Add(this.label1);
            this.Altas.Controls.Add(this.txtPrecio);
            this.Altas.Controls.Add(this.txtCantidad);
            this.Altas.Controls.Add(this.txtNombre);
            this.Altas.Location = new System.Drawing.Point(4, 22);
            this.Altas.Name = "Altas";
            this.Altas.Padding = new System.Windows.Forms.Padding(3);
            this.Altas.Size = new System.Drawing.Size(710, 448);
            this.Altas.TabIndex = 0;
            this.Altas.Text = "Altas";
            this.Altas.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("HelveticaCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(451, 310);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(206, 107);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica LT Std Cond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(220, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alta de Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(48, 302);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 31);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(48, 219);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 31);
            this.txtCantidad.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(48, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 31);
            this.txtNombre.TabIndex = 0;
            // 
            // Bajas
            // 
            this.Bajas.BackgroundImage = global::Punto_de_Venta.Properties.Resources.background;
            this.Bajas.Controls.Add(this.dgBaja);
            this.Bajas.Controls.Add(this.btnBaja);
            this.Bajas.Controls.Add(this.label5);
            this.Bajas.Controls.Add(this.label8);
            this.Bajas.Controls.Add(this.txtBaja);
            this.Bajas.Location = new System.Drawing.Point(4, 22);
            this.Bajas.Name = "Bajas";
            this.Bajas.Padding = new System.Windows.Forms.Padding(3);
            this.Bajas.Size = new System.Drawing.Size(710, 448);
            this.Bajas.TabIndex = 1;
            this.Bajas.Text = "Bajas";
            this.Bajas.UseVisualStyleBackColor = true;
            // 
            // dgBaja
            // 
            this.dgBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBaja.Location = new System.Drawing.Point(52, 192);
            this.dgBaja.Name = "dgBaja";
            this.dgBaja.ReadOnly = true;
            this.dgBaja.Size = new System.Drawing.Size(409, 225);
            this.dgBaja.TabIndex = 16;
            this.dgBaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBaja_CellClick);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.Brown;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("HelveticaCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Location = new System.Drawing.Point(477, 247);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(206, 107);
            this.btnBaja.TabIndex = 15;
            this.btnBaja.Text = "Dar Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica LT Std Cond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(224, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 46);
            this.label5.TabIndex = 14;
            this.label5.Text = "Baja de Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Producto";
            // 
            // txtBaja
            // 
            this.txtBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaja.Location = new System.Drawing.Point(52, 140);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(409, 31);
            this.txtBaja.TabIndex = 8;
            this.txtBaja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBaja_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Punto_de_Venta.Properties.Resources.background;
            this.tabPage1.Controls.Add(this.dgModificacion);
            this.tabPage1.Controls.Add(this.btnModifiacion);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtModificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 448);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modificaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgModificacion
            // 
            this.dgModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModificacion.Location = new System.Drawing.Point(41, 192);
            this.dgModificacion.Name = "dgModificacion";
            this.dgModificacion.ReadOnly = true;
            this.dgModificacion.Size = new System.Drawing.Size(409, 225);
            this.dgModificacion.TabIndex = 21;
            this.dgModificacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgModificacion_CellClick);
            // 
            // btnModifiacion
            // 
            this.btnModifiacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModifiacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifiacion.Font = new System.Drawing.Font("HelveticaCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiacion.ForeColor = System.Drawing.Color.White;
            this.btnModifiacion.Location = new System.Drawing.Point(466, 247);
            this.btnModifiacion.Name = "btnModifiacion";
            this.btnModifiacion.Size = new System.Drawing.Size(206, 107);
            this.btnModifiacion.TabIndex = 20;
            this.btnModifiacion.Text = "Modificar";
            this.btnModifiacion.UseVisualStyleBackColor = false;
            this.btnModifiacion.Click += new System.EventHandler(this.btnModifiacion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica LT Std Cond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(144, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 46);
            this.label6.TabIndex = 19;
            this.label6.Text = "Modificacion de Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Producto";
            // 
            // txtModificacion
            // 
            this.txtModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificacion.Location = new System.Drawing.Point(41, 140);
            this.txtModificacion.Name = "txtModificacion";
            this.txtModificacion.Size = new System.Drawing.Size(409, 31);
            this.txtModificacion.TabIndex = 17;
            this.txtModificacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtModificacion_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Punto_de_Venta.Properties.Resources.background;
            this.tabPage2.Controls.Add(this.dgConsulta);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtConsulta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 448);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgConsulta
            // 
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(19, 166);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.ReadOnly = true;
            this.dgConsulta.Size = new System.Drawing.Size(668, 276);
            this.dgConsulta.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica LT Std Cond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(221, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 46);
            this.label9.TabIndex = 24;
            this.label9.Text = "Consulta Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Producto";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(19, 129);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(668, 31);
            this.txtConsulta.TabIndex = 22;
            this.txtConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsulta_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(48, 372);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(250, 31);
            this.txtCodigo.TabIndex = 8;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Punto_de_Venta.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(742, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.tabControl1.ResumeLayout(false);
            this.Altas.ResumeLayout(false);
            this.Altas.PerformLayout();
            this.Bajas.ResumeLayout(false);
            this.Bajas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaja)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModificacion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Altas;
        private System.Windows.Forms.TabPage Bajas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBaja;
        private System.Windows.Forms.DataGridView dgModificacion;
        private System.Windows.Forms.Button btnModifiacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModificacion;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}