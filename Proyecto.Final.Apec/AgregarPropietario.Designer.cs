namespace CapaVisual
{
    partial class AgregarPropietario
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
            GBPropietario = new GroupBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            txtCedPropietario = new TextBox();
            txtTelPropieatrio = new TextBox();
            txtNamePropietario = new TextBox();
            lblCedula = new Label();
            lblTelPropietario = new Label();
            lblNamePropietario = new Label();
            GBPropietario.SuspendLayout();
            SuspendLayout();
            // 
            // GBPropietario
            // 
            GBPropietario.Controls.Add(btnCancelar);
            GBPropietario.Controls.Add(btnAgregar);
            GBPropietario.Controls.Add(txtCedPropietario);
            GBPropietario.Controls.Add(txtTelPropieatrio);
            GBPropietario.Controls.Add(txtNamePropietario);
            GBPropietario.Controls.Add(lblCedula);
            GBPropietario.Controls.Add(lblTelPropietario);
            GBPropietario.Controls.Add(lblNamePropietario);
            GBPropietario.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GBPropietario.Location = new Point(103, 58);
            GBPropietario.Name = "GBPropietario";
            GBPropietario.Size = new Size(575, 460);
            GBPropietario.TabIndex = 0;
            GBPropietario.TabStop = false;
            GBPropietario.Text = "Propietario";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(454, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(352, 397);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCedPropietario
            // 
            txtCedPropietario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedPropietario.Location = new Point(171, 284);
            txtCedPropietario.Name = "txtCedPropietario";
            txtCedPropietario.Size = new Size(331, 38);
            txtCedPropietario.TabIndex = 5;
            // 
            // txtTelPropieatrio
            // 
            txtTelPropieatrio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelPropieatrio.Location = new Point(171, 194);
            txtTelPropieatrio.Name = "txtTelPropieatrio";
            txtTelPropieatrio.Size = new Size(331, 38);
            txtTelPropieatrio.TabIndex = 4;
            // 
            // txtNamePropietario
            // 
            txtNamePropietario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamePropietario.Location = new Point(171, 114);
            txtNamePropietario.Name = "txtNamePropietario";
            txtNamePropietario.Size = new Size(331, 38);
            txtNamePropietario.TabIndex = 3;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCedula.Location = new Point(63, 289);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(72, 28);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cedula";
            // 
            // lblTelPropietario
            // 
            lblTelPropietario.AutoSize = true;
            lblTelPropietario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelPropietario.Location = new Point(63, 202);
            lblTelPropietario.Name = "lblTelPropietario";
            lblTelPropietario.Size = new Size(86, 28);
            lblTelPropietario.TabIndex = 1;
            lblTelPropietario.Text = "Telefono";
            // 
            // lblNamePropietario
            // 
            lblNamePropietario.AutoSize = true;
            lblNamePropietario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNamePropietario.Location = new Point(63, 116);
            lblNamePropietario.Name = "lblNamePropietario";
            lblNamePropietario.Size = new Size(85, 28);
            lblNamePropietario.TabIndex = 0;
            lblNamePropietario.Text = "Nombre";
            // 
            // AgregarPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(GBPropietario);
            Name = "AgregarPropietario";
            Text = "AgregarPropietario";
            GBPropietario.ResumeLayout(false);
            GBPropietario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GBPropietario;
        private Label lblCedula;
        private Label lblTelPropietario;
        private Label lblNamePropietario;
        private TextBox txtNamePropietario;
        private TextBox txtCedPropietario;
        private TextBox txtTelPropieatrio;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}