﻿
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