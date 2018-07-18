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
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 费用信息模块
    /// </summary>
    public partial class ExpenseInfoModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联费用
        /// </summary>
        private Expense currentExpense;
        #endregion //Field

        #region Constructor
        public ExpenseInfoModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示信息
        /// </summary>
        private void Display()
        {
            this.txtSerialNumber.Text = this.currentExpense.SerialNumber;
            this.txtSummary.Text = this.currentExpense.Summary;
            this.txtAmount.Text = this.currentExpense.Amount.ToString();
            this.txtPaidFee.Text = this.currentExpense.PaidFee.ToString();
            this.txtUnpaidFee.Text = (this.currentExpense.Amount - this.currentExpense.PaidFee).ToString();
            this.chkIsPaid.Checked = this.currentExpense.IsPaid;
            this.txtCategoryNumber.Text = this.currentExpense.CategoryNumber;
            this.txtCategoryName.Text = this.currentExpense.CategoryName;
            this.txtExpenseDate.Text = this.currentExpense.ExpenseDate.ToDateString();
            this.txtOperator.Text = this.currentExpense.Operator;
            this.txtCreator.Text = this.currentExpense.CreateBy.Name;
            this.txtCreateTime.Text = this.currentExpense.CreateBy.Time.ToDateTimeString();
            this.txtEditor.Text = this.currentExpense.UpdateBy.Name;
            this.txtEditTime.Text = this.currentExpense.UpdateBy.Time.ToDateTimeString();
            this.txtRemark.Text = this.currentExpense.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="expense">费用记录</param>
        public void Init(Expense expense)
        {
            this.currentExpense = expense;
            this.Display();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtSerialNumber.Text = "";
            this.txtSummary.Text = "";
            this.txtAmount.Text = "";
            this.txtPaidFee.Text = "";
            this.txtUnpaidFee.Text = "";
            this.chkIsPaid.Checked = false;
            this.txtCategoryNumber.Text = "";
            this.txtCategoryName.Text = "";
            this.txtExpenseDate.Text = "";
            this.txtOperator.Text = "";
            this.txtCreator.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditor.Text = "";
            this.txtEditTime.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
