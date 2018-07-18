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
    }
}
