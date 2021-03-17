namespace Segundo_parcial
{
    partial class Carrera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid_carrera = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.dgvcarreras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carrera";
            // 
            // txtid_carrera
            // 
            this.txtid_carrera.Location = new System.Drawing.Point(172, 51);
            this.txtid_carrera.Name = "txtid_carrera";
            this.txtid_carrera.Size = new System.Drawing.Size(100, 20);
            this.txtid_carrera.TabIndex = 2;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(172, 168);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(100, 20);
            this.txtcarrera.TabIndex = 3;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(326, 281);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 4;
            this.btnactualizar.Text = "Actualizar ";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(172, 281);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(642, 281);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 6;
            this.btnborrar.Text = "Eliminar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(488, 281);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Agregar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgvcarreras
            // 
            this.dgvcarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarreras.Location = new System.Drawing.Point(326, 51);
            this.dgvcarreras.Name = "dgvcarreras";
            this.dgvcarreras.Size = new System.Drawing.Size(361, 150);
            this.dgvcarreras.TabIndex = 8;
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvcarreras);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtid_carrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carrera";
            this.Text = "Carrera";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid_carrera;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgvcarreras;
    }
}