using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CstDemo1
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("data loading!!!");
            LoadUserInfo();
        }

        // Load all user data from DB.
        private void LoadUserInfo()
        {
            List<UserInfo> userList = new List<UserInfo>();

            //MessageBox.Show("data loading!!!");
            string connStr = ConfigurationManager.ConnectionStrings["strSql"].ConnectionString;

            //string connStr = @"uid=sa;pwd=005658;server=SHAWN\CSTSQLSERVER;database=market";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select * from userinfo where DelFlag=0";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserInfo userInfo = new UserInfo();
                            userInfo.UserName = reader["UserName"].ToString();
                            userInfo.UserAge = int.Parse(reader["UserAge"].ToString ());
                            //if (reader["UserAge"] is null)
                            //{
                            //    userInfo.UserAge = int.Parse(reader["UserAge"].ToString());
                            //}
                            //else
                            //{
                            //    userInfo.UserAge = 21;
                            //}

                            userInfo.UserEmail = reader["UserEmail"].ToString();
                            userInfo.UserMobile = reader["UserMobile"].ToString();

                            userList.Add(userInfo);
                        }// end loop
                    }// end datareader
                }// end sqlcommand

            }// end connection

            this.dgvUserInfo.DataSource = userList;
        }
    }
}