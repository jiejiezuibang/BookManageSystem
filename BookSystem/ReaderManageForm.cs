using BLL;
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
        // 获取读者信息业务对象
        ReaderMangeBll readerMangeBll = BLLFactory.GetReaderMangeB;
        // 读者信息数据
        private ReaderInfoMod readerInfoMod = null;
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
        /// <summary>
        /// 点击右键菜单的添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 显示添加读者页面
            new AddReaderInfoForm().ShowDialog();
            // 加载读者数据，为dgv控件赋值
            dgvReader.DataSource = readerMangeBll.GetReaderInfo();
        }
        /// <summary>
        /// 右键菜单点击删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 获取选中行的ID
            int ID = Convert.ToInt32(dgvReader.Rows[dgvReader.CurrentRow.Index].Cells["ID"].Value);
            readerInfoMod = new ReaderInfoMod()
            {
                ID = ID,
            };
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
        // 获取选中行的数据
        private void GetData()
        {
            // 获得选中行索引
            int optColumn = dgvReader.CurrentRow.Index;
            readerInfoMod = new ReaderInfoMod();
            // 为mod赋值
            readerInfoMod.ReaderID = dgvReader.Rows[optColumn].Cells["读者编号"].Value.ToString();
            readerInfoMod.ReadName = dgvReader.Rows[optColumn].Cells["读者姓名"].Value.ToString();
            readerInfoMod.EMail = dgvReader.Rows[optColumn].Cells["读者邮箱"].Value.ToString();
            readerInfoMod.Address = dgvReader.Rows[optColumn].Cells["读者地址"].Value.ToString();
            readerInfoMod.Mobile = dgvReader.Rows[optColumn].Cells["读者手机号码"].Value.ToString();
        }
        /// <summary>
        /// 右键菜单点击修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetData(); // 获取数据
            // 显示修改页面
            new UpdateReadeInfoForm(readerInfoMod).ShowDialog();
            // 加载读者数据，为dgv控件赋值
            dgvReader.DataSource = readerMangeBll.GetReaderInfo();
        }
    }
}
