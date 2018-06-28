using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trafic.Business.Business;
using Trafic.Business.Model;
namespace Trafic.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            textEdit1.ForeColor = Color.Gray;
            textEdit1.Text = "Username";
            textEdit2.ForeColor = Color.Gray;
            textEdit2.Text = "Password";
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter||e.KeyCode==Keys.Up)
            {
                AccountBO a = new AccountBO();
                List<Account> b = a.CheckUser(textEdit1.Text);

                if (textEdit1.Text == ""||textEdit1.Text=="Username")
                {
                    labelControl2.Text = "Please complete all information!";
                    labelControl2.Location = new Point(52, 150);
                    labelControl2.Size = new Size(225, 25);
                    labelControl2.ForeColor = Color.Red;
                    labelControl2.Visible = true;
                    textEdit1.Focus();
                }
                else
                {
                    labelControl2.Visible = false;
                    if (b.Count.ToString() == "0")
                    {
                        labelControl2.Text = "The username don't alreally exixts. Please check again!";
                        labelControl2.Location = new Point(52, 150);
                        labelControl2.Size = new Size(225, 25);
                        labelControl2.ForeColor = Color.Red;
                        labelControl2.Visible = true;
                        textEdit1.Focus();
                    }
                    if (b.Count.ToString() == "1")
                    {
                        textEdit2.Focus();
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_MouseLeave(object sender, EventArgs e)
        {
            if(textEdit1.Text=="")
            {
                textEdit1.Text = "Username";
                textEdit1.ForeColor = Color.Gray;
            }
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "Username")
            {
                textEdit1.Text = "";
                
            }
        }

        private void textEdit2_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void textEdit2_MouseLeave(object sender, EventArgs e)
        {
            if (textEdit2.Text == "")
            {
                textEdit2.Text = "Password";
                textEdit2.ForeColor = Color.Gray;

            }

        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            if (textEdit2.Text == "Password")
            {
                textEdit2.Text = "";

            }
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {


                if (textEdit2.Text == "" || textEdit2.Text == "Password")
                {
                    labelControl2.Text = "Please complete all information!";
                    labelControl2.Location = new Point(52, 210);
                    labelControl2.Size = new Size(225, 25);
                    labelControl2.ForeColor = Color.Red;
                    labelControl2.Visible = true;
                    textEdit2.Focus();
                }
                else
                {
                    labelControl2.Visible = false;
                    simpleButton1.Focus();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AccountBO a = new AccountBO();
            List<Account> list = a.CheckAccount(textEdit1.Text, textEdit2.Text);
            if (list.Count.ToString() == "0")
            {
                labelControl2.Text = "Login failed.Please check check the password again!";
                labelControl2.Location = new Point(52, 210);
                labelControl2.Size = new Size(225, 25);
                labelControl2.ForeColor = Color.Red;
                labelControl2.Visible = true;
                MessageBox.Show("NO");
                textEdit2.Focus();
            }
            if (list.Count.ToString() == "1")
            {
                MessageBox.Show("OK");
            }
        }
    }
}
