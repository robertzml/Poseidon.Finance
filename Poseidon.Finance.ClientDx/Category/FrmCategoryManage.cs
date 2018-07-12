using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.ClientDx
{
    using Poseidon.Winform.Base;

    /// <summary>
    /// 费用分类管理
    /// </summary>
    public partial class FrmCategoryManage : BaseMdiForm
    {
        #region Constructor
        public FrmCategoryManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor
        
        #region Event
        /// <summary>
        /// 新增费用分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmCategoryAdd));
        }
        #endregion //Event
    }
}
