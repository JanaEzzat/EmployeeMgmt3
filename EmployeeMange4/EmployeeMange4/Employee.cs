
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
  