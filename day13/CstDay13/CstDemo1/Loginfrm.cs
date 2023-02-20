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

namespace CstDemo1
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Username or Password is empty!");
            }

            // connect to database, retrieve user's creadentials
            string connStr = "uid=sa;pwd=005658;server=SHAWN\\CSTSQLSERVER;database=market";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"select count from UserInfo where username = " + txtUserName.Text + " and Userpassword = " + txtPassword.Text + ".";


                    object result = cmd.ExecuteScalar();

                    int rows = int.Parse(result.ToString());

                    if (rows >= 1)
                    {
                        MessageBox.Show("Login in successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is invalid!!!");
                    }
                }
            }
        }

    }
}
