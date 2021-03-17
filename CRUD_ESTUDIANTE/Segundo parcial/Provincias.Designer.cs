namespace Segundo_parcial
{
    partial class provincias
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
            this.dgvprovincia = new System.Windows.Forms.DataGridView();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.ID_Provincias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid_provincia = new System.Windows.Forms.TextBox();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovincia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprovincia
            // 
            this.dgvprovincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprovincia.Location = new System.Drawing.Point(416, 73);
            this.dgvprovincia.Name = "dgvprovincia";
            this.dgvprovincia.Size = new System.Drawing.Size(325, 150);
            this.dgvprovincia.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(136, 305);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(278, 305);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(416, 305);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(563, 305);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // ID_Provincias
            // 
            this.ID_Provincias.AutoSize = true;
            this.ID_Provincias.Location = new System.Drawing.Point(87, 73);
            this.ID_Provincias.Name = "ID_Provincias";
            this.ID_Provincias.Size = new System.Drawing.Size(68, 13);
            this.ID_Provincias.TabIndex = 5;
            this.ID_Provincias.Text = "ID_Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Provincia";
            // 
            // txtid_provincia
            // 
            this.txtid_provincia.Location = new System.Drawing.Point(193, 73);
            this.txtid_provincia.Name = "txtid_provincia";
            this.txtid_provincia.Size = new System.Drawing.Size(100, 20);
            this.txtid_provincia.TabIndex = 7;
            // 
            // txtprovincia
            // 
            this.txtprovincia.Location = new System.Drawing.Point(193, 160);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(100, 20);
            this.txtprovincia.TabIndex = 8;
            // 
            // provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtprovincia);
            this.Controls.Add(this.txtid_provincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_Provincias);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.dgvprovincia);
            this.Name = "provincias";
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovincia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprovincia;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label ID_Provincias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid_provincia;
        private System.Windows.Forms.TextBox txtprovincia;
    }
}