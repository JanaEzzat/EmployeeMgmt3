
using System.Drawing;
using System.Windows.Forms;
using System;

DailySalTb.Text = "";
GenCb.SelectedIndex = -1;
DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
{
    MessageBox.Show(Ex.Message);
}
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
{
    try
    {
        if (EmpNameTb.Text == ""  Ge
                DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
    MessageBox.Show("missing data!!!");
}
                else
    string Name = EmpNameTb.Text;
string Gender = GenCb.SelectedItem.ToString();
int Dep =
    Convert.ToInt32(DepCb.SelectedValue.ToString());
string DOB = DOBTb.Value.Date.ToString();
string JDate = JDateTb.Value.Date.ToString();
int Salary = Convert.ToInt32(DailySalTb.Text);
string Query = "Update EmployeeTb1 set EmpName = {0}',EmpGen='{1}',EmpDep={2},EmpDOB='{3}',Empjdate='{4}',EmpSal={5} where Empid= {6}\";\r\n                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary,key);
 Con.SetData(Query);
ShowEmp();
MessageBox.Show("Emoloyee Updated!!!");
EmpNameTb.Text = "";
DailySalTb.Text = "";
GenCb.SelectedIndex = -1;