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
    /// 费用管理窗体
    /// </summary>
    public partial class FrmExpenseManage : BaseMdiForm
    {
        #region Constructor
        public FrmExpenseManage()
        {
            InitializeComponent();
        }

        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadData();

            base.InitForm();
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        private void LoadData()
        {
            var data = BusinessFactory<ExpenseBusiness>.Instance.FindAll();
            this.expenseGrid.DataSource = data.ToList();
        }
        #endregion //Functio

        #region Event
        /// <summary>
        /// 添加费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmExpenseAdd));
            LoadData();
        }

        /// <summary>
        /// 编辑费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var expense = this.expenseGrid.GetCurrentSelect();
            if (expense == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmExpenseEdit), new object[] { expense.Id });
            LoadData();
        }
        #endregion //Event
    }
}
