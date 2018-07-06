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
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 增加用款记录模块
    /// </summary>
    public partial class ExpenseAddModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 用款信息
        /// </summary>
        private Expense expense;
        #endregion //Field

        #region Constructor
        public ExpenseAddModule()
        {
            InitializeComponent();

            this.expense = new Expense();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.luFund.EditValue == null)
            {
                errorMessage = "请选择经费本";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtSummary.Text.Trim()))
            {
                errorMessage = "摘要不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpExpenseDate.EditValue == null)
            {
                errorMessage = "请选择用款日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {

        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData()
        {
            this.expense.Summary = this.txtSummary.Text;
            this.expense.Amount = this.spAmount.Value;
            this.expense.Operator = this.txtOperator.Text;
            this.expense.ExpenseDate = this.dpExpenseDate.DateTime;
            this.expense.Remark = this.txtRemark.Text;
        }
        #endregion //Method

        #region Property
        /// <summary>
        /// 用款信息
        /// </summary>
        public Expense Expense
        {
            get
            {
                return expense;
            }
        }
        #endregion //Propery
    }
}
