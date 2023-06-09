﻿namespace Cafe_Management_System
{
    partial class Chef_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef_page));
            this.Resturant_Name = new System.Windows.Forms.TextBox();
            this.Chef_heading = new System.Windows.Forms.TextBox();
            this.chef_signin_box = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Chef_password_input = new System.Windows.Forms.TextBox();
            this.chef_password = new System.Windows.Forms.Label();
            this.Chef_id_input = new System.Windows.Forms.TextBox();
            this.chef_id = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.chef_signin_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resturant_Name
            // 
            this.Resturant_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.Resturant_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resturant_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resturant_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.Resturant_Name.Location = new System.Drawing.Point(0, 0);
            this.Resturant_Name.Name = "Resturant_Name";
            this.Resturant_Name.Size = new System.Drawing.Size(1300, 29);
            this.Resturant_Name.TabIndex = 10;
            this.Resturant_Name.Text = "Royal Palace Restaurant";
            this.Resturant_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Chef_heading
            // 
            this.Chef_heading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Chef_heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chef_heading.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef_heading.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Chef_heading.Location = new System.Drawing.Point(0, 30);
            this.Chef_heading.Name = "Chef_heading";
            this.Chef_heading.Size = new System.Drawing.Size(1300, 41);
            this.Chef_heading.TabIndex = 11;
            this.Chef_heading.Text = "Chef";
            this.Chef_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chef_signin_box
            // 
            this.chef_signin_box.BackColor = System.Drawing.Color.Transparent;
            this.chef_signin_box.Controls.Add(this.button1);
            this.chef_signin_box.Controls.Add(this.textBox1);
            this.chef_signin_box.Controls.Add(this.Chef_password_input);
            this.chef_signin_box.Controls.Add(this.chef_password);
            this.chef_signin_box.Controls.Add(this.Chef_id_input);
            this.chef_signin_box.Controls.Add(this.chef_id);
            this.chef_signin_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.chef_signin_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chef_signin_box.Location = new System.Drawing.Point(429, 122);
            this.chef_signin_box.Name = "chef_signin_box";
            this.chef_signin_box.Size = new System.Drawing.Size(474, 474);
            this.chef_signin_box.TabIndex = 12;
            this.chef_signin_box.TabStop = false;
            this.chef_signin_box.Text = "Chef Signin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(214, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(276, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Chef";
            // 
            // Chef_password_input
            // 
            this.Chef_password_input.Location = new System.Drawing.Point(63, 216);
            this.Chef_password_input.Name = "Chef_password_input";
            this.Chef_password_input.Size = new System.Drawing.Size(276, 40);
            this.Chef_password_input.TabIndex = 2;
            this.Chef_password_input.UseSystemPasswordChar = true;
            // 
            // chef_password
            // 
            this.chef_password.AutoSize = true;
            this.chef_password.Location = new System.Drawing.Point(35, 178);
            this.chef_password.Name = "chef_password";
            this.chef_password.Size = new System.Drawing.Size(126, 35);
            this.chef_password.TabIndex = 2;
            this.chef_password.Text = "Password";
            // 
            // Chef_id_input
            // 
            this.Chef_id_input.Location = new System.Drawing.Point(62, 90);
            this.Chef_id_input.Name = "Chef_id_input";
            this.Chef_id_input.Size = new System.Drawing.Size(277, 40);
            this.Chef_id_input.TabIndex = 1;
            // 
            // chef_id
            // 
            this.chef_id.AutoSize = true;
            this.chef_id.Location = new System.Drawing.Point(35, 52);
            this.chef_id.Name = "chef_id";
            this.chef_id.Size = new System.Drawing.Size(46, 35);
            this.chef_id.TabIndex = 0;
            this.chef_id.Text = "ID ";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(69, 543);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(197, 53);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1073, 543);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 53);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Chef_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.chef_signin_box);
            this.Controls.Add(this.Chef_heading);
            this.Controls.Add(this.Resturant_Name);
            this.Name = "Chef_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_page_Load);
            this.chef_signin_box.ResumeLayout(false);
            this.chef_signin_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resturant_Name;
        private System.Windows.Forms.TextBox Chef_heading;
        private System.Windows.Forms.GroupBox chef_signin_box;
        private System.Windows.Forms.TextBox Chef_password_input;
        private System.Windows.Forms.Label chef_password;
        private System.Windows.Forms.TextBox Chef_id_input;
        private System.Windows.Forms.Label chef_id;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}