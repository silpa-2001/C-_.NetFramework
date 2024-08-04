using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarkListApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.modelDataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SILPA\\source\\repos\\StudentMarkListApp\\StudentMarkListApp\\Database.mdf;Integrated Security=True";
            string qry = @"SELECT s.SId,s.Sname,s.Gender,s.[Phone No] as PhoneNo,s.DOB,m.Marks FROM Student s LEFT JOIN Mark m on s.SId=m.SId";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlDataAdapter ad=new SqlDataAdapter(qry, conn))
            {
                conn.Open();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}
