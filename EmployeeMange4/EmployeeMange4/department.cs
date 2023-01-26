﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMange4
{
    public partial class department : Form
    {
        Functions Con;

        public object DepList { get; private set; }

        public department()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "Select= form DepartmentTbl";
            DepList.DataSource = Con.GetData(Query);



        }
        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTbl values({0})";
                    Query = string.Format( Query.DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text="";



                }

            }
            
                catch(Exception EX){
                MessageBox.Show(EX.Message);
                }

            
           
        }
        int key = 0;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepNameTb.Text = DepList.SelectedRows[0].cells[1].value.ToString();
            if (DepNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key=Convert.ToInt32(DepList.SelectedRows[0].cells[0].value.ToString())
            }

        }
           

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void department_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
