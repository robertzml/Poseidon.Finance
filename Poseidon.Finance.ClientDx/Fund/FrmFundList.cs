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
    /// 经费本列表窗体
    /// </summary>
    public partial class FrmFundList : BaseMdiForm
    {
        #region Constructor
        public FrmFundList()
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
        /// 载入经费本数据
        /// </summary>
        private void LoadData()
        {
            this.fundGrid.DataSource = BusinessFactory<FundBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加经费本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmFundAdd));
        }
        
        /// <summary>
        /// 编辑经费本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var fund = this.fundGrid.GetCurrentSelect();
            if (fund == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmFundEdit), new object[] { fund.Id });
            LoadData();
        }
        #endregion //Event
    }
}
