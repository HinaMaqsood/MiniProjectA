﻿namespace ProjectA
{
    partial class Person
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
            this.FNTB = new System.Windows.Forms.TextBox();
            this.LNTB = new System.Windows.Forms.TextBox();
            this.ContactNoTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.DOBTB = new System.Windows.Forms.TextBox();
            this.FN = new System.Windows.Forms.Label();
            this.LN = new System.Windows.Forms.Label();
            this.CNo = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegnoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNTB
            // 
            this.FNTB.Location = new System.Drawing.Point(153, 163);
            this.FNTB.Name = "FNTB";
            this.FNTB.Size = new System.Drawing.Size(100, 20);
            this.FNTB.TabIndex = 1;
            // 
            // LNTB
            // 
            this.LNTB.Location = new System.Drawing.Point(153, 199);
            this.LNTB.Name = "LNTB";
            this.LNTB.Size = new System.Drawing.Size(100, 20);
            this.LNTB.TabIndex = 2;
            // 
            // ContactNoTB
            // 
            this.ContactNoTB.Location = new System.Drawing.Point(153, 234);
            this.ContactNoTB.Name = "ContactNoTB";
            this.ContactNoTB.Size = new System.Drawing.Size(100, 20);
            this.ContactNoTB.TabIndex = 3;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(153, 269);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(100, 20);
            this.EmailTB.TabIndex = 4;
            // 
            // DOBTB
            // 
            this.DOBTB.Location = new System.Drawing.Point(153, 304);
            this.DOBTB.Name = "DOBTB";
            this.DOBTB.Size = new System.Drawing.Size(100, 20);
            this.DOBTB.TabIndex = 5;
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.ForeColor = System.Drawing.Color.Maroon;
            this.FN.Location = new System.Drawing.Point(59, 166);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(76, 16);
            this.FN.TabIndex = 8;
            this.FN.Text = "First Name";
            this.FN.Click += new System.EventHandler(this.FN_Click);
            // 
            // LN
            // 
            this.LN.AutoSize = true;
            this.LN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.Color.Maroon;
            this.LN.Location = new System.Drawing.Point(58, 202);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(73, 16);
            this.LN.TabIndex = 9;
            this.LN.Text = "Last Name";
            // 
            // CNo
            // 
            this.CNo.AutoSize = true;
            this.CNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNo.ForeColor = System.Drawing.Color.Maroon;
            this.CNo.Location = new System.Drawing.Point(72, 234);
            this.CNo.Name = "CNo";
            this.CNo.Size = new System.Drawing.Size(56, 16);
            this.CNo.TabIndex = 10;
            this.CNo.Text = "Contact";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Maroon;
            this.email.Location = new System.Drawing.Point(84, 269);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(43, 16);
            this.email.TabIndex = 11;
            this.email.Text = "Email";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.Maroon;
            this.DOB.Location = new System.Drawing.Point(49, 307);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(86, 16);
            this.DOB.TabIndex = 12;
            this.DOB.Text = "Date Of Birth";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Maroon;
            this.gender.Location = new System.Drawing.Point(74, 345);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(53, 16);
            this.gender.TabIndex = 13;
            this.gender.Text = "Gender";
            // 
            // gendercombo
            // 
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombo.Location = new System.Drawing.Point(153, 342);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(100, 21);
            this.gendercombo.TabIndex = 14;
            this.gendercombo.SelectedIndexChanged += new System.EventHandler(this.gendercombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 57);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student";
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.DarkCyan;
            this.createbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.ForeColor = System.Drawing.Color.Maroon;
            this.createbutton.Location = new System.Drawing.Point(42, 392);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(75, 35);
            this.createbutton.TabIndex = 17;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.updatebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Maroon;
            this.updatebutton.Location = new System.Drawing.Point(123, 392);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 35);
            this.updatebutton.TabIndex = 18;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.deletebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Maroon;
            this.deletebutton.Location = new System.Drawing.Point(204, 392);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 35);
            this.deletebutton.TabIndex = 19;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(285, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 302);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // RegnoTB
            // 
            this.RegnoTB.Location = new System.Drawing.Point(153, 127);
            this.RegnoTB.Name = "RegnoTB";
            this.RegnoTB.Size = new System.Drawing.Size(100, 20);
            this.RegnoTB.TabIndex = 21;
            this.RegnoTB.TextChanged += new System.EventHandler(this.RegnoTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(2, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Registeration Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 100);
            this.panel1.TabIndex = 23;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegnoTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.gendercombo);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.email);
            this.Controls.Add(this.CNo);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.DOBTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ContactNoTB);
            this.Controls.Add(this.LNTB);
            this.Controls.Add(this.FNTB);
            this.Name = "Person";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FNTB;
        private System.Windows.Forms.TextBox LNTB;
        private System.Windows.Forms.TextBox ContactNoTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox DOBTB;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.Label LN;
        private System.Windows.Forms.Label CNo;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox RegnoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

