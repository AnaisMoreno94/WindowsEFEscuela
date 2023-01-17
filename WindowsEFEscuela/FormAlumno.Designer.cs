namespace WindowsEFEscuela
{
    partial class FormAlumno
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
            this.gridAlumno = new System.Windows.Forms.DataGridView();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlumno
            // 
            this.gridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumno.Location = new System.Drawing.Point(93, 198);
            this.gridAlumno.Name = "gridAlumno";
            this.gridAlumno.RowHeadersWidth = 51;
            this.gridAlumno.RowTemplate.Height = 24;
            this.gridAlumno.Size = new System.Drawing.Size(654, 150);
            this.gridAlumno.TabIndex = 17;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(162, 147);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(122, 22);
            this.textNombre.TabIndex = 16;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(162, 95);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(122, 22);
            this.textId.TabIndex = 15;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(589, 44);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarId.TabIndex = 14;
            this.btnBuscarId.Text = "Buscar con ID";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(448, 44);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(297, 44);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(152, 44);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(112, 23);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridAlumno);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlumno";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAlumno;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}