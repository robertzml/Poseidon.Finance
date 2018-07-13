﻿using System;
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
    /// 用款总览窗体
    /// </summary>
    public partial class FrmExpenseOverview : BaseMdiForm
    {
        #region Constructor
        public FrmExpenseOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadExpense();

            base.InitForm();
        }

        private void LoadExpense()
        {
            var data = BusinessFactory<ExpenseBusiness>.Instance.FindAll();
            this.expenseGrid.DataSource = data.ToList();
        }
        #endregion //Function
    }
}
