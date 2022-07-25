using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystem
{
    public partial class BookMainForm : Form
    {
        // 定义一个委托 
        private delegate void SetDateTime();
        /// <summary>
        /// 设置窗体的状态栏信息标签
        /// </summary>
        private void toolStatusLable()
        {
            // 创建线程
            Thread thread = new Thread(new ThreadStart(DateTimeInfo)); // 线程函数调用
            // 设置为后台线程 后台线程：应用程序可以不考虑其是否已经运行完毕而直接退出，
            // 所有的后台线程在应用程序退出时都会自动结束
            thread.IsBackground = true;
            thread.Start(); // 开启线程
        }
        // 线程函数调用
        private void DateTimeInfo()
        {
            while (true) // 死循环
            {
                SetDateTime setDateTime = new SetDateTime(
                    delegate // 匿名委托
                    {
                        //显示窗口登录状态信息
                        this.toolStripStatusLabel1.Text = "状态：" + this.Tag + "已登录."
                        + "                                                 " +
                        " 欢迎使用该系统 "
                        + "                                                 " +
                        DateTime.Now.ToString();
                    }
                );
                // 调用该委托
                setDateTime();
            }
        }
        // 单例模式
        public static BookMainForm bookMainForm;
        // 获取BookMainForm页面
        public static BookMainForm GetBookMainForm()
        {
            if (bookMainForm == null)
            {
                bookMainForm = new BookMainForm();
            }
            return bookMainForm;
        }
        public BookMainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 在panIndex容器上显示相关控件
        /// </summary>
        /// <param name="form"></param>
        public void LoadForm(object form)
        {
            // 判断panIndex容器是否有控件
            if (panIndex.Controls.Count > 0)
            {
                // 清空容器里的控件
                panIndex.Controls.Clear();
            }
            // 转换为Form对象
            Form f = form as Form;
            // 设置为非顶级控件
            f.TopLevel = false;
            // 将控件位置设置为居中
            f.Dock = DockStyle.Fill;
            // 为panIndex容器添加控件
            this.panIndex.Controls.Add(f);
            this.panel2.Tag = f;
            // 显示容器
            f.Show();
        }
        /// <summary>
        /// 点击读者管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 读者管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ReaderManageForm());
        }
        /// <summary>
        /// 点击借还记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 借还记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new BorrowAnnalForm());
        }
        /// <summary>
        /// 点击图书管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new BookManageForm());
        }
        /// <summary>
        /// 点击图书借还
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new BookBorrowForm());
        }
        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭主程序
            Application.Exit();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookMainForm_Load(object sender, EventArgs e)
        {
            // 设置窗体的状态栏信息标签
            toolStatusLable();
        }
        /// <summary>
        /// 点击图书信息选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsrBtnBookInfo_Click(object sender, EventArgs e)
        {
            LoadForm(new BookManageForm());
        }
        /// <summary>
        /// 点击读者选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsrReaderInfo_Click(object sender, EventArgs e)
        {
            LoadForm(new ReaderManageForm());
        }
        /// <summary>
        /// 点击借还记录选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsrBtnBorrowAnnalInfo_Click(object sender, EventArgs e)
        {
            LoadForm(new BorrowAnnalForm());
        }
        /// <summary>
        /// 点击借还书选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsrBtnBorrowReturnInfo_Click(object sender, EventArgs e)
        {
            LoadForm(new BookBorrowForm());
        }
    }
}
