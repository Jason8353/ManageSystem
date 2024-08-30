using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace userForm
{
    public partial class login : Form
    {
        private string connectionString = "server=127.0.0.1;database=test;user=newuser;password=zhj1314.";
      
        public login()
        {
            InitializeComponent();
            // 初始状态为隐藏密码
            txtPsd.PasswordChar = '*';
            // 绑定复选框事件

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUid.Text;
            string password = txtPsd.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                
                MessageBox.Show("用户名或密码错误！");
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM user WHERE uid = @username AND psd = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            isValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"数据库连接错误: {ex.Message}");
                }
            }
            return isValid;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // 显示明文密码
                txtPsd.PasswordChar = '\0';
            }
            else
            {
                // 显示密文密码
                txtPsd.PasswordChar = '*';
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
