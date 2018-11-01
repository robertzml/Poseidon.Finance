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
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 费用搜索窗体
    /// </summary>
    public partial class FrmExpenseSearch : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 选中支出记录
        /// </summary>
        private List<Expense> selectExpenses = new List<Expense>();
        #endregion //Field

        #region Constructor
        public FrmExpenseSearch()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var exp = BusinessFactory<ExpenseBusiness>.Instance.FindUnPaid();
            this.expenseGrid.DataSource = exp.ToList();

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.selectExpenses = this.expenseGrid.GetSelectedRows();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 选中支出记录
        /// </summary>
        public List<Expense> SelectExpenses { get => selectExpenses; }
        #endregion //Property
    }
}
