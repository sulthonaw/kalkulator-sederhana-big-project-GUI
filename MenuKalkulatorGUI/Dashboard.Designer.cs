namespace MenuKalkulatorGUI
{
    partial class Dashboard
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
            this.buttonModelMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModelStringDanSimbol = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonModelFullString = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonModelMenu
            // 
            this.buttonModelMenu.Location = new System.Drawing.Point(122, 70);
            this.buttonModelMenu.Name = "buttonModelMenu";
            this.buttonModelMenu.Size = new System.Drawing.Size(75, 27);
            this.buttonModelMenu.TabIndex = 0;
            this.buttonModelMenu.Text = "Go";
            this.buttonModelMenu.UseVisualStyleBackColor = true;
            this.buttonModelMenu.Click += new System.EventHandler(this.buttonModelMenu_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonModelMenu);
            this.panel1.Location = new System.Drawing.Point(245, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 102);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kalkulator: Model Menu";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 52);
            this.header.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonModelStringDanSimbol);
            this.panel2.Location = new System.Drawing.Point(468, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 102);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator: Model String Dan Simbol";
            // 
            // buttonModelStringDanSimbol
            // 
            this.buttonModelStringDanSimbol.Location = new System.Drawing.Point(122, 70);
            this.buttonModelStringDanSimbol.Name = "buttonModelStringDanSimbol";
            this.buttonModelStringDanSimbol.Size = new System.Drawing.Size(75, 27);
            this.buttonModelStringDanSimbol.TabIndex = 0;
            this.buttonModelStringDanSimbol.Text = "Go";
            this.buttonModelStringDanSimbol.UseVisualStyleBackColor = true;
            this.buttonModelStringDanSimbol.Click += new System.EventHandler(this.buttonModelStringDanSimbol_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonModelFullString);
            this.panel3.Location = new System.Drawing.Point(245, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 102);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalkulator: Model Full String";
            // 
            // buttonModelFullString
            // 
            this.buttonModelFullString.Location = new System.Drawing.Point(122, 70);
            this.buttonModelFullString.Name = "buttonModelFullString";
            this.buttonModelFullString.Size = new System.Drawing.Size(75, 27);
            this.buttonModelFullString.TabIndex = 0;
            this.buttonModelFullString.Text = "Go";
            this.buttonModelFullString.UseVisualStyleBackColor = true;
            this.buttonModelFullString.Click += new System.EventHandler(this.buttonModelFullString_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModelStringDanSimbol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonModelFullString;
    }
}

