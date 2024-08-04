using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentMarkListApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool anyEmpty=false;
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    if(string.IsNullOrEmpty(c.Text))
                    {
                        anyEmpty = true;
                        break;
                    }
                }
            }
            if(anyEmpty)
            {
                MessageBox.Show("ERROR: Field is empty.Please fill it.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AE62QS40\\SQLEXPRESS;Initial Catalog=MarkList;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string qry = "INSERT INTO login(username,password) VALUES(@username,@password)";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@username",textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful! You can now click LOGIN to login.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
