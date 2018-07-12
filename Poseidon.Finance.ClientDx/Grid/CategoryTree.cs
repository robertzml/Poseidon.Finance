using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 费用分类树形控件
    /// </summary>
    public partial class CategoryTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public CategoryTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入数据
        /// </summary>
        private void LoadData()
        {
            this.bsCategory.DataSource = BusinessFactory<CategoryBusiness>.Instance.FindAll();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            LoadData();
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        public void RefreshData()
        {
            LoadData();
        }


        /// <summary>
        /// 获取当前选中权限ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectedId()
        {
            var node = this.tlCategory.Selection[0];
            if (node == null)
                return null;

            var id = node["Id"].ToString();
            return id;
        }

        /// <summary>
        /// 展开节点
        /// </summary>
        public void Expand()
        {
            this.tlCategory.ExpandAll();
        }
        #endregion //Method
    }
}
