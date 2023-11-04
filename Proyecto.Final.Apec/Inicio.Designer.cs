namespace Proyecto.Final.Apec
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            inmueblesBtn = new Button();
            propietariosBtn = new Button();
            clientesBtn = new Button();
            lblTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // inmueblesBtn
            // 
            inmueblesBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inmueblesBtn.Location = new Point(324, 231);
            inmueblesBtn.Margin = new Padding(3, 4, 3, 4);
            inmueblesBtn.Name = "inmueblesBtn";
            inmueblesBtn.Size = new Size(270, 91);
            inmueblesBtn.TabIndex = 0;
            inmueblesBtn.Text = "Inmuebles";
            inmueblesBtn.UseVisualStyleBackColor = true;
            inmueblesBtn.Click += inmueblesButton_Click;
            // 
            // propietariosBtn
            // 
            propietariosBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            propietariosBtn.Location = new Point(324, 369);
            propietariosBtn.Margin = new Padding(3, 4, 3, 4);
            propietariosBtn.Name = "propietariosBtn";
            propietariosBtn.Size = new Size(270, 86);
            propietariosBtn.TabIndex = 1;
            propietariosBtn.Text = "Propietarios";
            propietariosBtn.UseVisualStyleBackColor = true;
            propietariosBtn.Click += propietariosBtn_Click;
            // 
            // clientesBtn
            // 
            clientesBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            clientesBtn.Location = new Point(324, 498);
            clientesBtn.Margin = new Padding(3, 4, 3, 4);
            clientesBtn.Name = "clientesBtn";
            clientesBtn.Size = new Size(270, 79);
            clientesBtn.TabIndex = 2;
            clientesBtn.Text = "Clientes";
            clientesBtn.UseVisualStyleBackColor = true;
            clientesBtn.Click += clientesButton_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.Location = new Point(304, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 97);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "HabitArt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 123);
            label1.Name = "label1";
            label1.Size = new Size(417, 28);
            label1.TabIndex = 4;
            label1.Text = "\"Cada propiedad, una obra de arte.\"";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 646);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(clientesBtn);
            Controls.Add(propietariosBtn);
            Controls.Add(inmueblesBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inmueblesBtn;
        private Button propietariosBtn;
        private Button clientesBtn;
        private Label lblTitle;
        private Label label1;
    }
}