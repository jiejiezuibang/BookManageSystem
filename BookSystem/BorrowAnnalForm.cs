using BLL.BorrowAnnalBLL;
using MOD;
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
    public partial class BorrowAnnalForm : Form
    {
        public BorrowAnnalForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrowAnnalForm_Load(object sender, EventArgs e)
        {
            BorrowAnnalBll borrowAnnalBll = new BorrowAnnalBll();
            // 为控件赋值
            dgvBorrowAnnalInfo.DataSource = borrowAnnalBll.GetBorrowAnnalInfo();
        }
        /// <summary>
        /// 点击查询查找读者借还书记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindBorrowAnnal_Click(object sender, EventArgs e)
        {
            BorrowAnnalMod borrowAnnalMod = new BorrowAnnalMod()
            {
                // 获取读者编号
                ReaderID = tbReaderID.Text.Trim(),
            };
            BorrowAnnalBll borrowAnnalBll = new BorrowAnnalBll();
            dgvBorrowAnnalInfo.DataSource = borrowAnnalBll.FindBorrowAnnalInfo(borrowAnnalMod);
        }
    }
}
