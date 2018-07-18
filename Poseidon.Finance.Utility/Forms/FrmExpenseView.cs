﻿using System;
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
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.DL;
    using Poseidon.Common;

    /// <summary>
    /// 费用查看窗体
    /// </summary>
    public partial class FrmExpenseView : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联费用对象
        /// </summary>
        private Expense currentExpense;
        #endregion //Field

        #region Constructor
        public FrmExpenseView(Expense expense)
        {
            InitializeComponent();

            InitData(expense);
        }
        #endregion //Constructor

        #region Function
        private void InitData(Expense expense)
        {
            this.currentExpense = expense;
        }

        protected override void InitForm()
        {
            //if (!string.IsNullOrEmpty(this.currentExpense.DocumentId))
            //{
            //    var navItem = new DevExpress.XtraNavBar.NavBarItem
            //    {
            //        Name = "",
            //        Caption = "业务信息",
            //    };
            //    navItem.LinkClicked += NavBizItem_LinkClicked;

            //    this.nbgExpense.ItemLinks.Add(new DevExpress.XtraNavBar.NavBarItemLink(navItem));
            //}

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择费用界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navExpenseItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExpenseAddModule mod = new ExpenseAddModule();

            this.gcContext.Text = "费用信息";
            this.gcContext.Controls.Clear();
            this.gcContext.Controls.Add(mod);
            mod.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 选择业务界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBizItem_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var control = Reflect<BaseExpenseControl>.Create(this.currentExpense.ModuleName, this.currentExpense.AssemblyName, false);
            control.Init(this.currentExpense.DocumentId);

            this.gcContext.Text = "业务信息";
            this.gcContext.Controls.Clear();
            this.gcContext.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        #endregion //Event
    }
}
