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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystem
{
    public partial class UpdateReadeInfoForm : Form
    {
        // 获取读者信息业务对象
        ReaderMangeBll readerMangeBll = BLLFactory.GetReaderMangeB;
        // 读者信息数据
        private ReaderInfoMod readerInfoMod = null;
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
        private bool CheckData()
        {
            // 判断读者姓名不能为空
            if (string.IsNullOrWhiteSpace(tbReaderName.Text.Trim()))
            {
                MessageBox.Show("读者姓名不能为空");
                tbReaderName.Focus(); // 获得焦点
                tbReaderName.Text = null;  // 清空输入框
                return false;
            }
            // 判断读者邮箱格式是否正确
            if (!Regex.IsMatch(tbEmail.Text.Trim(), @"^\w+@\w+.[a-z]{3-6}$"))
            {
                MessageBox.Show("读者邮箱格式错误");
                tbEmail.Focus(); // 获得焦点
                tbEmail.Text = null; // 清空输入框
                return false;
            }
            if (!Regex.IsMatch(tbMobil.Text.Trim(), @"^[1]+[3,5]+\d{9}"))
            {
                MessageBox.Show("读者手机号码格式错误");
                tbMobil.Focus(); // 获得焦点
                tbMobil.Text = null; // 清空输入框
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获得输入的读者信息
        /// </summary>
        private void GetData()
        {
            // 为mod赋值
            readerInfoMod = new ReaderInfoMod
            {
                ReaderID = tbReaderID.Text,
                ReadName = tbReaderName.Text,
                Address = tbAddress.Text,
                EMail = tbEmail.Text,
                Mobile = tbMobil.Text
            };
        }
        /// <summary>
        /// 点击修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            // 校验读者数据的数据
            if (CheckData())
            {
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
}
