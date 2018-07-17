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

    /// <summary>
    /// 付款管理窗体
    /// </summary>
    public partial class FrmPaymentManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 付款数据
        /// </summary>
        private List<Payment> paymentList;
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
            this.LoadPayment();

            base.InitForm();
        }

        /// <summary>
        /// 载入付款记录
        /// </summary>
        private void LoadPayment()
        {
            this.paymentList = BusinessFactory<PaymentBusiness>.Instance.FindAll().ToList();
            this.paymentGrid.DataSource = this.paymentList;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void SearchData()
        {
            var temp = this.paymentList;

            if (this.dpStart.EditValue != null)
                temp = temp.Where(r => r.PaidDate >= this.dpStart.DateTime).ToList();

            if (this.dpEnd.EditValue != null)
                temp = temp.Where(r => r.PaidDate <= this.dpEnd.DateTime).ToList();

            this.paymentGrid.DataSource = temp;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// 新增付款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmPaymentAdd));
            this.LoadPayment();
        }
        #endregion //Event
    }
}
