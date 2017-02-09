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

namespace From1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“db_TestDemoDataSet.UserInfo”中。您可以根据需要移动或删除它。
            LoadDlag(0);

        }
        private static readonly string str = "Data Source=192.168.0.109;Initial Catalog=db_TestDemo;User ID=sa;Password=sa123";

        private void LoadDlag(int p)
        {
            List<UserInfo> list = new List<UserInfo>();

            using(SqlConnection con = new SqlConnection(str))
            {
                string sql = "select * from  UserInfo where Dlag = "+ p;

                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                    	{
		                    while (reader.Read())
	                        {
	                            UserInfo ui = new UserInfo();
                                ui.UserId = Convert.ToInt32(reader["UserId"]);
                                ui.UserName = reader["UserName"].ToString();
                                ui.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                                ui.UserPassword = reader["UserPassword"].ToString();
                                ui.UserBirthday = Convert.ToDateTime(reader["UserBirthday"]);
                                ui.UserAge = Convert.ToInt32(reader["UserAge"]);
                                list.Add(ui);
	                        }
	                    }
                    }
                }
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = list;
                labelCount();
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            List<UserInfo> list = new List<UserInfo>();
            string name = TxtBox.Text;
            using (SqlConnection con = new SqlConnection(str))
            {
              string sql = string.Format("select * from  UserInfo where UserName = '{0}'",name);
              using (SqlCommand cmd = new SqlCommand(sql,con))
              {
                  con.Open();
                  using (SqlDataReader reader = cmd.ExecuteReader())
                  {
                      if (reader.HasRows)
                      {
                          while (reader.Read())
                          {
                              UserInfo ui = new UserInfo();
                              ui.UserId = Convert.ToInt32(reader["UserId"]);
                              ui.UserName = reader["UserName"].ToString();
                              ui.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                              ui.UserPassword = reader["UserPassword"].ToString();
                              ui.UserBirthday = Convert.ToDateTime(reader["UserBirthday"]);
                              ui.UserAge = Convert.ToInt32(reader["UserAge"]);
                              list.Add(ui);
                          }
                      }
                  }
              }
            }
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = list;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(str))
            {
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                DateTime dt = DateTime.Now; 
                DateTime createDate = Convert.ToDateTime(dt);
                string pwd = txtPwd.Text;
                int age = (int)dt.Year - (int)dtp.Value.Year ;
                try
                {
                string sql = string.Format("insert into UserInfo(UserId,UserName,UserPassword,createDate,UserBirthday,UserAge,Dlag) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, name, pwd, createDate, dtp.Value,age,0);
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                         con.Open();
                         n = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("输入错误");
                }             
            }
            string msg = n > 0 ? "操作成功" : "操作失败";
            MessageBox.Show(msg);
            LoadDlag(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count>0)
            {
                string strId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(strId);
                int n = -1;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = "update UserInfo set Dlag = 1 where UserId = "+ id;
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        con.Open();
                        n = cmd.ExecuteNonQuery();
                    }
                }
                string msg = n > 0 ? "删除成功" : "删除失败";
                MessageBox.Show(msg);
                LoadDlag(0);
            }
        }

        #region 显示总个数
        private void labelCount()
        {
            object obj;
            //练习
            using (SqlConnection con = new SqlConnection(str))
            {
                string sql = "select count(*) from UserInfo where Dlag = 0";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();

                    obj = cmd.ExecuteScalar();
                }
            }
            labCount.Text = obj.ToString();
        }
        #endregion

    }
}
