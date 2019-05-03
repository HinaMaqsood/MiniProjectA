namespace ProjectA
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
            this.DTTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNTB
            // 
            this.FNTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FNTB.Location = new System.Drawing.Point(149, 49);
            this.FNTB.Name = "FNTB";
            this.FNTB.Size = new System.Drawing.Size(139, 20);
            this.FNTB.TabIndex = 1;
            this.FNTB.Validating += new System.ComponentModel.CancelEventHandler(this.FNTB_Validating);
            // 
            // LNTB
            // 
            this.LNTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LNTB.Location = new System.Drawing.Point(149, 93);
            this.LNTB.Name = "LNTB";
            this.LNTB.Size = new System.Drawing.Size(139, 20);
            this.LNTB.TabIndex = 2;
            this.LNTB.Validating += new System.ComponentModel.CancelEventHandler(this.LNTB_Validating);
            // 
            // ContactNoTB
            // 
            this.ContactNoTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactNoTB.Location = new System.Drawing.Point(149, 129);
            this.ContactNoTB.Name = "ContactNoTB";
            this.ContactNoTB.Size = new System.Drawing.Size(139, 20);
            this.ContactNoTB.TabIndex = 3;
            this.ContactNoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNoTB_KeyPress);
            this.ContactNoTB.Validating += new System.ComponentModel.CancelEventHandler(this.ContactNoTB_Validating);
            // 
            // EmailTB
            // 
            this.EmailTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmailTB.Location = new System.Drawing.Point(149, 167);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(139, 20);
            this.EmailTB.TabIndex = 4;
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            this.EmailTB.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTB_Validating_1);
            // 
            // FN
            // 
            this.FN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.ForeColor = System.Drawing.Color.Maroon;
            this.FN.Location = new System.Drawing.Point(3, 46);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(140, 44);
            this.FN.TabIndex = 8;
            this.FN.Text = "First Name";
            this.FN.Click += new System.EventHandler(this.FN_Click);
            // 
            // LN
            // 
            this.LN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LN.AutoSize = true;
            this.LN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.Color.Maroon;
            this.LN.Location = new System.Drawing.Point(3, 90);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(140, 36);
            this.LN.TabIndex = 9;
            this.LN.Text = "Last Name";
            // 
            // CNo
            // 
            this.CNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CNo.AutoSize = true;
            this.CNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNo.ForeColor = System.Drawing.Color.Maroon;
            this.CNo.Location = new System.Drawing.Point(3, 126);
            this.CNo.Name = "CNo";
            this.CNo.Size = new System.Drawing.Size(140, 38);
            this.CNo.TabIndex = 10;
            this.CNo.Text = "Contact";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Maroon;
            this.email.Location = new System.Drawing.Point(3, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(140, 38);
            this.email.TabIndex = 11;
            this.email.Text = "Email";
            // 
            // DOB
            // 
            this.DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.Maroon;
            this.DOB.Location = new System.Drawing.Point(3, 202);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(140, 40);
            this.DOB.TabIndex = 12;
            this.DOB.Text = "Date Of Birth";
            // 
            // gender
            // 
            this.gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Maroon;
            this.gender.Location = new System.Drawing.Point(3, 242);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(140, 102);
            this.gender.TabIndex = 13;
            this.gender.Text = "Gender";
            // 
            // gendercombo
            // 
            this.gendercombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombo.Location = new System.Drawing.Point(149, 245);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(139, 21);
            this.gendercombo.TabIndex = 14;
            this.gendercombo.SelectedIndexChanged += new System.EventHandler(this.gendercombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 57);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student";
            // 
            // createbutton
            // 
            this.createbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createbutton.BackColor = System.Drawing.Color.DarkCyan;
            this.createbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.ForeColor = System.Drawing.Color.Maroon;
            this.createbutton.Location = new System.Drawing.Point(3, 32);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(75, 35);
            this.createbutton.TabIndex = 17;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.updatebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Maroon;
            this.updatebutton.Location = new System.Drawing.Point(90, 32);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(86, 35);
            this.updatebutton.TabIndex = 18;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.deletebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Maroon;
            this.deletebutton.Location = new System.Drawing.Point(191, 32);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 35);
            this.deletebutton.TabIndex = 19;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 235);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // RegnoTB
            // 
            this.RegnoTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RegnoTB.Location = new System.Drawing.Point(149, 13);
            this.RegnoTB.Name = "RegnoTB";
            this.RegnoTB.Size = new System.Drawing.Size(140, 20);
            this.RegnoTB.TabIndex = 21;
            this.RegnoTB.TextChanged += new System.EventHandler(this.RegnoTB_TextChanged);
            this.RegnoTB.Validating += new System.ComponentModel.CancelEventHandler(this.RegnoTB_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 46);
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
            this.panel1.Size = new System.Drawing.Size(896, 100);
            this.panel1.TabIndex = 23;
            // 
            // DTTB
            // 
            this.DTTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DTTB.Location = new System.Drawing.Point(149, 205);
            this.DTTB.Name = "DTTB";
            this.DTTB.Size = new System.Drawing.Size(139, 20);
            this.DTTB.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.deletebutton);
            this.panel2.Controls.Add(this.updatebutton);
            this.panel2.Controls.Add(this.createbutton);
            this.panel2.Location = new System.Drawing.Point(606, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 100);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RegnoTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DTTB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.FN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gendercombo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.FNTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gender, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LNTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CNo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DOB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ContactNoTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmailTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.email, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.40187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.59813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 344);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(314, 116);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 241);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Person";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox FNTB;
        private System.Windows.Forms.TextBox LNTB;
        private System.Windows.Forms.TextBox ContactNoTB;
        private System.Windows.Forms.TextBox EmailTB;
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
        private System.Windows.Forms.TextBox DTTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

