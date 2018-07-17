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
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 付款管理窗体
    /// </summary>
    public partial class FrmPaymentManage : BaseMdiForm
    {
        #region Constructor
        public FrmPaymentManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 新增付款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
