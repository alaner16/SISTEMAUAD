namespace SISTEMA
{
    partial class FormModificaralumno
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
            this.btn_regresar_alumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_regresar_alumno
            // 
            this.btn_regresar_alumno.Location = new System.Drawing.Point(12, 226);
            this.btn_regresar_alumno.Name = "btn_regresar_alumno";
            this.btn_regresar_alumno.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar_alumno.TabIndex = 13;
            this.btn_regresar_alumno.Text = "REGRESAR";
            this.btn_regresar_alumno.UseVisualStyleBackColor = true;
            this.btn_regresar_alumno.Click += new System.EventHandler(this.btn_regresar_alumno_Click);
            // 
            // FormModificaralumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_regresar_alumno);
            this.Name = "FormModificaralumno";
            this.Text = "Formmodificaralumno2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar_alumno;
    }
}