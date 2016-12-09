namespace SISTEMA
{
    partial class FormConsultaralumno
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_Buscarcuenta = new System.Windows.Forms.Button();
            this.btn_Buscarnombre = new System.Windows.Forms.Button();
            this.btn_Buscartodo = new System.Windows.Forms.Button();
            this.lbl_Nocuenta = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellidopat = new System.Windows.Forms.Label();
            this.txt_Cuenta = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTAR";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 288);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Buscarcuenta
            // 
            this.btn_Buscarcuenta.Location = new System.Drawing.Point(128, 288);
            this.btn_Buscarcuenta.Name = "btn_Buscarcuenta";
            this.btn_Buscarcuenta.Size = new System.Drawing.Size(109, 23);
            this.btn_Buscarcuenta.TabIndex = 2;
            this.btn_Buscarcuenta.Text = "Buscar No-Cuenta";
            this.btn_Buscarcuenta.UseVisualStyleBackColor = true;
            this.btn_Buscarcuenta.Click += new System.EventHandler(this.btn_Buscarcuenta_Click);
            // 
            // btn_Buscarnombre
            // 
            this.btn_Buscarnombre.Location = new System.Drawing.Point(295, 288);
            this.btn_Buscarnombre.Name = "btn_Buscarnombre";
            this.btn_Buscarnombre.Size = new System.Drawing.Size(101, 23);
            this.btn_Buscarnombre.TabIndex = 3;
            this.btn_Buscarnombre.Text = "Buscar Nombre";
            this.btn_Buscarnombre.UseVisualStyleBackColor = true;
            this.btn_Buscarnombre.Click += new System.EventHandler(this.btn_Buscarnombre_Click);
            // 
            // btn_Buscartodo
            // 
            this.btn_Buscartodo.Location = new System.Drawing.Point(444, 288);
            this.btn_Buscartodo.Name = "btn_Buscartodo";
            this.btn_Buscartodo.Size = new System.Drawing.Size(93, 23);
            this.btn_Buscartodo.TabIndex = 4;
            this.btn_Buscartodo.Text = "Buscar Todos";
            this.btn_Buscartodo.UseVisualStyleBackColor = true;
            this.btn_Buscartodo.Click += new System.EventHandler(this.btn_Buscartodo_Click);
            // 
            // lbl_Nocuenta
            // 
            this.lbl_Nocuenta.AutoSize = true;
            this.lbl_Nocuenta.Location = new System.Drawing.Point(31, 41);
            this.lbl_Nocuenta.Name = "lbl_Nocuenta";
            this.lbl_Nocuenta.Size = new System.Drawing.Size(61, 13);
            this.lbl_Nocuenta.TabIndex = 5;
            this.lbl_Nocuenta.Text = "No. Cuenta";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(215, 41);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellidopat
            // 
            this.lbl_Apellidopat.AutoSize = true;
            this.lbl_Apellidopat.Location = new System.Drawing.Point(379, 41);
            this.lbl_Apellidopat.Name = "lbl_Apellidopat";
            this.lbl_Apellidopat.Size = new System.Drawing.Size(84, 13);
            this.lbl_Apellidopat.TabIndex = 7;
            this.lbl_Apellidopat.Text = "Apellido Paterno";
            // 
            // txt_Cuenta
            // 
            this.txt_Cuenta.Location = new System.Drawing.Point(34, 67);
            this.txt_Cuenta.Name = "txt_Cuenta";
            this.txt_Cuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_Cuenta.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(207, 67);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(382, 67);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 122);
            this.dataGridView1.TabIndex = 11;
            // 
            // FormConsultaralumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Cuenta);
            this.Controls.Add(this.lbl_Apellidopat);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Nocuenta);
            this.Controls.Add(this.btn_Buscartodo);
            this.Controls.Add(this.btn_Buscarnombre);
            this.Controls.Add(this.btn_Buscarcuenta);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaralumno";
            this.Text = "Consultar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_Buscarcuenta;
        private System.Windows.Forms.Button btn_Buscarnombre;
        private System.Windows.Forms.Button btn_Buscartodo;
        private System.Windows.Forms.Label lbl_Nocuenta;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellidopat;
        private System.Windows.Forms.TextBox txt_Cuenta;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}