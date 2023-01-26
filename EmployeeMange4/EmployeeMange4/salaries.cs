using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMange4
{
    public partial class salaries : Form
    {
        public salaries()
        {
            InitializeComponent();
        }

        private void salaries_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
               else
            {
                string Dep = DepNameTb.Text;
                string Query = "Delete from DepartmentTb1 where Depid = {0}";
                Query = string.Format(Query, key);
                Con.SetData(Query);
                ShowDepartments();
                MessageBox.Show("Department Deleted!!!");
                DepNameTb.Text = "";
            }
        }
    }
    }
}
