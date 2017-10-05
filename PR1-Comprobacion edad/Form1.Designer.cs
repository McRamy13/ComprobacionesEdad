namespace PR1_Comprobacion_edad
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.groupBoxDiaSemana = new System.Windows.Forms.GroupBox();
            this.rbDomingo = new System.Windows.Forms.RadioButton();
            this.rbMiercoles = new System.Windows.Forms.RadioButton();
            this.rbJueves = new System.Windows.Forms.RadioButton();
            this.rbSabado = new System.Windows.Forms.RadioButton();
            this.rbViernes = new System.Windows.Forms.RadioButton();
            this.rbMartes = new System.Windows.Forms.RadioButton();
            this.rbLunes = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBoxDiaSemana.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(90, 90);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(90, 48);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(95, 32);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(95, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Introduzca la edad";
            // 
            // groupBoxDiaSemana
            // 
            this.groupBoxDiaSemana.Controls.Add(this.rbDomingo);
            this.groupBoxDiaSemana.Controls.Add(this.rbMiercoles);
            this.groupBoxDiaSemana.Controls.Add(this.rbJueves);
            this.groupBoxDiaSemana.Controls.Add(this.rbSabado);
            this.groupBoxDiaSemana.Controls.Add(this.rbViernes);
            this.groupBoxDiaSemana.Controls.Add(this.rbMartes);
            this.groupBoxDiaSemana.Controls.Add(this.rbLunes);
            this.groupBoxDiaSemana.Location = new System.Drawing.Point(6, 119);
            this.groupBoxDiaSemana.Name = "groupBoxDiaSemana";
            this.groupBoxDiaSemana.Size = new System.Drawing.Size(266, 100);
            this.groupBoxDiaSemana.TabIndex = 5;
            this.groupBoxDiaSemana.TabStop = false;
            // 
            // rbDomingo
            // 
            this.rbDomingo.AutoSize = true;
            this.rbDomingo.Location = new System.Drawing.Point(183, 54);
            this.rbDomingo.Name = "rbDomingo";
            this.rbDomingo.Size = new System.Drawing.Size(67, 17);
            this.rbDomingo.TabIndex = 0;
            this.rbDomingo.TabStop = true;
            this.rbDomingo.Text = "Domingo";
            this.rbDomingo.UseVisualStyleBackColor = true;
            this.rbDomingo.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // rbMiercoles
            // 
            this.rbMiercoles.AutoSize = true;
            this.rbMiercoles.Location = new System.Drawing.Point(6, 66);
            this.rbMiercoles.Name = "rbMiercoles";
            this.rbMiercoles.Size = new System.Drawing.Size(70, 17);
            this.rbMiercoles.TabIndex = 0;
            this.rbMiercoles.TabStop = true;
            this.rbMiercoles.Text = "Miércoles";
            this.rbMiercoles.UseVisualStyleBackColor = true;
            this.rbMiercoles.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // rbJueves
            // 
            this.rbJueves.AutoSize = true;
            this.rbJueves.Location = new System.Drawing.Point(92, 31);
            this.rbJueves.Name = "rbJueves";
            this.rbJueves.Size = new System.Drawing.Size(59, 17);
            this.rbJueves.TabIndex = 0;
            this.rbJueves.TabStop = true;
            this.rbJueves.Text = "Jueves";
            this.rbJueves.UseVisualStyleBackColor = true;
            this.rbJueves.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // rbSabado
            // 
            this.rbSabado.AutoSize = true;
            this.rbSabado.Location = new System.Drawing.Point(183, 31);
            this.rbSabado.Name = "rbSabado";
            this.rbSabado.Size = new System.Drawing.Size(62, 17);
            this.rbSabado.TabIndex = 0;
            this.rbSabado.TabStop = true;
            this.rbSabado.Text = "Sábado";
            this.rbSabado.UseVisualStyleBackColor = true;
            this.rbSabado.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // rbViernes
            // 
            this.rbViernes.AutoSize = true;
            this.rbViernes.Location = new System.Drawing.Point(92, 54);
            this.rbViernes.Name = "rbViernes";
            this.rbViernes.Size = new System.Drawing.Size(60, 17);
            this.rbViernes.TabIndex = 0;
            this.rbViernes.TabStop = true;
            this.rbViernes.Text = "Viernes";
            this.rbViernes.UseVisualStyleBackColor = true;
            this.rbViernes.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // rbMartes
            // 
            this.rbMartes.AutoSize = true;
            this.rbMartes.Location = new System.Drawing.Point(6, 43);
            this.rbMartes.Name = "rbMartes";
            this.rbMartes.Size = new System.Drawing.Size(57, 17);
            this.rbMartes.TabIndex = 0;
            this.rbMartes.TabStop = true;
            this.rbMartes.Text = "Martes";
            this.rbMartes.UseVisualStyleBackColor = true;
            this.rbMartes.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // rbLunes
            // 
            this.rbLunes.AutoSize = true;
            this.rbLunes.Checked = true;
            this.rbLunes.Location = new System.Drawing.Point(7, 20);
            this.rbLunes.Name = "rbLunes";
            this.rbLunes.Size = new System.Drawing.Size(54, 17);
            this.rbLunes.TabIndex = 0;
            this.rbLunes.TabStop = true;
            this.rbLunes.Text = "Lunes";
            this.rbLunes.UseVisualStyleBackColor = true;
            this.rbLunes.CheckedChanged += new System.EventHandler(this.rbSabado_CheckedChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 222);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBoxDiaSemana);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDiaSemana.ResumeLayout(false);
            this.groupBoxDiaSemana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox groupBoxDiaSemana;
        private System.Windows.Forms.RadioButton rbDomingo;
        private System.Windows.Forms.RadioButton rbMiercoles;
        private System.Windows.Forms.RadioButton rbJueves;
        private System.Windows.Forms.RadioButton rbSabado;
        private System.Windows.Forms.RadioButton rbViernes;
        private System.Windows.Forms.RadioButton rbMartes;
        private System.Windows.Forms.RadioButton rbLunes;
        private System.Windows.Forms.Label lblResultado;
    }
}

