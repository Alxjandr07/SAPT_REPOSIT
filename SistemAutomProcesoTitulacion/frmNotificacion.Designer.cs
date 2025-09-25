namespace SistemAutomProcesoTitulacion
{
    partial class frmNotificacion
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnNoLeido = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvNotificacion = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 48);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Redactar Mensaje";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(671, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "UTEQ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnNoLeido);
            this.panel1.Controls.Add(this.btnTodo);
            this.panel1.Controls.Add(this.panelNotificacion);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 286);
            this.panel1.TabIndex = 22;
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.dgvNotificacion);
            this.panelNotificacion.Location = new System.Drawing.Point(3, 3);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(522, 229);
            this.panelNotificacion.TabIndex = 17;
            // 
            // btnTodo
            // 
            this.btnTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTodo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTodo.FlatAppearance.BorderSize = 2;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.ForeColor = System.Drawing.Color.Green;
            this.btnTodo.Location = new System.Drawing.Point(3, 238);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(104, 43);
            this.btnTodo.TabIndex = 18;
            this.btnTodo.Text = "Todos";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnNoLeido
            // 
            this.btnNoLeido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNoLeido.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnNoLeido.FlatAppearance.BorderSize = 2;
            this.btnNoLeido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoLeido.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoLeido.ForeColor = System.Drawing.Color.Green;
            this.btnNoLeido.Location = new System.Drawing.Point(113, 238);
            this.btnNoLeido.Name = "btnNoLeido";
            this.btnNoLeido.Size = new System.Drawing.Size(104, 43);
            this.btnNoLeido.TabIndex = 19;
            this.btnNoLeido.Text = "No leidos";
            this.btnNoLeido.UseVisualStyleBackColor = true;
            this.btnNoLeido.Click += new System.EventHandler(this.btnNoLeido_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(421, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 43);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvNotificacion
            // 
            this.dgvNotificacion.AllowUserToAddRows = false;
            this.dgvNotificacion.AllowUserToDeleteRows = false;
            this.dgvNotificacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotificacion.Location = new System.Drawing.Point(0, 0);
            this.dgvNotificacion.Name = "dgvNotificacion";
            this.dgvNotificacion.ReadOnly = true;
            this.dgvNotificacion.Size = new System.Drawing.Size(520, 227);
            this.dgvNotificacion.TabIndex = 0;
            this.dgvNotificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotificacion_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.txtAsunto);
            this.panel2.Controls.Add(this.txtPara);
            this.panel2.Controls.Add(this.txtMensaje);
            this.panel2.Location = new System.Drawing.Point(548, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 286);
            this.panel2.TabIndex = 23;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensaje.Location = new System.Drawing.Point(3, 55);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(232, 177);
            this.txtMensaje.TabIndex = 0;
            // 
            // txtPara
            // 
            this.txtPara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPara.Location = new System.Drawing.Point(3, 3);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(232, 20);
            this.txtPara.TabIndex = 24;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnVer.FlatAppearance.BorderSize = 2;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Green;
            this.btnVer.Location = new System.Drawing.Point(223, 238);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(104, 43);
            this.btnVer.TabIndex = 21;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.Location = new System.Drawing.Point(3, 29);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(232, 20);
            this.txtAsunto.TabIndex = 25;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirmar.FlatAppearance.BorderSize = 2;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmar.Location = new System.Drawing.Point(131, 238);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(104, 43);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotificacion";
            this.Text = "frmNotificacion";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Button btnNoLeido;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvNotificacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtAsunto;
    }
}