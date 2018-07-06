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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 经费本表格控件
    /// </summary>
    public partial class FundGrid : WinEntityGrid<Fund>
    {
        #region Constructor
        public FundGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
