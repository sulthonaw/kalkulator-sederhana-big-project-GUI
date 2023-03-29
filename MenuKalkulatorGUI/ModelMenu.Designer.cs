namespace MenuKalkulatorGUI
{
    partial class ModelMenu
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.inputOperator = new System.Windows.Forms.TextBox();
            this.buttonPenjumlahan = new System.Windows.Forms.RadioButton();
            this.buttonPengurangan = new System.Windows.Forms.RadioButton();
            this.buttonPerkalian = new System.Windows.Forms.RadioButton();
            this.buttonPembagian = new System.Windows.Forms.RadioButton();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.White;
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(125, 18);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(168, 26);
            this.input1.TabIndex = 4;
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input1.Click += new System.EventHandler(this.input1_Click);
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.Color.White;
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(125, 133);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(168, 26);
            this.input2.TabIndex = 5;
            this.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input2.Click += new System.EventHandler(this.input2_Click);
            this.input2.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // inputOperator
            // 
            this.inputOperator.BackColor = System.Drawing.Color.White;
            this.inputOperator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOperator.Location = new System.Drawing.Point(125, 84);
            this.inputOperator.Name = "inputOperator";
            this.inputOperator.ReadOnly = true;
            this.inputOperator.Size = new System.Drawing.Size(49, 29);
            this.inputOperator.TabIndex = 6;
            this.inputOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputOperator.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // buttonPenjumlahan
            // 
            this.buttonPenjumlahan.AutoSize = true;
            this.buttonPenjumlahan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPenjumlahan.Location = new System.Drawing.Point(10, 29);
            this.buttonPenjumlahan.Name = "buttonPenjumlahan";
            this.buttonPenjumlahan.Size = new System.Drawing.Size(99, 21);
            this.buttonPenjumlahan.TabIndex = 7;
            this.buttonPenjumlahan.TabStop = true;
            this.buttonPenjumlahan.Text = "Penjumlahan";
            this.buttonPenjumlahan.UseVisualStyleBackColor = true;
            this.buttonPenjumlahan.CheckedChanged += new System.EventHandler(this.buttonPenjumlahan_CheckedChanged);
            // 
            // buttonPengurangan
            // 
            this.buttonPengurangan.AutoSize = true;
            this.buttonPengurangan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengurangan.Location = new System.Drawing.Point(10, 52);
            this.buttonPengurangan.Name = "buttonPengurangan";
            this.buttonPengurangan.Size = new System.Drawing.Size(103, 21);
            this.buttonPengurangan.TabIndex = 8;
            this.buttonPengurangan.TabStop = true;
            this.buttonPengurangan.Text = "Pengurangan";
            this.buttonPengurangan.UseVisualStyleBackColor = true;
            this.buttonPengurangan.CheckedChanged += new System.EventHandler(this.buttonPengurangan_CheckedChanged);
            // 
            // buttonPerkalian
            // 
            this.buttonPerkalian.AutoSize = true;
            this.buttonPerkalian.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerkalian.Location = new System.Drawing.Point(10, 75);
            this.buttonPerkalian.Name = "buttonPerkalian";
            this.buttonPerkalian.Size = new System.Drawing.Size(78, 21);
            this.buttonPerkalian.TabIndex = 9;
            this.buttonPerkalian.TabStop = true;
            this.buttonPerkalian.Text = "Perkalian";
            this.buttonPerkalian.UseVisualStyleBackColor = true;
            this.buttonPerkalian.CheckedChanged += new System.EventHandler(this.buttonPerkalian_CheckedChanged);
            // 
            // buttonPembagian
            // 
            this.buttonPembagian.AutoSize = true;
            this.buttonPembagian.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPembagian.Location = new System.Drawing.Point(10, 100);
            this.buttonPembagian.Name = "buttonPembagian";
            this.buttonPembagian.Size = new System.Drawing.Size(91, 21);
            this.buttonPembagian.TabIndex = 10;
            this.buttonPembagian.TabStop = true;
            this.buttonPembagian.Text = "Pembagian";
            this.buttonPembagian.UseVisualStyleBackColor = true;
            this.buttonPembagian.CheckedChanged += new System.EventHandler(this.buttonPembagian_CheckedChanged);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.Black;
            this.buttonEquals.Enabled = false;
            this.buttonEquals.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.ForeColor = System.Drawing.Color.White;
            this.buttonEquals.Location = new System.Drawing.Point(36, 242);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(257, 33);
            this.buttonEquals.TabIndex = 11;
            this.buttonEquals.Text = "Hitung";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Menu operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hasil = ";
            // 
            // outputHasil
            // 
            this.outputHasil.BackColor = System.Drawing.Color.White;
            this.outputHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputHasil.Location = new System.Drawing.Point(125, 197);
            this.outputHasil.Name = "outputHasil";
            this.outputHasil.ReadOnly = true;
            this.outputHasil.Size = new System.Drawing.Size(168, 26);
            this.outputHasil.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Angka 2 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Angka 1 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Operator = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(122, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "*input wajib berupa angka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(122, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "*input wajib berupa angka";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.outputHasil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonEquals);
            this.panel1.Controls.Add(this.inputOperator);
            this.panel1.Controls.Add(this.input2);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Location = new System.Drawing.Point(320, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 326);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonPembagian);
            this.panel2.Controls.Add(this.buttonPerkalian);
            this.panel2.Controls.Add(this.buttonPengurangan);
            this.panel2.Controls.Add(this.buttonPenjumlahan);
            this.panel2.Location = new System.Drawing.Point(153, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 127);
            this.panel2.TabIndex = 33;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(357, 335);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(257, 33);
            this.buttonReset.TabIndex = 32;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ModelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModelMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Menu";
            this.Load += new System.EventHandler(this.ModelMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox inputOperator;
        private System.Windows.Forms.RadioButton buttonPenjumlahan;
        private System.Windows.Forms.RadioButton buttonPengurangan;
        private System.Windows.Forms.RadioButton buttonPerkalian;
        private System.Windows.Forms.RadioButton buttonPembagian;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonReset;
    }
}