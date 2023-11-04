namespace CapaVisual
{
    partial class Propietarios
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            appDbContextBindingSource = new BindingSource(components);
            DGridViewPropietarios = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            propietarioBindingSource = new BindingSource(components);
            lblBuscarP = new Label();
            txtSearchPropietario = new TextBox();
            btnBuscarPropietario = new Button();
            btnAgregarPropietario = new Button();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGridViewPropietarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propietarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(AppDbContext);
            // 
            // DGridViewPropietarios
            // 
            DGridViewPropietarios.AllowUserToAddRows = false;
            DGridViewPropietarios.AllowUserToDeleteRows = false;
            DGridViewPropietarios.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGridViewPropietarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGridViewPropietarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGridViewPropietarios.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn });
            DGridViewPropietarios.DataSource = propietarioBindingSource;
            DGridViewPropietarios.Location = new Point(39, 159);
            DGridViewPropietarios.Margin = new Padding(5);
            DGridViewPropietarios.Name = "DGridViewPropietarios";
            DGridViewPropietarios.RowHeadersWidth = 51;
            DGridViewPropietarios.RowTemplate.Height = 29;
            DGridViewPropietarios.Size = new Size(802, 217);
            DGridViewPropietarios.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // propietarioBindingSource
            // 
            propietarioBindingSource.DataSource = typeof(DataAccess.Propietario);
            // 
            // lblBuscarP
            // 
            lblBuscarP.AutoSize = true;
            lblBuscarP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarP.Location = new Point(39, 46);
            lblBuscarP.Name = "lblBuscarP";
            lblBuscarP.Size = new Size(68, 28);
            lblBuscarP.TabIndex = 1;
            lblBuscarP.Text = "Buscar";
            // 
            // txtSearchPropietario
            // 
            txtSearchPropietario.Location = new Point(113, 50);
            txtSearchPropietario.Name = "txtSearchPropietario";
            txtSearchPropietario.Size = new Size(488, 27);
            txtSearchPropietario.TabIndex = 2;
            // 
            // btnBuscarPropietario
            // 
            btnBuscarPropietario.Location = new Point(618, 50);
            btnBuscarPropietario.Name = "btnBuscarPropietario";
            btnBuscarPropietario.Size = new Size(77, 27);
            btnBuscarPropietario.TabIndex = 3;
            btnBuscarPropietario.Text = "Buscar";
            btnBuscarPropietario.UseVisualStyleBackColor = true;
            btnBuscarPropietario.Click += btnBuscarPropietario_Click;
            // 
            // btnAgregarPropietario
            // 
            btnAgregarPropietario.Location = new Point(701, 50);
            btnAgregarPropietario.Name = "btnAgregarPropietario";
            btnAgregarPropietario.Size = new Size(77, 27);
            btnAgregarPropietario.TabIndex = 4;
            btnAgregarPropietario.Text = "Agregar";
            btnAgregarPropietario.UseVisualStyleBackColor = true;
            btnAgregarPropietario.Click += btnAgregarPropietario_Click;
            // 
            // Propietarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 563);
            Controls.Add(btnAgregarPropietario);
            Controls.Add(btnBuscarPropietario);
            Controls.Add(txtSearchPropietario);
            Controls.Add(lblBuscarP);
            Controls.Add(DGridViewPropietarios);
            Name = "Propietarios";
            Text = "Propietarios";
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGridViewPropietarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)propietarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource appDbContextBindingSource;
        private DataGridView DGridViewPropietarios;
        private BindingSource propietarioBindingSource;
        private Label lblBuscarP;
        private TextBox txtSearchPropietario;
        private Button btnBuscarPropietario;
        private Button btnAgregarPropietario;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
    }
}