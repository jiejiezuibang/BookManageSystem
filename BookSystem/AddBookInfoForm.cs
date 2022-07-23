using BLL.BookInfoBLL;
using MOD;
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
    public partial class AddBookInfoForm : Form
    {
        public AddBookInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击添加图书按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookInfoBll bookInfoBll = new BookInfoBll();
            // 获取添加图书页面输入框中的参数
            BookInfoMod bookInfoMod = new BookInfoMod()
            {
                BookID = tbBookID.Text.Trim(),
                Name = tbBookName.Text.Trim(),
                Author = tbAuthor.Text.Trim(),
                Money = Convert.ToDouble(tbPrice.Text),
                // cbBookType.SelectedValue 获取选中实际需要的值
                CategoryType = Convert.ToInt32(cbBookType.SelectedValue)
            };
            // 执行添加操作
            BookInfoEnums bookInfoEnums = bookInfoBll.AddBookInfo(bookInfoMod);
            // 判断是否添加成功
            switch (bookInfoEnums)
            {
                case BookInfoEnums.AddBookInfoSuccess:
                    MessageBox.Show("添加成功");
                    this.Close();
                    break;
                case BookInfoEnums.AddBookInfoError:
                    MessageBox.Show("添加失败");
                    break;
            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBookInfoForm_Load(object sender, EventArgs e)
        {
            BookInfoBll bookInfoBll = new BookInfoBll();
            // 获取图书类别
            DataTable dt = bookInfoBll.GetBookCreategory();
            // 渲染下拉框
            cbBookType.DataSource = dt; // 数据源
            cbBookType.DisplayMember = "CategoryName"; // 展示内容
            cbBookType.ValueMember = "CategoryID"; // 实际需要的数据
        }
    }
}
