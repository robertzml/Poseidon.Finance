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
    /// 编辑费用分类
    /// </summary>
    public partial class FrmCategoryEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联费用分类
        /// </summary>
        private Category currentCategory;
        #endregion //Field

        #region Constructor
        public FrmCategoryEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentCategory = BusinessFactory<CategoryBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.bsCategory.DataSource = BusinessFactory<CategoryBusiness>.Instance.FindAll();

            this.txtName.Text = this.currentCategory.Name;
            this.txtNumber.Text = this.currentCategory.Number;
            this.tluParent.EditValue = this.currentCategory.ParentId;
            this.spSort.Value = this.currentCategory.Sort;
            this.txtRemark.Text = this.currentCategory.Remark;

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
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtNumber.Text.Trim()))
            {
                errorMessage = "分类号不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Category entity)
        {
            entity.Name = this.txtName.Text;
            entity.Number = this.txtNumber.Text;
            entity.Sort = Convert.ToInt32(this.spSort.Value);
            entity.Remark = this.txtRemark.Text;

            if (this.tluParent.EditValue == null)
                entity.ParentId = "";
            else
                entity.ParentId = this.tluParent.EditValue.ToString();
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
                Category entity = BusinessFactory<CategoryBusiness>.Instance.FindById(this.currentCategory.Id);
                SetEntity(entity);

                BusinessFactory<CategoryBusiness>.Instance.Update(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("编辑费用分类失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
