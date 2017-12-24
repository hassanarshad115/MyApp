namespace MyApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.purchasetextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saletextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.availableQtytextBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nametextBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Exitbutton1 = new System.Windows.Forms.Button();
            this.Deletebutton2 = new System.Windows.Forms.Button();
            this.Updatebutton4 = new System.Windows.Forms.Button();
            this.Savebutton5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 279);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Purchase Qty:";
            // 
            // purchasetextBox1
            // 
            this.purchasetextBox1.Location = new System.Drawing.Point(342, 57);
            this.purchasetextBox1.Name = "purchasetextBox1";
            this.purchasetextBox1.Size = new System.Drawing.Size(135, 20);
            this.purchasetextBox1.TabIndex = 1;
            this.purchasetextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasetextBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Sale Qty:";
            // 
            // saletextBox2
            // 
            this.saletextBox2.Location = new System.Drawing.Point(342, 88);
            this.saletextBox2.Name = "saletextBox2";
            this.saletextBox2.Size = new System.Drawing.Size(135, 20);
            this.saletextBox2.TabIndex = 2;
            this.saletextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saletextBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "&Date:";
            // 
            // availableQtytextBox3
            // 
            this.availableQtytextBox3.Location = new System.Drawing.Point(88, 88);
            this.availableQtytextBox3.Name = "availableQtytextBox3";
            this.availableQtytextBox3.Size = new System.Drawing.Size(172, 20);
            this.availableQtytextBox3.TabIndex = 3;
            this.availableQtytextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.availableQtytextBox3_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(532, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 12, 24, 3, 41, 2, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Name:";
            // 
            // nametextBox4
            // 
            this.nametextBox4.Location = new System.Drawing.Point(88, 57);
            this.nametextBox4.Name = "nametextBox4";
            this.nametextBox4.Size = new System.Drawing.Size(172, 20);
            this.nametextBox4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "&Available Qty:";
            // 
            // Exitbutton1
            // 
            this.Exitbutton1.Location = new System.Drawing.Point(657, 402);
            this.Exitbutton1.Name = "Exitbutton1";
            this.Exitbutton1.Size = new System.Drawing.Size(75, 31);
            this.Exitbutton1.TabIndex = 9;
            this.Exitbutton1.Text = "&Exit";
            this.Exitbutton1.UseVisualStyleBackColor = true;
            this.Exitbutton1.Click += new System.EventHandler(this.Exitbutton1_Click);
            // 
            // Deletebutton2
            // 
            this.Deletebutton2.Location = new System.Drawing.Point(544, 402);
            this.Deletebutton2.Name = "Deletebutton2";
            this.Deletebutton2.Size = new System.Drawing.Size(98, 31);
            this.Deletebutton2.TabIndex = 8;
            this.Deletebutton2.Text = "&Delete";
            this.Deletebutton2.UseVisualStyleBackColor = true;
            this.Deletebutton2.Click += new System.EventHandler(this.Deletebutton2_Click);
            // 
            // Updatebutton4
            // 
            this.Updatebutton4.Location = new System.Drawing.Point(336, 402);
            this.Updatebutton4.Name = "Updatebutton4";
            this.Updatebutton4.Size = new System.Drawing.Size(196, 31);
            this.Updatebutton4.TabIndex = 6;
            this.Updatebutton4.Text = "&Update by Name";
            this.Updatebutton4.UseVisualStyleBackColor = true;
            this.Updatebutton4.Click += new System.EventHandler(this.Updatebutton4_Click);
            // 
            // Savebutton5
            // 
            this.Savebutton5.Location = new System.Drawing.Point(337, 402);
            this.Savebutton5.Name = "Savebutton5";
            this.Savebutton5.Size = new System.Drawing.Size(196, 31);
            this.Savebutton5.TabIndex = 5;
            this.Savebutton5.Text = "&Save";
            this.Savebutton5.UseVisualStyleBackColor = true;
            this.Savebutton5.Click += new System.EventHandler(this.Savebutton5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "&Search by Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 102;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(495, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 41);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(269, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 33);
            this.label7.TabIndex = 104;
            this.label7.Text = "&STOCK &MASTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 438);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Savebutton5);
            this.Controls.Add(this.Updatebutton4);
            this.Controls.Add(this.Deletebutton2);
            this.Controls.Add(this.Exitbutton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.availableQtytextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saletextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchasetextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox purchasetextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saletextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox availableQtytextBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exitbutton1;
        private System.Windows.Forms.Button Deletebutton2;
        private System.Windows.Forms.Button Updatebutton4;
        private System.Windows.Forms.Button Savebutton5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}

