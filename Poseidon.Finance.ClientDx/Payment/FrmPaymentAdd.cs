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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 新增付款窗体
    /// </summary>
    public partial class FrmPaymentAdd : BaseSingleForm
    {
        #region Constructor
        public FrmPaymentAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
