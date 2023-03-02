using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CstDemo1
{
    public partial class MainFrm : Form
    {
        private int updateUserID = 0;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            List<UserInfo> userList = new List<UserInfo>();

            //MessageBox.Show("Data Loading!!!");
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            string sql = "SELECT * FROM dbo.userInfo WHERE DelFlag = 0;";

            using (SqlDataAdapter adapter = new SqlDataAdapter(sql,connStr))
            {
                // read data from DB
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    // add all data into list(UserInfo)
                    UserInfo userInfo = new UserInfo();
                    userInfo.UserID = int.Parse(dataRow["UserID"].ToString());
                    userInfo.UserName = dataRow["UserName"].ToString();
                    userInfo.UserAge = int.Parse(dataRow["UserAge"].ToString());
                    userInfo.UserEmail = dataRow["UserEmail"].ToString();
                    userInfo.UserMobile = dataRow["UserMobile"].ToString();
                    userInfo.DelFlag = short.Parse(dataRow["DelFlag"].ToString());
                    userList.Add(userInfo);
                }

                this.dgvUserInfo.DataSource = userList;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("delete");

            if (this.dgvUserInfo.SelectedRows.Count<=0)
            {
                MessageBox.Show("please select at least one row");
            }

            int deleteUserID = int.Parse(this.dgvUserInfo.SelectedRows[0].Cells["UserID"].Value.ToString());
            

            //MessageBox.Show(deleteUserID.ToString());

            string connStr =ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn =new SqlConnection(connStr))
            {

                conn.Open();

                // Description of SQL.
                // @UserID must be added as na new SqlParameter.

                using (SqlCommand cmd=new SqlCommand("UPDATE dbo.userInfo SET DelFlag=1 WHERE UserID=@UserID;", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", deleteUserID);

                    // check delete done.
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("record deletes successfully!!!");
                    }

                    // refresh the data.
                    LoadUserInfo();

                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserInfoAddFrm addfrm = new UserInfoAddFrm();

            if (addfrm.Visible == false)
            {
                addfrm.Show();
            }      
           
            
        }

        private void dgvUserInfo_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("data selected!!");
            //MessageBox.Show(this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString());

            // check if row is selected.
            if (this.dgvUserInfo.SelectedRows.Count <= 0)
            {
                return;
            }

            int selectRowID = int.Parse(this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString());
            updateUserID = selectRowID;

            // open database, get userinof by selectUserID.


            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select * from userInfo where UserID =@UserID";
                    cmd.Parameters.AddWithValue("@UserID", selectRowID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.txtUserName.Text = reader["UserName"].ToString();
                            this.txtUserAge.Text = reader["UserAge"].ToString();
                            this.TxtUserEmail.Text = reader["UserEmail"].ToString();
                            this.txtUserMobile.Text = reader["UserMobile"].ToString();

                        }
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save update record to database.

            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update userinfo set userName=@UserName,userAge=@UserAge,userEmail=@UserEmail,userMobile=@UserMobile where userID=@UserID;";

                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@UserAge", int.Parse(txtUserAge.Text));
                    cmd.Parameters.AddWithValue("@UserEmail", TxtUserEmail.Text);
                    cmd.Parameters.AddWithValue("@UserMobile", txtUserMobile.Text);
                    cmd.Parameters.AddWithValue("@UserID", updateUserID);

                    int nums = cmd.ExecuteNonQuery();
                    if (nums > 0)
                    {
                        MessageBox.Show("record saved success!!!");
                    }
                    else
                    {
                        MessageBox.Show("record saved failure!!!");
                    }
                }
            }
            LoadUserInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Search database with UserName!!!");
            // create one static method for sql connection string.

            string connStr = SqlHelper.GetSqlConnectionString();

            // dataadapter read records.

            string sqlTxt = "select * from UserInfo";

            List<string> whereList = new List<string>();    // declare whereList
            List<SqlParameter> parameters = new List<SqlParameter>(); // declare parameters list.

            // first condition -- userName
            if (!string.IsNullOrEmpty (this.txtSearchName.Text.Trim()))
            {
                // Add condition userName to whereList
                whereList.Add(" UserName LIKE @UserName ");

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.Value = "%" + txtSearchName.Text.Trim() + "%";
                parameters.Add(parameter);
            };

            // second condition -- userEmail
            if (!string.IsNullOrEmpty(this.txtSearchEmail.Text.Trim()))
            {
                whereList.Add(" UserEmail LIKE @userEmail ");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@userEmail";
                parameter.Value = "%" + txtSearchEmail.Text.Trim() + "%";
                parameters.Add(parameter);
            }

            // third condition -- userMobile
            if (!string.IsNullOrEmpty(this.txtSearchMobile.Text.Trim()))
            {
                whereList.Add(" UserMobile LIKE @userMobile ");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@userMobile";
                parameter.Value = "%" + txtSearchMobile.Text.Trim() + "%";
                parameters.Add(parameter);
            }


            if (whereList.Count>0)
            {
                sqlTxt += " where " + string.Join(" and ", whereList);
            }

            List<UserInfo> userList = new List<UserInfo>();

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlTxt,connStr))
            {
                adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //this.dgvUserInfo.DataSource = dt;

                foreach (DataRow datarow in dt.Rows)
                {
                    UserInfo userinfo = new UserInfo();

                    userinfo.UserName = datarow["UserName"].ToString();
                    userinfo.UserID = int.Parse(datarow["UserID"].ToString());
                    userinfo.UserMobile = datarow["UserMobile"].ToString();
                    userinfo.UserEmail = datarow["UserEmail"].ToString();
                    userinfo.UserAge = int.Parse(datarow["UserAge"].ToString());
                    userinfo.DelFlag = short.Parse(datarow["DelFlag"].ToString());

                    userList.Add(userinfo);
                }
                this.dgvUserInfo.DataSource=userList;
            }
        }
    }
}
