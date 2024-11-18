namespace taller_2_2024
{
    partial class menuPrincipal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonProd = new Button();
            buttonCli = new Button();
            buttonVent = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(158, 34);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la sede: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(351, 34);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 1;
            label2.Text = "Antofagasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(96, 111);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(295, 111);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Clientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(494, 111);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 4;
            label5.Text = "Ventas";
            // 
            // buttonProd
            // 
            buttonProd.Location = new Point(110, 170);
            buttonProd.Name = "buttonProd";
            buttonProd.Size = new Size(75, 23);
            buttonProd.TabIndex = 5;
            buttonProd.Text = "Ir";
            buttonProd.UseVisualStyleBackColor = true;
            buttonProd.Click += buttonProd_Click;
            // 
            // buttonCli
            // 
            buttonCli.Location = new Point(300, 170);
            buttonCli.Name = "buttonCli";
            buttonCli.Size = new Size(75, 23);
            buttonCli.TabIndex = 6;
            buttonCli.Text = "Ir";
            buttonCli.UseVisualStyleBackColor = true;
            // 
            // buttonVent
            // 
            buttonVent.Location = new Point(488, 170);
            buttonVent.Name = "buttonVent";
            buttonVent.Size = new Size(75, 23);
            buttonVent.TabIndex = 7;
            buttonVent.Text = "Ir";
            buttonVent.UseVisualStyleBackColor = true;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 304);
            Controls.Add(buttonVent);
            Controls.Add(buttonCli);
            Controls.Add(buttonProd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "menuPrincipal";
            Text = "menuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonProd;
        private Button buttonCli;
        private Button buttonVent;
    }
}