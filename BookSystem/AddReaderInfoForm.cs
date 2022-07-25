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
    public partial class AddReaderInfoForm : Form
    {
        // 单例
        public static AddReaderInfoForm addReaderInfoForm;
        public AddReaderInfoForm()
        {
            InitializeComponent();
        }
        private ReaderInfoMod readerInfoMod = null;
        ReaderMangeBll readerMangeBll = BLLFactory.GetReaderMangeB;
        /// <summary>
        /// 获取输入的值给对象
        /// </summary>
        private void GetReaderInfo()
        {
            readerInfoMod = new ReaderInfoMod()
            {
                // 获取控件里的值
                ReaderID = tbReaderID.Text,
                ReadName = tbReaderName.Text,
                Address = tbAddress.Text,
                EMail = tbEmail.Text,
                Mobile = tbMobil.Text
            };
        }
        /// <summary>
        /// 获取AddReaderInfoForm页面
        /// </summary>
        /// <returns></returns>
        public static AddReaderInfoForm GetAddReaderInfoForm()
        {
            if(addReaderInfoForm == null)
            {
                addReaderInfoForm = new AddReaderInfoForm();
            }
            return addReaderInfoForm;
        }
        /// <summary>
        /// 对用户输入的数据进行校验
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(tbReaderName.Text.Trim()))
            {
                MessageBox.Show("图书名称不能为空");
                tbReaderName.Text = null;
                tbReaderName.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 点击添加读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            // 校验数据
            if (CheckData())
            {
                GetReaderInfo(); // 获取到用户输入的信息
                // 获取添加读者信息状态
                ReaderInfoEnums readerInfoEnums = readerMangeBll.AddReaderInfo(readerInfoMod);
                switch (readerInfoEnums)
                {
                    case ReaderInfoEnums.AddSuccess:
                        MessageBox.Show("添加成功");
                        this.Close();
                        break;
                    case ReaderInfoEnums.AddError:
                        MessageBox.Show("添加失败");
                        break;
                }
            }
        }
    }
}
