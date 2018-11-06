using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.Utility
{
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 付款表格控件
    /// </summary>
    public partial class PaymentGrid : WinEntityGrid<Payment>
    {
        #region Constructor
        public PaymentGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentGrid_Load(object sender, EventArgs e)
        {
            this.AppendMenu(this.contextMenuStrip1);
        }
        
        /// <summary>
        /// 查看明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuViewDetails_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
