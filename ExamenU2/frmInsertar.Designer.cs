namespace ExamenU2
{
    partial class frmInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertar));
            label6 = new Label();
            textBoxCRR = new TextBox();
            label5 = new Label();
            textBoxNM = new TextBox();
            label4 = new Label();
            textBoxAM = new TextBox();
            label3 = new Label();
            textBoxAP = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 227);
            label6.Name = "label6";
            label6.Size = new Size(104, 38);
            label6.TabIndex = 23;
            label6.Text = "Correo";
            // 
            // textBoxCRR
            // 
            textBoxCRR.Location = new Point(12, 268);
            textBoxCRR.Name = "textBoxCRR";
            textBoxCRR.Size = new Size(517, 31);
            textBoxCRR.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(544, 137);
            label5.Name = "label5";
            label5.Size = new Size(124, 38);
            label5.TabIndex = 21;
            label5.Text = "Nombre";
            // 
            // textBoxNM
            // 
            textBoxNM.Location = new Point(544, 178);
            textBoxNM.Name = "textBoxNM";
            textBoxNM.Size = new Size(150, 31);
            textBoxNM.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 137);
            label4.Name = "label4";
            label4.Size = new Size(248, 38);
            label4.TabIndex = 19;
            label4.Text = "Apellido Materno";
            // 
            // textBoxAM
            // 
            textBoxAM.Location = new Point(285, 178);
            textBoxAM.Name = "textBoxAM";
            textBoxAM.Size = new Size(247, 31);
            textBoxAM.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(242, 38);
            label3.TabIndex = 17;
            label3.Text = "Apellido Paterno";
            // 
            // textBoxAP
            // 
            textBoxAP.Location = new Point(3, 178);
            textBoxAP.Name = "textBoxAP";
            textBoxAP.Size = new Size(245, 31);
            textBoxAP.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(544, 227);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 15;
            label2.Text = "Telefono";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(21, 323);
            button1.Name = "button1";
            button1.Size = new Size(128, 43);
            button1.TabIndex = 24;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(215, -1);
            label7.Name = "label7";
            label7.Size = new Size(442, 150);
            label7.TabIndex = 26;
            label7.Text = resources.GetString("label7.Text");
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(12, -13);
            label8.Name = "label8";
            label8.Size = new Size(227, 150);
            label8.TabIndex = 25;
            label8.Text = " \r\n\r\n\r\n\r\n\r\n                                           \r\n";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(544, 268);
            maskedTextBox1.Mask = "000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 27;
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(721, 378);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label8);
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
            Name = "frmInsertar";
            Text = "frmInsertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBoxCRR;
        private Label label5;
        private TextBox textBoxNM;
        private Label label4;
        private TextBox textBoxAM;
        private Label label3;
        private TextBox textBoxAP;
        private Label label2;
        private Button button1;
        private Label label7;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
    }
}