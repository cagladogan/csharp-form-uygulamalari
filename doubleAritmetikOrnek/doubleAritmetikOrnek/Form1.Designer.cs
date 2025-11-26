namespace doubleAritmetikOrnek
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
            HesaplaButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            lblTopla = new Label();
            label3 = new Label();
            label5 = new Label();
            lblCarp = new Label();
            lblFark = new Label();
            label6 = new Label();
            lblbol = new Label();
            SuspendLayout();
            // 
            // HesaplaButton
            // 
            HesaplaButton.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HesaplaButton.Location = new Point(367, 600);
            HesaplaButton.Name = "HesaplaButton";
            HesaplaButton.Size = new Size(191, 72);
            HesaplaButton.TabIndex = 0;
            HesaplaButton.Text = "Hesapla";
            HesaplaButton.UseVisualStyleBackColor = true;
            HesaplaButton.Click += HesaplaButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(226, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 32);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(63, 50);
            label1.Name = "label1";
            label1.Size = new Size(124, 48);
            label1.TabIndex = 2;
            label1.Text = "1. sayı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(63, 144);
            label2.Name = "label2";
            label2.Size = new Size(124, 48);
            label2.TabIndex = 3;
            label2.Text = "2. sayı:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(226, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 32);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(605, 66);
            label4.Name = "label4";
            label4.Size = new Size(143, 48);
            label4.TabIndex = 5;
            label4.Text = "Toplam:";
            // 
            // lblTopla
            // 
            lblTopla.AutoSize = true;
            lblTopla.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTopla.Location = new Point(754, 66);
            lblTopla.Name = "lblTopla";
            lblTopla.Size = new Size(58, 48);
            lblTopla.TabIndex = 6;
            lblTopla.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(605, 144);
            label3.Name = "label3";
            label3.Size = new Size(94, 48);
            label3.TabIndex = 7;
            label3.Text = "Fark:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(605, 309);
            label5.Name = "label5";
            label5.Size = new Size(142, 48);
            label5.TabIndex = 8;
            label5.Text = "Çarpım:";
            // 
            // lblCarp
            // 
            lblCarp.AutoSize = true;
            lblCarp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCarp.Location = new Point(754, 224);
            lblCarp.Name = "lblCarp";
            lblCarp.Size = new Size(58, 48);
            lblCarp.TabIndex = 9;
            lblCarp.Text = "00";
            // 
            // lblFark
            // 
            lblFark.AutoSize = true;
            lblFark.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFark.Location = new Point(754, 144);
            lblFark.Name = "lblFark";
            lblFark.Size = new Size(58, 48);
            lblFark.TabIndex = 10;
            lblFark.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(605, 224);
            label6.Name = "label6";
            label6.Size = new Size(130, 48);
            label6.TabIndex = 11;
            label6.Text = "Bölüm:";
            // 
            // lblbol
            // 
            lblbol.AutoSize = true;
            lblbol.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblbol.Location = new Point(754, 309);
            lblbol.Name = "lblbol";
            lblbol.Size = new Size(58, 48);
            lblbol.TabIndex = 12;
            lblbol.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(999, 701);
            Controls.Add(lblbol);
            Controls.Add(label6);
            Controls.Add(lblFark);
            Controls.Add(lblCarp);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblTopla);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(HesaplaButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HesaplaButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private Label lblTopla;
        private Label label3;
        private Label label5;
        private Label lblCarp;
        private Label lblFark;
        private Label label6;
        private Label lblbol;
    }
}
