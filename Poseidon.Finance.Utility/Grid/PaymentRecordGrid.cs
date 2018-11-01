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
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;

    /// <summary>
    /// 付款记录表格控件
    /// </summary>
    public partial class PaymentRecordGrid : WinEntityGrid<PaymentRecord>
    {
        #region Field
        /// <summary>
        /// 是否显示付款信息列
        /// </summary>
        private bool showPaymentColumn = false;
        #endregion //Field

        #region Constructor
        public PaymentRecordGrid()
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
        private void PaymentRecordGrid_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[rowIndex] as PaymentRecord;
            if (e.Column.FieldName == "ExpenseId")
            {
                var exp = BusinessFactory<ExpenseBusiness>.Instance.FindById(record.ExpenseId);
                if (exp != null)
                    e.DisplayText = exp.Summary;
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示付款信息列
        /// </summary>
        [Description("是否显示付款信息列"), Category("界面")]
        public bool ShowPaymentColumn { get => showPaymentColumn; set => showPaymentColumn = value; }
        #endregion //Property

    }
}
