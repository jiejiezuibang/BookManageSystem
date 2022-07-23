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
    public partial class UpdateReadeInfoForm : Form
    {
        public UpdateReadeInfoForm(ReaderInfoMod readerInfoMod)
        {
            InitializeComponent();
            // 初始化输入框数据
            tbReaderID.Text = readerInfoMod.ReaderID;
            tbReaderName.Text = readerInfoMod.ReadName;
            tbEmail.Text = readerInfoMod.EMail;
            tbAddress.Text = readerInfoMod.Address;
            tbMobil.Text = readerInfoMod.Mobile;
        }
        /// <summary>
        /// 点击修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            // 为mod赋值
            ReaderInfoMod readerInfoMod = new ReaderInfoMod
            {
                ReaderID = tbReaderID.Text,
                ReadName = tbReaderName.Text,
                Address = tbAddress.Text,
                EMail = tbEmail.Text,
                Mobile = tbMobil.Text
            };
            ReaderMangeBll readerMangeBll = new ReaderMangeBll();
            ReaderInfoEnums readerInfoEnums = readerMangeBll.UpdateReaderInfo(readerInfoMod);
            switch (readerInfoEnums)
            {
                case ReaderInfoEnums.UpdateSuccess:
                    MessageBox.Show("修改成功");
                    this.Close();
                    break;
                case ReaderInfoEnums.UpdateError:
                    MessageBox.Show("修改失败");
                    break;
            }
        }
    }
}
