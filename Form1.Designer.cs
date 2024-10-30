namespace AppArraysss
{
    partial class Form1
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
            btnLeerDatos = new Button();
            lsbDatos = new ListBox();
            label1 = new Label();
            lblPromedio = new Label();
            label2 = new Label();
            lblMenor = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(41, 39);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(180, 49);
            btnLeerDatos.TabIndex = 0;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // lsbDatos
            // 
            lsbDatos.FormattingEnabled = true;
            lsbDatos.ItemHeight = 25;
            lsbDatos.Location = new Point(41, 107);
            lsbDatos.Name = "lsbDatos";
            lsbDatos.Size = new Size(180, 304);
            lsbDatos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 427);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 2;
            label1.Text = "Promedio Grupo:";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(167, 427);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(109, 25);
            lblPromedio.TabIndex = 3;
            lblPromedio.Text = "lblPromedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 462);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 4;
            label2.Text = "Calificacion Menor:";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(179, 462);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(83, 25);
            lblMenor.TabIndex = 5;
            lblMenor.Text = "lblMenor";
            // 
            // button1
            // 
            button1.Location = new Point(255, 68);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 511);
            Controls.Add(button1);
            Controls.Add(lblMenor);
            Controls.Add(label2);
            Controls.Add(lblPromedio);
            Controls.Add(label1);
            Controls.Add(lsbDatos);
            Controls.Add(btnLeerDatos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerDatos;
        private ListBox lsbDatos;
        private Label label1;
        private Label lblPromedio;
        private Label label2;
        private Label lblMenor;
        private Button button1;
    }
}
