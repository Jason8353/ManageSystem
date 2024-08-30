using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
namespace userForm
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=127.0.0.1;database=test;user=newuser;password=zhj1314.";
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            test0.Class1 mydll = new test0.Class1();
            MessageBox.Show(mydll.Hello());
            connection = new MySqlConnection(connectionString);
            if (connection !=null)
            {
                //MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("加载");
        

        }


        private void labelNav_Click(object sender, EventArgs e)
        {

        }

        private void timerBtn_Click(object sender, EventArgs e)
        {
            /// 清除 panel 中现有的控件
           panelContainer.Controls.Clear();

            // 创建自定义控件的实例
            UserControl1 myControl = new UserControl1();

            // 设置自定义控件的停靠样式，使其填充整个 Panel
            myControl.Dock = DockStyle.Fill;

            // 将自定义控件添加到 Panel 中
            panelContainer.Controls.Add(myControl);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                btnInsert.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);   //去除点击后的黑色边框，设为透明
                connection.Open();
                string query = "INSERT INTO student (id, name, age) VALUES (@id, @name, @age)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("插入成功！");
                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dataGridView = new DataGridView();
                MessageBox.Show("点击");
                dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
                dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView.Location = new System.Drawing.Point(72, 231);
                dataGridView.Name = "dataGridView";
                dataGridView.RowHeadersWidth = 62;
                dataGridView.RowTemplate.Height = 30;
                dataGridView.Size = new System.Drawing.Size(500, 224);
                dataGridView.TabIndex = 9;

                // 添加一些列到 DataGridView 中（可选）
                //dataGridView.Columns.Add("Column1", "列1");
                //dataGridView.Columns.Add("Column2", "列2");
                //dataGridView.Columns.Add("Column3", "列3");

                //// 添加一些行到 DataGridView 中（可选）
                //dataGridView.Rows.Add("数据1", "数据2", "数据3");
                //dataGridView.Rows.Add("数据4", "数据5", "数据6");

                // 将 DataGridView 添加到窗体的控件集合中
                //this.Controls.Add(dataGridView);
                this.panelContainer.Controls.Add(dataGridView);

                btnRead.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);   //去除点击后的黑色边框，设为透明
                connection.Open();
                string query = "SELECT id, name, age FROM student";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            // 模态显示 Form2
            form2 form2 = new form2();
            //form2.Show();
            form2.ShowDialog();

            // 当 Form2 关闭后，Form1 将重新显示
            //this.Show();
            //this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);   //去除点击后的黑色边框，设为透明
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
