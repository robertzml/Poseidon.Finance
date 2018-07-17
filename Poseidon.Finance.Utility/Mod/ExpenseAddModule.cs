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
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 增加用款记录模块
    /// </summary>
    public partial class ExpenseAddModule : DevExpress.XtraEditors.XtraUserControl
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
        /// 用款信息
        /// </summary>
        private Expense expense;

        /// <summary>
        /// 当前关联用户
        /// </summary>
        private LoginUser currentUser;
        #endregion //Field

        #region Constructor
        public ExpenseAddModule()
        {
            InitializeComponent();

            this.expense = new Expense();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        private void SetEntity(Expense entity)
        {
            entity.Summary = this.txtSummary.Text;
            entity.Amount = this.spAmount.Value;

            var category = this.tluCategory.GetSelectedDataRow() as Category;
            entity.CategoryNumber = category.Number;
            entity.CategoryName = category.Name;
            entity.Operator = this.txtOperator.Text;
            entity.ExpenseDate = this.dpExpenseDate.DateTime;
            entity.Remark = this.txtRemark.Text;

            entity.ModuleName = this.moduleName;
            entity.AssemblyName = this.assemblyName;
            entity.CollectionName = this.collectionName;
            entity.DocumentId = this.documentId;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init(string moduleName, string assemblyName, string collectionName, string documentId, LoginUser currentUser)
        {
            this.moduleName = moduleName;
            this.assemblyName = assemblyName;
            this.collectionName = collectionName;
            this.documentId = documentId;
            this.currentUser = currentUser;
         
            this.bsCategory.DataSource = BusinessFactory<CategoryBusiness>.Instance.FindAll();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        //public void UpdateData()
        //{
        //    this.expense.Summary = this.txtSummary.Text;
        //    this.expense.Amount = this.spAmount.Value;
        //    this.expense.Operator = this.txtOperator.Text;
        //    this.expense.ExpenseDate = this.dpExpenseDate.DateTime;
        //    this.expense.Remark = this.txtRemark.Text;
        //}

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        public Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";
         
            if (string.IsNullOrEmpty(this.txtSummary.Text.Trim()))
            {
                errorMessage = "摘要不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.tluCategory.EditValue == null)
            {
                errorMessage = "请选择费用分类";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpExpenseDate.EditValue == null)
            {
                errorMessage = "请选择用款日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return false;
            }

            try
            {
                Expense entity = new Expense();
                SetEntity(entity);

                BusinessFactory<ExpenseBusiness>.Instance.Create(entity, this.currentUser);

                this.expense = entity;
                return true;
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增付款记录失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                return false;
            }
        }
        #endregion //Method

        #region Property
        /// <summary>
        /// 用款信息
        /// </summary>
        public Expense Expense
        {
            get
            {
                return expense;
            }
        }
        #endregion //Propery
    }
}
