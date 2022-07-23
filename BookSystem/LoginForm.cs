using BLL.LoginBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text.Trim();
            string Pwd = tbPwd.Text.Trim();
            if(Name == ""||Pwd == "")
            {
                MessageBox.Show("输入框不能为空");
            }
            else
            {
                LoginBll loginBll = new LoginBll();
                string status = loginBll.LoginCheck(Name, Pwd);
                if (status == "200")
                {
                    // 将当前页面隐藏
                    this.Hide();
                    // 创建并显示BookMainForm
                    BookMainForm.GetBookMainForm().Show();
                }
                else if (status == "400")
                {
                    MessageBox.Show("登录失败，账号或密码错误");
                    tbName.Text = "";
                    tbPwd.Text = "";
                }
                else
                {
                    MessageBox.Show(status);
                }
            }
        }
    }
}
