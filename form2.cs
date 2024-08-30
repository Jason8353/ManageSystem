using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userForm
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            panelMsgContaioner.Visible = false;
            buttonRightIcon.ContextMenuStrip = contextMenuStrip1;  //绑定到按钮上
          
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        
       /**** 鼠标事件*****/



        private void btnInbox_MouseEnter(object sender, EventArgs e)
        {
            // 设置左侧边框为白色，宽度为2像素
            //btnInbox.FlatAppearance.BorderSize = 1;
            //btnInbox.FlatAppearance.BorderColor = Color.Transparent;
            //btnInbox.Padding = new Padding(5, 0, 0, 0); // 增加左侧的内边距
            btnInbox.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181); // 改变背景颜色
            btnInbox.Paint += (s, pe) =>
            {
                pe.Graphics.FillRectangle(Brushes.White, 0, 0, 3, btnInbox.Height); // 左侧绘制白色条
            };
        }

        private void btnInbox_MouseLeave(object sender, EventArgs e)
        {
            // 恢复原始样式  这里采取绘制为原来的颜色
            //btnInbox.FlatAppearance.BorderSize = 0;
            //btnInbox.Padding = new Padding(0,0,0,0);
            btnInbox.Paint += (s, pe) =>
           
            {
                Color customColor = Color.FromArgb(94, 107, 157);
                using (Brush brush = new SolidBrush(customColor))
                    pe.Graphics.FillRectangle(brush, 0, 0, 3, btnInbox.Height); // 左侧绘制白色条
            };
            btnInbox.Invalidate(); // 强制按钮重绘
        }

        private void btnSent_MouseEnter(object sender, EventArgs e)
        {
            btnSent.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181); // 改变背景颜色
            btnSent.Paint += (s, pe) =>
            {
                pe.Graphics.FillRectangle(Brushes.White, 0, 0, 3, btnSent.Height); // 左侧绘制白色条
            };
        }

        private void btnSent_MouseLeave(object sender, EventArgs e)
        {
            // 恢复原始样式  这里采取绘制为原来的颜色
            //btnInbox.FlatAppearance.BorderSize = 0;
            //btnInbox.Padding = new Padding(0,0,0,0);
            btnSent.Paint += (s, pe) =>

            {
                Color customColor = Color.FromArgb(94, 107, 157);
                using (Brush brush = new SolidBrush(customColor))
                    pe.Graphics.FillRectangle(brush, 0, 0, 3, btnSent.Height); // 左侧绘制白色条
            };
            btnSent.Invalidate(); // 强制按钮重绘
        }

        private void btnDraft_MouseEnter(object sender, EventArgs e)
        {
            btnDraft.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181); // 改变背景颜色
            btnDraft.Paint += (s, pe) =>
            {
                pe.Graphics.FillRectangle(Brushes.White, 0, 0, 3, btnDraft.Height); // 左侧绘制白色条
            };
        }

        private void btnDraft_MouseLeave(object sender, EventArgs e)
        {
            btnDraft.Paint += (s, pe) =>

            {
                Color customColor = Color.FromArgb(94, 107, 157);
                using (Brush brush = new SolidBrush(customColor))
                    pe.Graphics.FillRectangle(brush, 0, 0, 3, btnDraft.Height); // 左侧绘制白色条
            };
            btnDraft.Invalidate(); // 强制按钮重绘
        }

        private void btnSpam_MouseEnter(object sender, EventArgs e)
        {
            btnSpam.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181); // 改变背景颜色
            btnSpam.Paint += (s, pe) =>
            {
                pe.Graphics.FillRectangle(Brushes.White, 0, 0, 3, btnSpam.Height); // 左侧绘制白色条
            };
        }

        private void btnSpam_MouseLeave(object sender, EventArgs e)
        {
            btnSpam.Paint += (s, pe) =>

            {
                Color customColor = Color.FromArgb(94, 107, 157);
                using (Brush brush = new SolidBrush(customColor))
                    pe.Graphics.FillRectangle(brush, 0, 0, 3, btnSpam.Height); // 左侧绘制白色条
            };
            btnSpam.Invalidate(); // 强制按钮重绘
        }

        private void btnTrash_MouseEnter(object sender, EventArgs e)
        {
            btnTrash.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 81, 181); // 改变背景颜色
            btnTrash.Paint += (s, pe) =>
            {
                pe.Graphics.FillRectangle(Brushes.White, 0, 0, 3, btnTrash.Height); // 左侧绘制白色条
            };
        }

        private void btnTrash_MouseLeave(object sender, EventArgs e)
        {
            btnTrash.Paint += (s, pe) =>

            {
                Color customColor = Color.FromArgb(94, 107, 157);
                using (Brush brush = new SolidBrush(customColor))
                    pe.Graphics.FillRectangle(brush, 0, 0, 3, btnTrash.Height); // 左侧绘制白色条
            };
            btnTrash.Invalidate(); // 强制按钮重绘
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "search")
            {
                txtSearch.Text = "";
                //labelSearchIcon.Visible = false;
            }
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "search";
            }
        }

        private void labelSender2_Click(object sender, EventArgs e)
        {
            panelMsgContaioner.Visible = true;
        }










        /**** 鼠标事件*****/
    }
}
