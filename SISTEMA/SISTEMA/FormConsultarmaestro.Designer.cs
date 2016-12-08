namespace SISTEMA
{
    partial class FormConsultarmaestro
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Idmaestro = new System.Windows.Forms.TextBox();
            this.txt_Nombremaestro = new System.Windows.Forms.TextBox();
            this.txt_Apellidopatm = new System.Windows.Forms.TextBox();
            this.btn_Buscarid = new System.Windows.Forms.Button();
            this.btn_Buscarnombr = new System.Windows.Forms.Button();
            this.btn_Buscartodo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Consultar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 300);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 0;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Maestro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Paterno";
            // 
            // txt_Idmaestro
            // 
            this.txt_Idmaestro.Location = new System.Drawing.Point(47, 64);
            this.txt_Idmaestro.Name = "txt_Idmaestro";
            this.txt_Idmaestro.Size = new System.Drawing.Size(100, 20);
            this.txt_Idmaestro.TabIndex = 4;
            // 
            // txt_Nombremaestro
            // 
            this.txt_Nombremaestro.Location = new System.Drawing.Point(277, 64);
            this.txt_Nombremaestro.Name = "txt_Nombremaestro";
            this.txt_Nombremaestro.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombremaestro.TabIndex = 5;
            // 
            // txt_Apellidopatm
            // 
            this.txt_Apellidopatm.Location = new System.Drawing.Point(495, 64);
            this.txt_Apellidopatm.Name = "txt_Apellidopatm";
            this.txt_Apellidopatm.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellidopatm.TabIndex = 6;
            // 
            // btn_Buscarid
            // 
            this.btn_Buscarid.Location = new System.Drawing.Point(154, 300);
            this.btn_Buscarid.Name = "btn_Buscarid";
            this.btn_Buscarid.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscarid.TabIndex = 7;
            this.btn_Buscarid.Text = "Busca ID";
            this.btn_Buscarid.UseVisualStyleBackColor = true;
            this.btn_Buscarid.Click += new System.EventHandler(this.btn_Buscarid_Click);
            // 
            // btn_Buscarnombr
            // 
            this.btn_Buscarnombr.Location = new System.Drawing.Point(311, 300);
            this.btn_Buscarnombr.Name = "btn_Buscarnombr";
            this.btn_Buscarnombr.Size = new System.Drawing.Size(143, 23);
            this.btn_Buscarnombr.TabIndex = 8;
            this.btn_Buscarnombr.Text = "Buscar Nombre/Apellido";
            this.btn_Buscarnombr.UseVisualStyleBackColor = true;
            this.btn_Buscarnombr.Click += new System.EventHandler(this.btn_Buscarnombr_Click);
            // 
            // btn_Buscartodo
            // 
            this.btn_Buscartodo.Location = new System.Drawing.Point(495, 300);
            this.btn_Buscartodo.Name = "btn_Buscartodo";
            this.btn_Buscartodo.Size = new System.Drawing.Size(100, 23);
            this.btn_Buscartodo.TabIndex = 9;
            this.btn_Buscartodo.Text = "Buscar Todos";
            this.btn_Buscartodo.UseVisualStyleBackColor = true;
            this.btn_Buscartodo.Click += new System.EventHandler(this.btn_Buscartodo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 109);
            this.dataGridView1.TabIndex = 10;
            // 
            // lbl_Consultar
            // 
            this.lbl_Consultar.AutoSize = true;
            this.lbl_Consultar.Location = new System.Drawing.Point(151, 9);
            this.lbl_Consultar.Name = "lbl_Consultar";
            this.lbl_Consultar.Size = new System.Drawing.Size(92, 13);
            this.lbl_Consultar.TabIndex = 11;
            this.lbl_Consultar.Text = "Consultar Maestro";
            // 
            // FormConsultarmaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 335);
            this.Controls.Add(this.lbl_Consultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Buscartodo);
            this.Controls.Add(this.btn_Buscarnombr);
            this.Controls.Add(this.btn_Buscarid);
            this.Controls.Add(this.txt_Apellidopatm);
            this.Controls.Add(this.txt_Nombremaestro);
            this.Controls.Add(this.txt_Idmaestro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Name = "FormConsultarmaestro";
            this.Text = "Consultar Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Idmaestro;
        private System.Windows.Forms.TextBox txt_Nombremaestro;
        private System.Windows.Forms.TextBox txt_Apellidopatm;
        private System.Windows.Forms.Button btn_Buscarid;
        private System.Windows.Forms.Button btn_Buscarnombr;
        private System.Windows.Forms.Button btn_Buscartodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Consultar;
    }
}