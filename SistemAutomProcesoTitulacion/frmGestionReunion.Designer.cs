namespace SistemAutomProcesoTitulacion
{
    partial class frmGestionReunion
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEliminarReuniones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReuniones = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLugarReunion = new System.Windows.Forms.TextBox();
            this.lblTituloLugarReunion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(-12, -8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(14, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 150);
            this.panel1.TabIndex = 5;
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcar.Location = new System.Drawing.Point(14, 259);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(117, 23);
            this.btnMarcar.TabIndex = 6;
            this.btnMarcar.Text = "AsignarReunion";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesmarcar.Location = new System.Drawing.Point(147, 259);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(133, 23);
            this.btnDesmarcar.TabIndex = 7;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensaje.Location = new System.Drawing.Point(457, 92);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(114, 13);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Sin Reuniones Activas";
            // 
            // btnEliminarReuniones
            // 
            this.btnEliminarReuniones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarReuniones.Location = new System.Drawing.Point(300, 259);
            this.btnEliminarReuniones.Name = "btnEliminarReuniones";
            this.btnEliminarReuniones.Size = new System.Drawing.Size(117, 23);
            this.btnEliminarReuniones.TabIndex = 9;
            this.btnEliminarReuniones.Text = "Eliminar Reuniones Programadas";
            this.btnEliminarReuniones.UseVisualStyleBackColor = true;
            this.btnEliminarReuniones.Click += new System.EventHandler(this.btnEliminarReuniones_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 34);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reuniones";
            // 
            // lblReuniones
            // 
            this.lblReuniones.AutoSize = true;
            this.lblReuniones.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReuniones.ForeColor = System.Drawing.Color.Black;
            this.lblReuniones.Location = new System.Drawing.Point(455, 66);
            this.lblReuniones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReuniones.Name = "lblReuniones";
            this.lblReuniones.Size = new System.Drawing.Size(206, 26);
            this.lblReuniones.TabIndex = 11;
            this.lblReuniones.Text = "Reuniones Activas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 45);
            this.panel3.TabIndex = 12;
            // 
            // txtLugarReunion
            // 
            this.txtLugarReunion.Location = new System.Drawing.Point(16, 73);
            this.txtLugarReunion.Name = "txtLugarReunion";
            this.txtLugarReunion.Size = new System.Drawing.Size(100, 20);
            this.txtLugarReunion.TabIndex = 5;
            this.txtLugarReunion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTituloLugarReunion
            // 
            this.lblTituloLugarReunion.AutoSize = true;
            this.lblTituloLugarReunion.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLugarReunion.ForeColor = System.Drawing.Color.Black;
            this.lblTituloLugarReunion.Location = new System.Drawing.Point(11, 42);
            this.lblTituloLugarReunion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloLugarReunion.Name = "lblTituloLugarReunion";
            this.lblTituloLugarReunion.Size = new System.Drawing.Size(198, 26);
            this.lblTituloLugarReunion.TabIndex = 15;
            this.lblTituloLugarReunion.Text = "Lugar de Reunion";
            // 
            // frmGestionReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.lblTituloLugarReunion);
            this.Controls.Add(this.txtLugarReunion);
            this.Controls.Add(this.lblReuniones);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarReuniones);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionReunion";
            this.Text = "frmGestionReunion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEliminarReuniones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReuniones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLugarReunion;
        private System.Windows.Forms.Label lblTituloLugarReunion;
    }
}