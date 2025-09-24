﻿namespace SistemAutomProcesoTitulacion
{
    partial class FrmMenuEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEstudiantes));
            this.tmrTransicionMenu = new System.Windows.Forms.Timer(this.components);
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinim = new System.Windows.Forms.PictureBox();
            this.btnDesliz = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEnvioDoc = new System.Windows.Forms.Panel();
            this.btnEnvioDoc = new System.Windows.Forms.Button();
            this.pnlReunion = new System.Windows.Forms.Panel();
            this.btnReunion = new System.Windows.Forms.Button();
            this.pnlAutoridades = new System.Windows.Forms.Panel();
            this.btnAutoridades = new System.Windows.Forms.Button();
            this.pnlEstadoProceso = new System.Windows.Forms.Panel();
            this.btnEstadoProceso = new System.Windows.Forms.Button();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.flpMenu.SuspendLayout();
            this.pnlEnvioDoc.SuspendLayout();
            this.pnlReunion.SuspendLayout();
            this.pnlAutoridades.SuspendLayout();
            this.pnlEstadoProceso.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCabecera.Controls.Add(this.btnRestaurar);
            this.panelCabecera.Controls.Add(this.btnMinim);
            this.panelCabecera.Controls.Add(this.btnDesliz);
            this.panelCabecera.Controls.Add(this.btnCerrar);
            this.panelCabecera.Controls.Add(this.btnMaximizar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(959, 33);
            this.panelCabecera.TabIndex = 11;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecera_MouseDown_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(910, 1);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 24);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnMinim
            // 
            this.btnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(883, 1);
            this.btnMinim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(22, 24);
            this.btnMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinim.TabIndex = 4;
            this.btnMinim.TabStop = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click_1);
            // 
            // btnDesliz
            // 
            this.btnDesliz.Image = ((System.Drawing.Image)(resources.GetObject("btnDesliz.Image")));
            this.btnDesliz.Location = new System.Drawing.Point(2, 2);
            this.btnDesliz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesliz.Name = "btnDesliz";
            this.btnDesliz.Size = new System.Drawing.Size(26, 28);
            this.btnDesliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDesliz.TabIndex = 0;
            this.btnDesliz.TabStop = false;
            this.btnDesliz.Click += new System.EventHandler(this.btnDesliz_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SistemAutomProcesoTitulacion.Properties.Resources.letra_x;
            this.btnCerrar.Location = new System.Drawing.Point(935, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(908, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(22, 24);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.Green;
            this.flpMenu.Controls.Add(this.pnlEnvioDoc);
            this.flpMenu.Controls.Add(this.pnlReunion);
            this.flpMenu.Controls.Add(this.pnlAutoridades);
            this.flpMenu.Controls.Add(this.pnlEstadoProceso);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.Location = new System.Drawing.Point(0, 33);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(245, 456);
            this.flpMenu.TabIndex = 13;
            // 
            // pnlEnvioDoc
            // 
            this.pnlEnvioDoc.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEnvioDoc.Controls.Add(this.btnEnvioDoc);
            this.pnlEnvioDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEnvioDoc.Location = new System.Drawing.Point(0, 0);
            this.pnlEnvioDoc.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEnvioDoc.Name = "pnlEnvioDoc";
            this.pnlEnvioDoc.Size = new System.Drawing.Size(245, 45);
            this.pnlEnvioDoc.TabIndex = 7;
            // 
            // btnEnvioDoc
            // 
            this.btnEnvioDoc.BackColor = System.Drawing.Color.Green;
            this.btnEnvioDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEnvioDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvioDoc.ForeColor = System.Drawing.Color.White;
            this.btnEnvioDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvioDoc.Location = new System.Drawing.Point(-4, -4);
            this.btnEnvioDoc.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnvioDoc.Name = "btnEnvioDoc";
            this.btnEnvioDoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEnvioDoc.Size = new System.Drawing.Size(253, 53);
            this.btnEnvioDoc.TabIndex = 1;
            this.btnEnvioDoc.Text = "Envio de Documentos";
            this.btnEnvioDoc.UseVisualStyleBackColor = false;
            this.btnEnvioDoc.Click += new System.EventHandler(this.btnEnvioDoc_Click);
            // 
            // pnlReunion
            // 
            this.pnlReunion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReunion.Controls.Add(this.btnReunion);
            this.pnlReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReunion.Location = new System.Drawing.Point(0, 45);
            this.pnlReunion.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReunion.Name = "pnlReunion";
            this.pnlReunion.Size = new System.Drawing.Size(245, 45);
            this.pnlReunion.TabIndex = 9;
            // 
            // btnReunion
            // 
            this.btnReunion.BackColor = System.Drawing.Color.Green;
            this.btnReunion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.ForeColor = System.Drawing.Color.White;
            this.btnReunion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReunion.Location = new System.Drawing.Point(-4, -4);
            this.btnReunion.Margin = new System.Windows.Forms.Padding(0);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReunion.Size = new System.Drawing.Size(253, 53);
            this.btnReunion.TabIndex = 1;
            this.btnReunion.Text = "Reuniones";
            this.btnReunion.UseVisualStyleBackColor = false;
            this.btnReunion.Click += new System.EventHandler(this.btnReunion_Click);
            // 
            // pnlAutoridades
            // 
            this.pnlAutoridades.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAutoridades.Controls.Add(this.btnAutoridades);
            this.pnlAutoridades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAutoridades.Location = new System.Drawing.Point(0, 90);
            this.pnlAutoridades.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAutoridades.Name = "pnlAutoridades";
            this.pnlAutoridades.Size = new System.Drawing.Size(245, 45);
            this.pnlAutoridades.TabIndex = 6;
            // 
            // btnAutoridades
            // 
            this.btnAutoridades.BackColor = System.Drawing.Color.Green;
            this.btnAutoridades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoridades.ForeColor = System.Drawing.Color.White;
            this.btnAutoridades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoridades.Location = new System.Drawing.Point(-4, -4);
            this.btnAutoridades.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoridades.Name = "btnAutoridades";
            this.btnAutoridades.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAutoridades.Size = new System.Drawing.Size(253, 53);
            this.btnAutoridades.TabIndex = 1;
            this.btnAutoridades.Text = "Autoridades";
            this.btnAutoridades.UseVisualStyleBackColor = false;
            // 
            // pnlEstadoProceso
            // 
            this.pnlEstadoProceso.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEstadoProceso.Controls.Add(this.btnEstadoProceso);
            this.pnlEstadoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstadoProceso.Location = new System.Drawing.Point(0, 135);
            this.pnlEstadoProceso.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEstadoProceso.Name = "pnlEstadoProceso";
            this.pnlEstadoProceso.Size = new System.Drawing.Size(245, 45);
            this.pnlEstadoProceso.TabIndex = 8;
            // 
            // btnEstadoProceso
            // 
            this.btnEstadoProceso.BackColor = System.Drawing.Color.Green;
            this.btnEstadoProceso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoProceso.ForeColor = System.Drawing.Color.White;
            this.btnEstadoProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadoProceso.Location = new System.Drawing.Point(-4, -4);
            this.btnEstadoProceso.Margin = new System.Windows.Forms.Padding(0);
            this.btnEstadoProceso.Name = "btnEstadoProceso";
            this.btnEstadoProceso.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstadoProceso.Size = new System.Drawing.Size(253, 53);
            this.btnEstadoProceso.TabIndex = 1;
            this.btnEstadoProceso.Text = "Estado del Proceso";
            this.btnEstadoProceso.UseVisualStyleBackColor = false;
            // 
            // panelInformacion
            // 
            this.panelInformacion.Controls.Add(this.lblLogOut);
            this.panelInformacion.Controls.Add(this.pictureBox1);
            this.panelInformacion.Controls.Add(this.lblRol);
            this.panelInformacion.Controls.Add(this.lblNombre);
            this.panelInformacion.Controls.Add(this.pictureBox2);
            this.panelInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformacion.Location = new System.Drawing.Point(245, 33);
            this.panelInformacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(714, 38);
            this.panelInformacion.TabIndex = 21;
            this.panelInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInformacion_Paint);
            // 
            // lblLogOut
            // 
            this.lblLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Century Gothic", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Green;
            this.lblLogOut.Location = new System.Drawing.Point(638, 6);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(44, 30);
            this.lblLogOut.TabIndex = 11;
            this.lblLogOut.Text = "Cerrar \r\nsesión";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(44, 21);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 13);
            this.lblRol.TabIndex = 9;
            this.lblRol.Text = "label2";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 5);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "label1";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(245, 71);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(714, 418);
            this.panelContenedor.TabIndex = 22;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // FrmMenuEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 489);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMenuEstudiantes";
            this.Text = "Menu Estudiantes";
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.flpMenu.ResumeLayout(false);
            this.pnlEnvioDoc.ResumeLayout(false);
            this.pnlReunion.ResumeLayout(false);
            this.pnlAutoridades.ResumeLayout(false);
            this.pnlEstadoProceso.ResumeLayout(false);
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTransicionMenu;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinim;
        private System.Windows.Forms.PictureBox btnDesliz;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel pnlEnvioDoc;
        private System.Windows.Forms.Button btnEnvioDoc;
        private System.Windows.Forms.Panel pnlReunion;
        private System.Windows.Forms.Button btnReunion;
        private System.Windows.Forms.Panel pnlEstadoProceso;
        private System.Windows.Forms.Button btnEstadoProceso;
        private System.Windows.Forms.Panel pnlAutoridades;
        private System.Windows.Forms.Button btnAutoridades;
        public System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel panelContenedor;
    }
}