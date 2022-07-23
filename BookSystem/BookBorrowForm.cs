using BLL.BookBorrowBLL;
using BLL.BookInfoBLL;
using BLL.ReaderMangeBLL;
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
    public partial class BookBorrowForm : Form
    {
        public BookBorrowForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询该读者信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindRederInfo_Click(object sender, EventArgs e)
        {
            // 判断用户是否有在读者输入框输入数据,没有就清空数据
            if (tbReaderID.Text.Trim() == "")
            {
                dgvBookBorrowInfo.DataSource = null;
                dgvBookInfo.DataSource = null;
                lbReaderID.Text = "";
                lbReaderName.Text = "";
                return;
            }
            ReaderInfoMod readerInfoMod = new ReaderInfoMod()
            {
                // 获取读者编号
                ReaderID = tbReaderID.Text,
            };
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            // 查询该读者信息
            DataTable dt = readerMangeBll.FindReaderInfo(readerInfoMod);
            if (dt.Rows.Count > 0)
            {
                // 给label控件赋值
                lbReaderID.Text = dt.Rows[0]["读者编号"].ToString();
                lbReaderName.Text = dt.Rows[0]["读者姓名"].ToString();
                BookInfoBll bookInfoBll = new BookInfoBll();
                // 获取图书数据并且赋值
                dgvBookInfo.DataSource = bookInfoBll.FindNotBorrowBookInfo();
                BookBorrowBll bookBorrowBll = new BookBorrowBll();
                BookBorrowReturnInfoMod bookBorrowReturnInfoMod = new BookBorrowReturnInfoMod()
                {
                    ReaderID = tbReaderID.Text,
                };
                // 获取读者借还书记录，并赋值
                dgvBookBorrowInfo.DataSource = bookBorrowBll.FindBorrowBookNotReturnInfo(bookBorrowReturnInfoMod);
            }
            else
            {
                MessageBox.Show("该读者不存在");
                // 清空dgv数据
                dgvBookInfo.DataSource = null;
                dgvBookBorrowInfo.DataSource = null;
            }
        }

        private void BookBorrowForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击确定借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // 获取图书编号
            string BookID = dgvBookInfo.Rows[dgvBookInfo.CurrentRow.Index].Cells["图书编号"].Value.ToString();
            // 获取读者编号
            string ReaderID = lbReaderID.Text;
            BookBorrowReturnInfoMod bookBorrowReturnInfoMod = new BookBorrowReturnInfoMod()
            {
                ReaderID = ReaderID,
                BookID = BookID,
                // 获取借书时间
                BorrowTime = DateTime.Now,
            };
            BookBorrowBll bookBorrowBLL = new BookBorrowBll();
            BookBorrowReturnInfoEnums borrowReturnInfoEnums = bookBorrowBLL.BookBorrow(bookBorrowReturnInfoMod);
            // 判断借书是否成功
            switch (borrowReturnInfoEnums)
            {
                case BookBorrowReturnInfoEnums.BookBorrowSuccess:
                    MessageBox.Show("借书成功");
                    // 刷新dgv
                    BookInfoBll bookInfoBll = new BookInfoBll();
                    // 获取图书数据并且赋值
                    dgvBookInfo.DataSource = bookInfoBll.FindNotBorrowBookInfo();
                    BookBorrowBll bookBorrowBll = new BookBorrowBll();
                    bookBorrowReturnInfoMod = new BookBorrowReturnInfoMod()
                    {
                        ReaderID = tbReaderID.Text,
                    };
                    // 获取读者借还书记录，并赋值
                    dgvBookBorrowInfo.DataSource = bookBorrowBll.FindBorrowBookNotReturnInfo(bookBorrowReturnInfoMod);
                    break;
                case BookBorrowReturnInfoEnums.BookBorrowError:
                    MessageBox.Show("借书失败");
                    break;
            }
        }
        /// <summary>
        /// 查询图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindBookInfo_Click(object sender, EventArgs e)
        {
            BookInfoBll bookInfoBll = new BookInfoBll();
            BookInfoMod bookInfoMod = new BookInfoMod
            {
                // 获取图书编号
                BookID = tbBookID.Text,
            };
            // 查询该编号相关的图书且给dgv赋值
            dgvBookInfo.DataSource = bookInfoBll.FindBookInfo(bookInfoMod);
        }
        /// <summary>
        /// 点击确认还书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // 获取图书编号
            string BookID = dgvBookBorrowInfo.Rows[dgvBookInfo.CurrentRow.Index].Cells["图书编号"].Value.ToString();
            // 获取读者编号
            string ReaderID = lbReaderID.Text;
            BookBorrowReturnInfoMod bookBorrowReturnInfoMod = new BookBorrowReturnInfoMod()
            {
                ReaderID = ReaderID,
                BookID = BookID,
                // 获取借书时间
                ReturnTime = DateTime.Now,
            };
            BookBorrowBll bookBorrowBLL = new BookBorrowBll();
            BookBorrowReturnInfoEnums borrowReturnInfoEnums = bookBorrowBLL.BookReturn(bookBorrowReturnInfoMod);
            // 判断借书是否成功
            switch (borrowReturnInfoEnums)
            {
                case BookBorrowReturnInfoEnums.BookReturnSuccess:
                    MessageBox.Show("还书成功");
                    // 刷新dgv
                    BookInfoBll bookInfoBll = new BookInfoBll();
                    // 获取图书数据并且赋值
                    dgvBookInfo.DataSource = bookInfoBll.FindNotBorrowBookInfo();
                    BookBorrowBll bookBorrowBll = new BookBorrowBll();
                    bookBorrowReturnInfoMod = new BookBorrowReturnInfoMod()
                    {
                        ReaderID = tbReaderID.Text,
                    };
                    // 获取读者借还书记录，并赋值
                    dgvBookBorrowInfo.DataSource = bookBorrowBll.FindBorrowBookNotReturnInfo(bookBorrowReturnInfoMod);
                    break;
                case BookBorrowReturnInfoEnums.BookReturnError:
                    MessageBox.Show("还书失败");
                    break;
            }
        }
    }
}
