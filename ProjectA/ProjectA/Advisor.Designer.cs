namespace ProjectA
{
    partial class Advisor
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
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.CNo = new System.Windows.Forms.Label();
            this.LN = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.ContactNoTB = new System.Windows.Forms.TextBox();
            this.LNTB = new System.Windows.Forms.TextBox();
            this.FNTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.createbutton = new System.Windows.Forms.Button();
            this.desigcombo = new System.Windows.Forms.ComboBox();
            this.DOBTB = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gendercombo
            // 
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombo.Location = new System.Drawing.Point(125, 330);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(100, 21);
            this.gendercombo.TabIndex = 26;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Maroon;
            this.gender.Location = new System.Drawing.Point(50, 332);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(53, 16);
            this.gender.TabIndex = 25;
            this.gender.Text = "Gender";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.Maroon;
            this.DOB.Location = new System.Drawing.Point(21, 305);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(86, 16);
            this.DOB.TabIndex = 24;
            this.DOB.Text = "Date Of Birth";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Maroon;
            this.email.Location = new System.Drawing.Point(61, 279);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(43, 16);
            this.email.TabIndex = 23;
            this.email.Text = "Email";
            // 
            // CNo
            // 
            this.CNo.AutoSize = true;
            this.CNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNo.ForeColor = System.Drawing.Color.Maroon;
            this.CNo.Location = new System.Drawing.Point(51, 253);
            this.CNo.Name = "CNo";
            this.CNo.Size = new System.Drawing.Size(56, 16);
            this.CNo.TabIndex = 22;
            this.CNo.Text = "Contact";
            // 
            // LN
            // 
            this.LN.AutoSize = true;
            this.LN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.Color.Maroon;
            this.LN.Location = new System.Drawing.Point(34, 175);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(73, 16);
            this.LN.TabIndex = 21;
            this.LN.Text = "Last Name";
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.ForeColor = System.Drawing.Color.Maroon;
            this.FN.Location = new System.Drawing.Point(30, 148);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(76, 16);
            this.FN.TabIndex = 20;
            this.FN.Text = "First Name";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(125, 278);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(100, 20);
            this.EmailTB.TabIndex = 18;
            this.EmailTB.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTB_Validating);
            // 
            // ContactNoTB
            // 
            this.ContactNoTB.Location = new System.Drawing.Point(125, 252);
            this.ContactNoTB.Name = "ContactNoTB";
            this.ContactNoTB.Size = new System.Drawing.Size(100, 20);
            this.ContactNoTB.TabIndex = 17;
            this.ContactNoTB.Validating += new System.ComponentModel.CancelEventHandler(this.ContactNoTB_Validating);
            // 
            // LNTB
            // 
            this.LNTB.Location = new System.Drawing.Point(125, 174);
            this.LNTB.Name = "LNTB";
            this.LNTB.Size = new System.Drawing.Size(100, 20);
            this.LNTB.TabIndex = 16;
            this.LNTB.Validating += new System.ComponentModel.CancelEventHandler(this.LNTB_Validating);
            // 
            // FNTB
            // 
            this.FNTB.Location = new System.Drawing.Point(125, 147);
            this.FNTB.Name = "FNTB";
            this.FNTB.Size = new System.Drawing.Size(100, 20);
            this.FNTB.TabIndex = 15;
            this.FNTB.TextChanged += new System.EventHandler(this.FNTB_TextChanged);
            this.FNTB.Validating += new System.ComponentModel.CancelEventHandler(this.FNTB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(28, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(57, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Salary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // salaTB
            // 
            this.salaTB.Location = new System.Drawing.Point(125, 226);
            this.salaTB.Name = "salaTB";
            this.salaTB.Size = new System.Drawing.Size(100, 20);
            this.salaTB.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 100);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 57);
            this.label4.TabIndex = 15;
            this.label4.Text = "Advisor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 203);
            this.dataGridView1.TabIndex = 33;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.deletebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Maroon;
            this.deletebutton.Location = new System.Drawing.Point(708, 381);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 35);
            this.deletebutton.TabIndex = 39;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.updatebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Maroon;
            this.updatebutton.Location = new System.Drawing.Point(573, 381);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 35);
            this.updatebutton.TabIndex = 38;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.DarkCyan;
            this.createbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.ForeColor = System.Drawing.Color.Maroon;
            this.createbutton.Location = new System.Drawing.Point(440, 381);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(75, 35);
            this.createbutton.TabIndex = 37;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // desigcombo
            // 
            this.desigcombo.FormattingEnabled = true;
            this.desigcombo.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.desigcombo.Location = new System.Drawing.Point(125, 199);
            this.desigcombo.Name = "desigcombo";
            this.desigcombo.Size = new System.Drawing.Size(100, 21);
            this.desigcombo.TabIndex = 40;
            this.desigcombo.StyleChanged += new System.EventHandler(this.desigcombo_StyleChanged);
            this.desigcombo.Validated += new System.EventHandler(this.desigcombo_Validated);
            // 
            // DOBTB
            // 
            this.DOBTB.Location = new System.Drawing.Point(125, 305);
            this.DOBTB.Name = "DOBTB";
            this.DOBTB.Size = new System.Drawing.Size(100, 20);
            this.DOBTB.TabIndex = 41;
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.DOBTB);
            this.Controls.Add(this.desigcombo);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gendercombo);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.email);
            this.Controls.Add(this.CNo);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ContactNoTB);
            this.Controls.Add(this.LNTB);
            this.Controls.Add(this.FNTB);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.Load += new System.EventHandler(this.Advisor_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Advisor_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label CNo;
        private System.Windows.Forms.Label LN;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox ContactNoTB;
        private System.Windows.Forms.TextBox LNTB;
        private System.Windows.Forms.TextBox FNTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salaTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.ComboBox desigcombo;
        private System.Windows.Forms.DateTimePicker DOBTB;
    }
}