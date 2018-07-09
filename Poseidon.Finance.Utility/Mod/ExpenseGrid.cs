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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 用款表格控件
    /// </summary>
    public partial class ExpenseGrid : WinEntityGrid<Expense>
    {
        #region Constructor
        public ExpenseGrid()
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
        private void ExpenseGrid_Load(object sender, EventArgs e)
        {
            this.AppendMenu(this.contextMenuStrip1);
        }

        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuView_Click(object sender, EventArgs e)
        {
            var expense = this.GetCurrentSelect();

            ChildFormManage.ShowDialogForm(typeof(FrmExpenseView), new object[] { expense });
        }
        #endregion //Event

    }
}
