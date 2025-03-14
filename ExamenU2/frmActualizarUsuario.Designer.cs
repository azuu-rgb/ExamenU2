namespace ExamenU2
{
    partial class frmActualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarUsuario));
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAP = new TextBox();
            label4 = new Label();
            textBoxAM = new TextBox();
            label5 = new Label();
            textBoxNM = new TextBox();
            label6 = new Label();
            textBoxCRR = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(69, 179);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 0;
            textBoxID.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 171);
            label1.Name = "label1";
            label1.Size = new Size(47, 38);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(341, 303);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 3;
            label2.Text = "Telefono";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 213);
            label3.Name = "label3";
            label3.Size = new Size(242, 38);
            label3.TabIndex = 5;
            label3.Text = "Apellido Paterno";
            // 
            // textBoxAP
            // 
            textBoxAP.Location = new Point(16, 254);
            textBoxAP.Name = "textBoxAP";
            textBoxAP.Size = new Size(245, 31);
            textBoxAP.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(298, 213);
            label4.Name = "label4";
            label4.Size = new Size(248, 38);
            label4.TabIndex = 7;
            label4.Text = "Apellido Materno";
            // 
            // textBoxAM
            // 
            textBoxAM.Location = new Point(298, 254);
            textBoxAM.Name = "textBoxAM";
            textBoxAM.Size = new Size(247, 31);
            textBoxAM.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(557, 213);
            label5.Name = "label5";
            label5.Size = new Size(124, 38);
            label5.TabIndex = 9;
            label5.Text = "Nombre";
            // 
            // textBoxNM
            // 
            textBoxNM.Location = new Point(557, 254);
            textBoxNM.Name = "textBoxNM";
            textBoxNM.Size = new Size(150, 31);
            textBoxNM.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 303);
            label6.Name = "label6";
            label6.Size = new Size(104, 38);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // textBoxCRR
            // 
            textBoxCRR.Location = new Point(25, 344);
            textBoxCRR.Name = "textBoxCRR";
            textBoxCRR.Size = new Size(288, 31);
            textBoxCRR.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(25, 402);
            button1.Name = "button1";
            button1.Size = new Size(150, 48);
            button1.TabIndex = 12;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(215, 402);
            button2.Name = "button2";
            button2.Size = new Size(132, 48);
            button2.TabIndex = 13;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(181, 9);
            label7.Name = "label7";
            label7.Size = new Size(442, 150);
            label7.TabIndex = 16;
            label7.Text = resources.GetString("label7.Text");
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(-22, -3);
            label8.Name = "label8";
            label8.Size = new Size(227, 150);
            label8.TabIndex = 15;
            label8.Text = " \r\n\r\n\r\n\r\n\r\n                                           \r\n";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(350, 353);
            maskedTextBox1.Mask = "000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(123, 31);
            maskedTextBox1.TabIndex = 17;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(370, 402);
            button3.Name = "button3";
            button3.Size = new Size(132, 48);
            button3.TabIndex = 18;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(714, 470);
            Controls.Add(button3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBoxCRR);
            Controls.Add(label5);
            Controls.Add(textBoxNM);
            Controls.Add(label4);
            Controls.Add(textBoxAM);
            Controls.Add(label3);
            Controls.Add(textBoxAP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            ForeColor = Color.Black;
            Name = "frmActualizarUsuario";
            Text = "frmActualizarUsuario";
            Load += frmActualizarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAP;
        private Label label4;
        private TextBox textBoxAM;
        private Label label5;
        private TextBox textBoxNM;
        private Label label6;
        private TextBox textBoxCRR;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private Button button3;
    }
}