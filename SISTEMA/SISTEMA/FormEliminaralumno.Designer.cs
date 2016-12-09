namespace SISTEMA
{
    partial class FormEliminaralumno
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
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa CURP";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(147, 31);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 2;
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(147, 71);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(100, 20);
            this.txt_curp.TabIndex = 3;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(25, 114);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(200, 114);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // FormEliminaralumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 149);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_curp);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminaralumno";
            this.Text = "FormEliminaralumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}