namespace ProjectA
{
    partial class Form1
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
            this.idTB = new System.Windows.Forms.TextBox();
            this.FNTB = new System.Windows.Forms.TextBox();
            this.LNTB = new System.Windows.Forms.TextBox();
            this.ContactNoTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.DOBTB = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(138, 93);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 0;
            // 
            // FNTB
            // 
            this.FNTB.Location = new System.Drawing.Point(138, 129);
            this.FNTB.Name = "FNTB";
            this.FNTB.Size = new System.Drawing.Size(100, 20);
            this.FNTB.TabIndex = 1;
            // 
            // LNTB
            // 
            this.LNTB.Location = new System.Drawing.Point(138, 162);
            this.LNTB.Name = "LNTB";
            this.LNTB.Size = new System.Drawing.Size(100, 20);
            this.LNTB.TabIndex = 2;
            // 
            // ContactNoTB
            // 
            this.ContactNoTB.Location = new System.Drawing.Point(138, 197);
            this.ContactNoTB.Name = "ContactNoTB";
            this.ContactNoTB.Size = new System.Drawing.Size(100, 20);
            this.ContactNoTB.TabIndex = 3;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(138, 235);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(100, 20);
            this.EmailTB.TabIndex = 4;
            // 
            // DOBTB
            // 
            this.DOBTB.Location = new System.Drawing.Point(138, 270);
            this.DOBTB.Name = "DOBTB";
            this.DOBTB.Size = new System.Drawing.Size(100, 20);
            this.DOBTB.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(75, 93);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 7;
            this.id.Text = "Id";
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Location = new System.Drawing.Point(46, 132);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(57, 13);
            this.FN.TabIndex = 8;
            this.FN.Text = "First Name";
            this.FN.Click += new System.EventHandler(this.FN_Click);
            // 
            // LN
            // 
            this.LN.AutoSize = true;
            this.LN.Location = new System.Drawing.Point(49, 165);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(58, 13);
            this.LN.TabIndex = 9;
            this.LN.Text = "Last Name";
            // 
            // CNo
            // 
            this.CNo.AutoSize = true;
            this.CNo.Location = new System.Drawing.Point(59, 200);
            this.CNo.Name = "CNo";
            this.CNo.Size = new System.Drawing.Size(44, 13);
            this.CNo.TabIndex = 10;
            this.CNo.Text = "Contact";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(75, 235);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 11;
            this.email.Text = "Email";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(49, 273);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(68, 13);
            this.DOB.TabIndex = 12;
            this.DOB.Text = "Date Of Birth";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(75, 311);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 13;
            this.gender.Text = "Gender";
            // 
            // gendercombo
            // 
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombo.Location = new System.Drawing.Point(138, 308);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(100, 21);
            this.gendercombo.TabIndex = 14;
            this.gendercombo.SelectedIndexChanged += new System.EventHandler(this.gendercombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 57);
            this.label1.TabIndex = 15;
            this.label1.Text = "Person";
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(42, 370);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(75, 23);
            this.createbutton.TabIndex = 17;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(123, 370);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 18;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(204, 370);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 19;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 302);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gendercombo);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.email);
            this.Controls.Add(this.CNo);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.id);
            this.Controls.Add(this.DOBTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ContactNoTB);
            this.Controls.Add(this.LNTB);
            this.Controls.Add(this.FNTB);
            this.Controls.Add(this.idTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox FNTB;
        private System.Windows.Forms.TextBox LNTB;
        private System.Windows.Forms.TextBox ContactNoTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox DOBTB;
        private System.Windows.Forms.Label id;
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
    }
}

