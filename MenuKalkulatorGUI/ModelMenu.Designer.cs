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
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.inputOperator = new System.Windows.Forms.TextBox();
            this.buttonPenjumlahan = new System.Windows.Forms.RadioButton();
            this.buttonPengurangan = new System.Windows.Forms.RadioButton();
            this.buttonPerkalian = new System.Windows.Forms.RadioButton();
            this.buttonPembagian = new System.Windows.Forms.RadioButton();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pilihan menu operasi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.White;
            this.input1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(228, 248);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 29);
            this.input1.TabIndex = 4;
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.Color.White;
            this.input2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(351, 248);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 29);
            this.input2.TabIndex = 5;
            this.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputOperator
            // 
            this.inputOperator.BackColor = System.Drawing.Color.White;
            this.inputOperator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOperator.Location = new System.Drawing.Point(471, 248);
            this.inputOperator.Name = "inputOperator";
            this.inputOperator.Size = new System.Drawing.Size(100, 29);
            this.inputOperator.TabIndex = 6;
            this.inputOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonPenjumlahan
            // 
            this.buttonPenjumlahan.AutoSize = true;
            this.buttonPenjumlahan.Location = new System.Drawing.Point(102, 134);
            this.buttonPenjumlahan.Name = "buttonPenjumlahan";
            this.buttonPenjumlahan.Size = new System.Drawing.Size(92, 17);
            this.buttonPenjumlahan.TabIndex = 7;
            this.buttonPenjumlahan.TabStop = true;
            this.buttonPenjumlahan.Text = "Penjumlahan";
            this.buttonPenjumlahan.UseVisualStyleBackColor = true;
            this.buttonPenjumlahan.CheckedChanged += new System.EventHandler(this.buttonPenjumlahan_CheckedChanged);
            // 
            // buttonPengurangan
            // 
            this.buttonPengurangan.AutoSize = true;
            this.buttonPengurangan.Location = new System.Drawing.Point(102, 157);
            this.buttonPengurangan.Name = "buttonPengurangan";
            this.buttonPengurangan.Size = new System.Drawing.Size(95, 17);
            this.buttonPengurangan.TabIndex = 8;
            this.buttonPengurangan.TabStop = true;
            this.buttonPengurangan.Text = "Pengurangan";
            this.buttonPengurangan.UseVisualStyleBackColor = true;
            this.buttonPengurangan.CheckedChanged += new System.EventHandler(this.buttonPengurangan_CheckedChanged);
            // 
            // buttonPerkalian
            // 
            this.buttonPerkalian.AutoSize = true;
            this.buttonPerkalian.Location = new System.Drawing.Point(102, 180);
            this.buttonPerkalian.Name = "buttonPerkalian";
            this.buttonPerkalian.Size = new System.Drawing.Size(72, 17);
            this.buttonPerkalian.TabIndex = 9;
            this.buttonPerkalian.TabStop = true;
            this.buttonPerkalian.Text = "Perkalian";
            this.buttonPerkalian.UseVisualStyleBackColor = true;
            this.buttonPerkalian.CheckedChanged += new System.EventHandler(this.buttonPerkalian_CheckedChanged);
            // 
            // buttonPembagian
            // 
            this.buttonPembagian.AutoSize = true;
            this.buttonPembagian.Location = new System.Drawing.Point(102, 205);
            this.buttonPembagian.Name = "buttonPembagian";
            this.buttonPembagian.Size = new System.Drawing.Size(82, 17);
            this.buttonPembagian.TabIndex = 10;
            this.buttonPembagian.TabStop = true;
            this.buttonPembagian.Text = "Pembagian";
            this.buttonPembagian.UseVisualStyleBackColor = true;
            this.buttonPembagian.CheckedChanged += new System.EventHandler(this.buttonPembagian_CheckedChanged);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(252, 301);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 23);
            this.buttonEquals.TabIndex = 11;
            this.buttonEquals.Text = "Hitung";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // ModelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPembagian);
            this.Controls.Add(this.buttonPerkalian);
            this.Controls.Add(this.buttonPengurangan);
            this.Controls.Add(this.buttonPenjumlahan);
            this.Controls.Add(this.inputOperator);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModelMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Menu";
            this.Load += new System.EventHandler(this.ModelMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox inputOperator;
        private System.Windows.Forms.RadioButton buttonPenjumlahan;
        private System.Windows.Forms.RadioButton buttonPengurangan;
        private System.Windows.Forms.RadioButton buttonPerkalian;
        private System.Windows.Forms.RadioButton buttonPembagian;
        private System.Windows.Forms.Button buttonEquals;
    }
}