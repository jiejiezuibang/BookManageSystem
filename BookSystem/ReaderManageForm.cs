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
    public partial class ReaderManageForm : Form
    {
        public ReaderManageForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderManageForm_Load(object sender, EventArgs e)
        {
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            // 加载读者数据，为dgv控件赋值
            dgvReader.DataSource = readerMangeBll.GetReaderInfo();
        }
        /// <summary>
        /// 点击添加读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            // 显示添加读者页面
            AddReaderInfoForm.GetAddReaderInfoForm().ShowDialog();
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            // 加载读者数据，为dgv控件赋值
            dgvReader.DataSource = readerMangeBll.GetReaderInfo();
        }
        /// <summary>
        /// 点击修改读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateReaderInfo_Click(object sender, EventArgs e)
        {
            // 获得选中行索引
            int optColumn = dgvReader.CurrentRow.Index;
            ReaderInfoMod readerInfoMod = new ReaderInfoMod();
            // 为mod赋值
            readerInfoMod.ReaderID = dgvReader.Rows[optColumn].Cells["读者编号"].Value.ToString();
            readerInfoMod.ReadName = dgvReader.Rows[optColumn].Cells["读者姓名"].Value.ToString();
            readerInfoMod.EMail = dgvReader.Rows[optColumn].Cells["读者邮箱"].Value.ToString();
            readerInfoMod.Address = dgvReader.Rows[optColumn].Cells["读者地址"].Value.ToString();
            readerInfoMod.Mobile = dgvReader.Rows[optColumn].Cells["读者手机号码"].Value.ToString();
            // 显示修改页面
            new UpdateReadeInfoForm(readerInfoMod).ShowDialog();
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            // 加载读者数据，为dgv控件赋值
            dgvReader.DataSource = readerMangeBll.GetReaderInfo();
        }
        /// <summary>
        /// 点击删除读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelReaderInfo_Click(object sender, EventArgs e)
        {
            // 获得选中行索引
            int optColumn = dgvReader.CurrentRow.Index;
            ReaderInfoMod readerInfoMod = new ReaderInfoMod();
            // 获得读者编号
            readerInfoMod.ReaderID = dgvReader.Rows[optColumn].Cells["读者编号"].Value.ToString();
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            ReaderInfoEnums readerInfoEnums = readerMangeBll.DelReaderInfo(readerInfoMod);
            switch (readerInfoEnums)
            {
                case ReaderInfoEnums.DelSucess:
                    MessageBox.Show("删除成功");
                    // 加载读者数据，为dgv控件赋值
                    dgvReader.DataSource = readerMangeBll.GetReaderInfo();
                    break;
                case ReaderInfoEnums.DelError:
                    MessageBox.Show("删除失败");
                    break;
            }
        }
        /// <summary>
        /// 点击查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            ReaderInfoMod readerInfoMod = new ReaderInfoMod()
            {
                // 获取读者编号
                ReaderID = tbReaderID.Text,
            };
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            // 查询到结果后赋值
            dgvReader.DataSource = readerMangeBll.FindReaderInfo(readerInfoMod);
        }
    }
}
