﻿namespace Anexos
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(-194, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(54, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Como podemos te ajudar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(321, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Central de ajuda @nexos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(54, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dúvidas frequentes:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.textBox2.Location = new System.Drawing.Point(57, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 25);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Como deletar um cliente";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.textBox4.Location = new System.Drawing.Point(57, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 25);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Como cadastrar um novo cliente";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.textBox5.Location = new System.Drawing.Point(57, 301);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(259, 25);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Como editar as informações do cliente";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.textBox3.Location = new System.Drawing.Point(57, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 25);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Como enviar um arquivo";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form6";
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
    }
}