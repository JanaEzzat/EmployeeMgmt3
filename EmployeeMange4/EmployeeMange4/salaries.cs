using EmployeeMange4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Salary : Form
    {
        Functions Con;
        public Salary()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalary();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "Select * from EmployeeTb1";
            EmpCb.DisplayMember =
                Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["Empid"].ToString();
            EmpCb.DataSource = Con.GetData(Q
                     }
        int DSal = 0;