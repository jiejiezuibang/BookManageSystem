using BLL;
using BLL.BookInfoBLL;
using MOD;
using MOD.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace BookSystem
{
    public partial class BookManageForm : Form
    {
        // 构造图书信息业务对象
        BookInfoBll bookInfoBll = BLLFactory.GetBookInfoBll;
        // 声明图书类别对象字段
        private BookCategoryMod bookCategoryMod = null;
        public BookManageForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击搜索图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindBook_Click(object sender, EventArgs e)
        {
            BookInfoMod bookInfoMod = new BookInfoMod()
            {
                BookID = tbBookID.Text.Trim(),
            };
            // 获取搜索到图书信息并赋值给dgv
            dgvBookInfo.DataSource = bookInfoBll.FindBookInfo(bookInfoMod);
        }
        /// <summary>
        /// 递归生成目录树
        /// </summary>
        /// <param name="parentNode">父节点对象，需要在该节点下添加子节点</param>
        /// <param name="categoryID"></param>
        private void CreateChildNode(TreeNode parentNode,int categoryID)
        {
            // 获得图书类别对象列表
            List<BookCategoryMod> bookTypeList = bookInfoBll.GetAllBookType();
            // 找到该节点下的子类
            var nods = bookTypeList.Where(a => a.ParentID == categoryID);
            foreach(var item in nods)
            {
                TreeNode sonNode = new TreeNode(); // 创建子节点
                sonNode.Text = item.CategoryName;   //子节点的名称
                sonNode.Tag = item.ParentID;      //子节点的CategoryID   
                if(item.CategoryID == 0)
                {
                    //图书信息管理目录的树节点 才会走这里
                    sonNode.ImageIndex = 0;         //节点的图标
                }
                else
                {
                    sonNode.ImageIndex = 1;         //节点的图标
                }
                //父节点添加子节点
                parentNode.Nodes.Add(sonNode);
                //递归
                CreateChildNode(sonNode, item.CategoryID);
            }
        }
        /// <summary>
        /// 生成目录
        /// </summary>
        private void CreateTreeDirc()
        {
            this.tvBookList.Nodes.Clear();          // 清空所有节点
            TreeNode treeNode = new TreeNode();     // 创建根节点
            treeNode.Text = "图书信息目录";         // 添加根节点显示文本
            treeNode.Tag = 0;                       // 绑定根节点数据
            this.tvBookList.Nodes.Add(treeNode);    // 添加根节点
            CreateChildNode(treeNode, 0);           // 渲染目录树
            this.tvBookList.ExpandAll();            // 展开目录树
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookManageForm_Load(object sender, EventArgs e)
        {
            // 给dgv控件赋值
            dgvBookInfo.DataSource = bookInfoBll.GetBookInfo();
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            // 给控件命名
            btnUpdate.Name = "btnUpdateBook";
            // 设置单元格标题文本
            btnUpdate.HeaderText = "修改图书";
            // 设置按钮显示文本
            btnUpdate.DefaultCellStyle.NullValue = "修改";
            dgvBookInfo.Columns.Add(btnUpdate); // 添加修改按钮
            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            btnDel.Name = "btnDelBook";
            btnDel.HeaderText = "删除图书";
            btnDel.DefaultCellStyle.NullValue = "删除";
            dgvBookInfo.Columns.Add(btnDel); // 添加删除按钮

            // 生成目录树
            CreateTreeDirc();
            // 加载目录树
            //// 获取图书类别信息
            //DataTable dtBookType = bookInfoBll.GetAllBookType();
            //// 渲染根目录节点
            //for (int i = 0; i < dtBookType.Rows.Count; i++)
            //{
            //    // 判断是否为父类
            //    if (dtBookType.Rows[i]["ParentID"].ToString() == "0")
            //    {
            //        // 渲染父类作为根节点
            //        tvBookList.Nodes.Add(new TreeNode(dtBookType.Rows[i]["CategoryName"].ToString()));
            //        for (int j = 0; j < dtBookType.Rows.Count; j++)
            //        {
            //            // 判断该子类属于哪一个父类
            //            if (dtBookType.Rows[i]["CategoryID"].ToString() == dtBookType.Rows[j]["ParentID"].ToString())
            //            {
            //                // 渲染父类下的子类
            //                tvBookList.Nodes[i].Nodes.Add(new TreeNode(dtBookType.Rows[j]["CategoryName"].ToString()));
            //            }
            //        }
            //    }
            //}
        }
        /// <summary>
        /// 点击添加图书按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // 显示添加图书页面
            new AddBookInfoForm().ShowDialog();
            // 重新给dgv控件赋值
            dgvBookInfo.DataSource = bookInfoBll.GetBookInfo();
        }
        // 获取图书编号
        public string GetBookID()
        {
            // 获得选中行的图书编号
            string BookID = dgvBookInfo.Rows[dgvBookInfo.CurrentRow.Index].Cells["图书编号"].Value.ToString();
            return BookID;
        }
        /// <summary>
        /// 单击单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBookInfo.Columns[e.ColumnIndex].Name == "btnDelBook" && e.RowIndex >= 0)
            {
                if(MessageBox.Show("确定删除吗？","提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 获得选中行的图书编号
                    string BookID = dgvBookInfo.Rows[dgvBookInfo.CurrentRow.Index].Cells["图书编号"].Value.ToString();
                    BookInfoMod bookInfoMod = new BookInfoMod()
                    {
                        BookID = BookID,
                    };
                    // 执行删除操作
                    BookInfoEnums bookInfoEnums = bookInfoBll.DelBookInfo(bookInfoMod);
                    // 判断是否删除成功
                    switch (bookInfoEnums)
                    {
                        case BookInfoEnums.DelBookInfoSuccess:
                            MessageBox.Show("删除成功");
                            // 给dgv控件赋值
                            dgvBookInfo.DataSource = bookInfoBll.GetBookInfo();
                            break;
                        case BookInfoEnums.DelBookInfoError:
                            MessageBox.Show("删除失败");
                            break;
                    }
                }
            }
            else if (dgvBookInfo.Columns[e.ColumnIndex].Name == "btnUpdateBook" && e.RowIndex >= 0)
            {
                new UpdateBookInfoForm(GetBookID).ShowDialog();
                // 给dgv控件赋值
                dgvBookInfo.DataSource = bookInfoBll.GetBookInfo();
            }
        }
        /// <summary>
        /// 点击树节点触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvBookList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 获取点击的节点文本
            string FindBookType = tvBookList.SelectedNode.Text;
            bookCategoryMod = new BookCategoryMod()
            {
                CategoryName = FindBookType
            };
            // 获取数据渲染dgv
            dgvBookInfo.DataSource = bookInfoBll.BookShow(bookCategoryMod);

            //BookInfoBll bookInfoBll = new BookInfoBll();
            //BookCategoryMod bookCategoryMod = new BookCategoryMod()
            //{
            //    CategoryName = FindBookType,
            //};
            //// 获取图书数据
            //DataTable dt = bookInfoBll.FindBookInfo_Son(bookCategoryMod);
            //// 给dgv赋值
            //dgvBookInfo.DataSource = dt;
        }
    }
}
