using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.Utility
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Finance.Core.Utility;
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 费用绑定窗体
    /// </summary>
    public partial class FrmExpenseBind : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 模块名称
        /// </summary>
        private string moduleName;

        /// <summary>
        /// 程序集名称
        /// </summary>
        private string assemblyName;

        /// <summary>
        /// 集合名称
        /// </summary>
        private string collectionName;

        /// <summary>
        /// 文档ID
        /// </summary>
        private string documentId;

        /// <summary>
        /// 相关费用业务实例
        /// </summary>
        private IExpenseBusiness expenseBusiness;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 费用绑定
        /// </summary>
        /// <param name="moduleName">模块名称</param>
        /// <param name="assemblyName">程序集名称</param>
        /// <param name="collectionName">集合名称</param>
        /// <param name="documentId">文档ID</param>
        /// <param name="expenseBusiness">相关费用业务实例</param>
        public FrmExpenseBind(string moduleName, string assemblyName, string collectionName, string documentId, IExpenseBusiness expenseBusiness)
        {
            InitializeComponent();

            InitData(moduleName, assemblyName, collectionName, documentId, expenseBusiness);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string moduleName, string assemblyName, string collectionName, string documentId, IExpenseBusiness expenseBusiness)
        {
            this.moduleName = moduleName;
            this.assemblyName = assemblyName;
            this.collectionName = collectionName;
            this.documentId = documentId;

            this.expenseBusiness = expenseBusiness;
        }

        protected override void InitForm()
        {
            var exp = BusinessFactory<ExpenseBusiness>.Instance.FindUnBind();
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
            if (MessageUtil.ConfirmYesNo("是否绑定选中费用记录到业务?") == DialogResult.Yes)
            {
                var selectExpenses = this.expenseGrid.GetSelectedRows();

                foreach (var item in selectExpenses)
                {
                    var result = BusinessFactory<ExpenseBusiness>.Instance.BindExpense(item.Id, moduleName, assemblyName, collectionName, documentId);
                    if (result.success)
                    {
                        if (expenseBusiness != null)
                            expenseBusiness.AfterCreate(item.Id, this.documentId);
                    }
                    else
                    {
                        MessageUtil.ShowWarning($"'{item.Summary}' 此条费用已绑定");
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion //Event
    }
}
