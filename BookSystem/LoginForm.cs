using BLL.LoginBLL;
using MOD.Enums;
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
        /// 登录状态信息
        /// </summary>
        /// <param name="LoginID"></param>
        /// <param name="loginStateEnms"></param>
        private void LoginState(string LoginID,LoginStateEnms loginStateEnms)
        {
            switch (loginStateEnms)
            {
                case LoginStateEnms.Ok:
                    BookMainForm bookMainForm = new BookMainForm();
                    bookMainForm.Tag = LoginID; // 将账号传递给BookMainForm控件
                    bookMainForm.Show(); // 显示BookMainForm控件
                    this.Hide(); // 隐藏当前控件
                    break;
                case LoginStateEnms.LoginIDError:
                    // 清空账号密码
                    tbName.Text = "";
                    tbPwd.Text = "";
                    MessageBox.Show("用户名错误");
                    break;
                case LoginStateEnms.LoginPwdError:
                    // 清空账号密码
                    tbName.Text = "";
                    tbPwd.Text = "";
                    MessageBox.Show("密码错误");
                    break;
            }
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
            // 判断输入框是否为空
            if(Name == ""||Pwd == "")
            {
                MessageBox.Show("账号或密码不能为空");
            }
            else
            {
                // 创建登录信息业务 业务逻辑层对象
                LoginBll loginBll = new LoginBll();
                // 得到用户的登录状态信息
                LoginStateEnms loginStateEnms = loginBll.LoginCheck(Name, Pwd);
                // 显示登录状态信息
                LoginState(Name, loginStateEnms);
            }
        }
    }
}
