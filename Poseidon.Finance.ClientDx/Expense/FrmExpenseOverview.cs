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
    /// 费用总览窗体
    /// </summary>
    public partial class FrmExpenseOverview : BaseMdiForm
    {
        #region Constructor
        public FrmExpenseOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadExpense();

            base.InitForm();
        }

        /// <summary>
        /// 载入费用
        /// </summary>
        private void LoadExpense()
        {
            var data = BusinessFactory<ExpenseBusiness>.Instance.FindAll();

            if (dpStart.EditValue != null)
            {
                data = data.Where(r => r.ExpenseDate >= dpStart.DateTime);
            }
            if (dpEnd.EditValue != null)
            {
                data = data.Where(r => r.ExpenseDate <= dpEnd.DateTime);
            }

            this.expenseGrid.DataSource = data.ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dpStart.EditValue != null && dpEnd.EditValue != null)
            {
                if (dpStart.DateTime > dpEnd.DateTime)
                {
                    MessageUtil.ShowWarning("开始日期不能晚于结束日期");
                    return;
                }
            }

            LoadExpense();
        }
        #endregion //Event
    }
}
