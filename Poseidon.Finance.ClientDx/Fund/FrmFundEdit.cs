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

    /// <summary>
    /// 编辑经费本窗体
    /// </summary>
    public partial class FrmFundEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联经费本
        /// </summary>
        private Fund currentFund;
        #endregion //Field

        #region Constructor
        public FrmFundEdit()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id"></param>
        private void InitData(string id)
        {
            this.currentFund = BusinessFactory<FundBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentFund.Name;
            this.txtNumber.Text = this.currentFund.Number;
            this.txtPrincipal.Text = this.currentFund.Principal;
            this.txtDatasetCode.Text = this.currentFund.DatasetCode;
            this.txtRemark.Text = this.currentFund.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "项目名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtNumber.Text.Trim()))
            {
                errorMessage = "项目号不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Fund entity)
        {
            entity.Name = this.txtName.Text;
            entity.Number = this.txtNumber.Text;
            entity.Principal = this.txtPrincipal.Text;
            entity.DatasetCode = this.txtDatasetCode.Text;
            entity.Remark = this.txtRemark.Text;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Fund entity = BusinessFactory<FundBusiness>.Instance.FindById(this.currentFund.Id);
                SetEntity(entity);

                BusinessFactory<FundBusiness>.Instance.Update(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("更新经费本失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
