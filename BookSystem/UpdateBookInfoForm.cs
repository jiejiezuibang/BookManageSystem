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
    public partial class UpdateBookInfoForm : Form
    {
        Func<string> FuncBookID = null;
        public UpdateBookInfoForm(Func<string> GetBookID)
        {
            this.FuncBookID = GetBookID;
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBookInfoForm_Load(object sender, EventArgs e)
        {
            string BookID = FuncBookID();
            BookInfoBll bookInfoBll = new BookInfoBll();
            BookInfoMod bookInfoMod = new BookInfoMod()
            {
                BookID = BookID
            };
            // 获得指定图书信息
            DataTable dt = bookInfoBll.FindBookInfo(bookInfoMod);
            // 给控件赋值
            tbBookID.Text = dt.Rows[0]["图书编号"].ToString();
            tbBookName.Text = dt.Rows[0]["图书名称"].ToString();
            tbAuthor.Text = dt.Rows[0]["图书作者"].ToString();
            tbPrice.Text = dt.Rows[0]["图书价格"].ToString();
            DataTable dtBookType = bookInfoBll.GetBookCreategory();
            
            // 渲染下拉框
            cbBookType.DataSource = dtBookType; // 数据源
            cbBookType.DisplayMember = "CategoryName"; // 展示内容
            cbBookType.ValueMember = "CategoryID"; // 实际需要的数据
            for (int i = 0; i < dtBookType.Rows.Count; i++)
            {
                if (dt.Rows[0]["图书类型"].ToString() == dtBookType.Rows[i]["CategoryName"].ToString())
                {
                    // 给下拉框赋值
                    cbBookType.SelectedValue = dtBookType.Rows[i]["CategoryID"];
                    cbBookType.Text = dtBookType.Rows[i]["CategoryName"].ToString();
                }
            }
        }
        /// <summary>
        /// 点击修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            BookInfoBll bookInfoBll = new BookInfoBll();
            // 获取要修改的数据
            BookInfoMod bookInfoMod = new BookInfoMod()
            {
                BookID = tbBookID.Text.Trim(),
                Name = tbBookName.Text.Trim(),
                Author = tbAuthor.Text.Trim(),
                Money = Convert.ToDouble(tbPrice.Text),
                CategoryType = Convert.ToInt32(cbBookType.SelectedValue)
            };
            // 执行修改操作
            BookInfoEnums bookInfoEnums = bookInfoBll.UpdateBookInfo(bookInfoMod);
            switch (bookInfoEnums)
            {
                case BookInfoEnums.UpdateBookInfoSuccess:
                    MessageBox.Show("修改成功");
                    this.Close();
                    break;
                case BookInfoEnums.UpdateBookInfoError:
                    MessageBox.Show("修改失败");
                    break;
            }
        }
    }
}
