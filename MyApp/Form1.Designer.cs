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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Exitbutton1 = new System.Windows.Forms.Button();
            this.Deletebutton2 = new System.Windows.Forms.Button();
            this.Editbutton3 = new System.Windows.Forms.Button();
            this.Updatebutton4 = new System.Windows.Forms.Button();
            this.Savebutton5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 279);
            this.dataGridView1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Purchase Qty:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Sale Qty:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "&Date:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(577, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(532, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 12, 24, 3, 41, 2, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 11);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "&Available Qty:";
            // 
            // Exitbutton1
            // 
            this.Exitbutton1.Location = new System.Drawing.Point(657, 363);
            this.Exitbutton1.Name = "Exitbutton1";
            this.Exitbutton1.Size = new System.Drawing.Size(75, 31);
            this.Exitbutton1.TabIndex = 9;
            this.Exitbutton1.Text = "&Exit";
            this.Exitbutton1.UseVisualStyleBackColor = true;
            // 
            // Deletebutton2
            // 
            this.Deletebutton2.Location = new System.Drawing.Point(576, 363);
            this.Deletebutton2.Name = "Deletebutton2";
            this.Deletebutton2.Size = new System.Drawing.Size(75, 31);
            this.Deletebutton2.TabIndex = 8;
            this.Deletebutton2.Text = "&Delete";
            this.Deletebutton2.UseVisualStyleBackColor = true;
            // 
            // Editbutton3
            // 
            this.Editbutton3.Location = new System.Drawing.Point(495, 363);
            this.Editbutton3.Name = "Editbutton3";
            this.Editbutton3.Size = new System.Drawing.Size(75, 31);
            this.Editbutton3.TabIndex = 7;
            this.Editbutton3.Text = "&Edit";
            this.Editbutton3.UseVisualStyleBackColor = true;
            // 
            // Updatebutton4
            // 
            this.Updatebutton4.Location = new System.Drawing.Point(414, 363);
            this.Updatebutton4.Name = "Updatebutton4";
            this.Updatebutton4.Size = new System.Drawing.Size(75, 31);
            this.Updatebutton4.TabIndex = 6;
            this.Updatebutton4.Text = "&Update";
            this.Updatebutton4.UseVisualStyleBackColor = true;
            // 
            // Savebutton5
            // 
            this.Savebutton5.Location = new System.Drawing.Point(331, 363);
            this.Savebutton5.Name = "Savebutton5";
            this.Savebutton5.Size = new System.Drawing.Size(75, 31);
            this.Savebutton5.TabIndex = 5;
            this.Savebutton5.Text = "&Save";
            this.Savebutton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 405);
            this.Controls.Add(this.Savebutton5);
            this.Controls.Add(this.Updatebutton4);
            this.Controls.Add(this.Editbutton3);
            this.Controls.Add(this.Deletebutton2);
            this.Controls.Add(this.Exitbutton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Master";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exitbutton1;
        private System.Windows.Forms.Button Deletebutton2;
        private System.Windows.Forms.Button Editbutton3;
        private System.Windows.Forms.Button Updatebutton4;
        private System.Windows.Forms.Button Savebutton5;
    }
}

