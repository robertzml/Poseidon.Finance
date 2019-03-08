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
    using Poseidon.Finance.Core.Utility;
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
            this.InitYearTree();

            base.InitForm();
        }

        /// <summary>
        /// 初始化年度树形控件
        /// </summary>
        private void InitYearTree()
        {
            var top = this.trYear.AppendNode(new object[] { "全部" }, -1, 0);

            int nowYear = DateTime.Now.Year;
            for (int i = nowYear; i >= FinanceConstant.StartYear; i--)
            {
                this.trYear.AppendNode(new object[] { i.ToString() + "年" }, top, i);
            }
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="year">年度</param>
        private void LoadExpense(int year)
        {
            if (year == 0)
            {
                var data = BusinessFactory<ExpenseBusiness>.Instance.FindAll();
                this.expenseGrid.DataSource = data.ToList();
            }
            else
            {
                var data = BusinessFactory<ExpenseBusiness>.Instance.FindByYear(year);
                this.expenseGrid.DataSource = data.ToList();
            }
        }
        #endregion //Functio

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trYear_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var year = Convert.ToInt32(e.Node.Tag);
            LoadExpense(year);
        }

        /// <summary>
        /// 添加费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmExpenseAdd));
            var node = this.trYear.FocusedNode;
            if (node != null)
                this.LoadExpense(Convert.ToInt32(node.Tag));
            else
                this.LoadExpense(0);
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
            var node = this.trYear.FocusedNode;
            if (node != null)
                this.LoadExpense(Convert.ToInt32(node.Tag));
            else
                this.LoadExpense(0);
        }

        /// <summary>
        /// 删除费用记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var expense = this.expenseGrid.GetCurrentSelect();
            if (expense == null)
                return;

            try
            {
                if (MessageUtil.ConfirmYesNo($"是否删除'{expense.SerialNumber}'费用记录") == DialogResult.Yes)
                {
                    var result = BusinessFactory<ExpenseBusiness>.Instance.Delete(expense);
                    if (result.success)
                    {
                        MessageUtil.ShowInfo("删除成功");
                        var node = this.trYear.FocusedNode;
                        if (node != null)
                            this.LoadExpense(Convert.ToInt32(node.Tag));
                        else
                            this.LoadExpense(0);
                    }
                    else
                    {
                        MessageUtil.ShowClaim("删除失败: " + result.errorMessage);
                    }
                }
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("删除费用记录失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
