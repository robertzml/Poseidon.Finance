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
    using Poseidon.Finance.Core.Utility;

    /// <summary>
    /// 付款管理窗体
    /// </summary>
    public partial class FrmPaymentManage : BaseMdiForm
    {
        #region Field
        #endregion //Field

        #region Constructor
        public FrmPaymentManage()
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
            for(int i = nowYear; i >= FinanceConstant.StartYear; i--)
            {
                this.trYear.AppendNode(new object[] { i.ToString() + "年" }, top, i);
            }
        }

        /// <summary>
        /// 载入付款记录
        /// </summary>
        /// <param name="year">年度</param>
        private void LoadPayment(int year)
        {
            if (year == 0)
            {
                var paymentList = BusinessFactory<PaymentBusiness>.Instance.FindAll().ToList();
                this.paymentGrid.DataSource = paymentList;
            }
            else
            {
                var paymentList = BusinessFactory<PaymentBusiness>.Instance.FindByYear(year).ToList();
                this.paymentGrid.DataSource = paymentList;
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trYear_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var year = Convert.ToInt32(e.Node.Tag);
            LoadPayment(year);            
        }

        /// <summary>
        /// 新增付款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPaymentAdd));

            var node = this.trYear.FocusedNode;
            if (node != null)
                this.LoadPayment(Convert.ToInt32(node.Tag));
            else
                this.LoadPayment(0);
        }
       
        /// <summary>
        /// 付款记录选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void paymentGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var payment = this.paymentGrid.GetCurrentSelect();
            if (payment == null)
                this.paymentRecordGrid.Clear();
            else
                this.paymentRecordGrid.DataSource = payment.Records;
        }
        #endregion //Event
    }
}
