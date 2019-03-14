namespace ProjectA
{
    partial class Evaluation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.TotalMTB = new System.Windows.Forms.TextBox();
            this.TotalWTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 100);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 57);
            this.label1.TabIndex = 15;
            this.label1.Text = "Evaluation";
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.ForeColor = System.Drawing.Color.Maroon;
            this.FN.Location = new System.Drawing.Point(38, 144);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(44, 16);
            this.FN.TabIndex = 26;
            this.FN.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(336, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(648, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total Weightage";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(41, 163);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(116, 20);
            this.NameTB.TabIndex = 30;
            this.NameTB.TextAlignChanged += new System.EventHandler(this.NameTB_TextAlignChanged);
            this.NameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameTB_MouseClick);
            this.NameTB.SizeChanged += new System.EventHandler(this.NameTB_SizeChanged);
            this.NameTB.TabIndexChanged += new System.EventHandler(this.NameTB_TabIndexChanged);
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            this.NameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTB_KeyPress);
            this.NameTB.Move += new System.EventHandler(this.NameTB_Move);
            this.NameTB.Validating += new System.ComponentModel.CancelEventHandler(this.NameTB_Validating);
            // 
            // TotalMTB
            // 
            this.TotalMTB.Location = new System.Drawing.Point(339, 163);
            this.TotalMTB.Name = "TotalMTB";
            this.TotalMTB.Size = new System.Drawing.Size(119, 20);
            this.TotalMTB.TabIndex = 31;
            // 
            // TotalWTB
            // 
            this.TotalWTB.Location = new System.Drawing.Point(651, 163);
            this.TotalWTB.Name = "TotalWTB";
            this.TotalWTB.Size = new System.Drawing.Size(129, 20);
            this.TotalWTB.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.DarkCyan;
            this.createbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.ForeColor = System.Drawing.Color.Maroon;
            this.createbutton.Location = new System.Drawing.Point(231, 379);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(75, 35);
            this.createbutton.TabIndex = 34;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.updatebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Maroon;
            this.updatebutton.Location = new System.Drawing.Point(357, 379);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 35);
            this.updatebutton.TabIndex = 35;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.DarkCyan;
            this.deletebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Maroon;
            this.deletebutton.Location = new System.Drawing.Point(484, 379);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 35);
            this.deletebutton.TabIndex = 36;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalWTB);
            this.Controls.Add(this.TotalMTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.panel1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox TotalMTB;
        private System.Windows.Forms.TextBox TotalWTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
    }
}