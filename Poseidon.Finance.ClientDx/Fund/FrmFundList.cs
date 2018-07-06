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
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;

    /// <summary>
    /// 经费本列表窗体
    /// </summary>
    public partial class FrmFundList : BaseMdiForm
    {
        #region Constructor
        public FrmFundList()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 添加经费本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmFundAdd));
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
