using MyAppBusiness;
using MyAppModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebutton5_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                try
                {

                    ModelClass obj = new ModelClass()
                    {
                        namep = nametextBox4.Text,
                        purchasep = purchasetextBox1.Text,
                        salep = saletextBox2.Text,
                        availablep = availableQtytextBox3.Text,
                        datap = dateTimePicker1.Value.ToString()
                    };
                    BusinessClass.businessMethod(obj, "i");
                    MessageBox.Show("Enter Data Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ShowData();
                    ClearRfocusKlyeMethod();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error in Code", ex.Message);
                }
            }
        }

        private void ClearRfocusKlyeMethod()
        {
            nametextBox4.Clear();
            saletextBox2.Clear();
            purchasetextBox1.Clear();
            availableQtytextBox3.Clear();
            nametextBox4.Focus();
        }

        private bool isvalid()
        {
            if(nametextBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name Textbox is Empty","ERROR !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                nametextBox4.Focus();
                return false;
            }
            if(purchasetextBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purchase Qty Textbox is Empty", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                purchasetextBox1.Focus();
                return false;
            }
            if(saletextBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Sale Qty Textbox is Empty", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saletextBox2.Focus();
                return false;
            }
            if(availableQtytextBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Available Qty Textbox is Empty", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                availableQtytextBox3.Focus();
                return false;
            }
          
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShowData();
            dataGridView1.Columns[0].Visible = false;
            Updatebutton4.Visible = false;
            
        }
        DataTable dt;
        private DataTable ShowData()
        {
            dt = new DataTable();

            string connectionstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionstring);

            SqlDataAdapter adapter = new SqlDataAdapter("select * from smtbl ", conn);
            adapter.Fill(dt);

            return dt;
        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dr = dt.DefaultView;

            dr.RowFilter = "Name Like '%" + textBox1.Text + "%'";


        }

        private void Deletebutton2_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                ModelClass obj = new ModelClass()
                {
                    namep = nametextBox4.Text,
                    purchasep = purchasetextBox1.Text,
                    salep = saletextBox2.Text,
                    availablep = availableQtytextBox3.Text,
                    datap = dateTimePicker1.Value.ToString()
                };
                BusinessClass.businessMethod(obj, "del");
                MessageBox.Show("Delete Data Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ShowData();
                ClearRfocusKlyeMethod();
            }
        }
        private void Updatebutton4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are You Sure..You want to Update Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (isvalid())
                {
                    ModelClass obj = new ModelClass()
                    {
                        namep = nametextBox4.Text,
                        purchasep = purchasetextBox1.Text,
                        salep = saletextBox2.Text,
                        availablep = availableQtytextBox3.Text,
                        datap = dateTimePicker1.Value.ToString()
                    };

                    BusinessClass.businessMethod(obj, "up");
                    MessageBox.Show("Update Data Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ShowData();
                    ClearRfocusKlyeMethod();
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int updaterow = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string obj = Convert.ToString(dataGridView1.Rows[updaterow].Cells[1].Value);
            string obj1 = Convert.ToString(dataGridView1.Rows[updaterow].Cells[2].Value);
            string obj2 = Convert.ToString(dataGridView1.Rows[updaterow].Cells[3].Value);
            string obj3 = Convert.ToString(dataGridView1.Rows[updaterow].Cells[4].Value);
            string obj4 = Convert.ToString(dataGridView1.Rows[updaterow].Cells[5].Value);



            nametextBox4.Text            = obj.ToString();
            saletextBox2.Text            = obj1.ToString();
            purchasetextBox1.Text        = obj2.ToString();
            availableQtytextBox3.Text    = obj3.ToString();
            dateTimePicker1.Value        = Convert.ToDateTime(obj4);

            Updatebutton4.Visible = true;
            Savebutton5.Visible = false;
        }

        private void availableQtytextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }

        private static void EnterOnlyNumberMethod(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                MessageBox.Show("Enter only Number", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void purchasetextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }

        private void saletextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }
    }
}

