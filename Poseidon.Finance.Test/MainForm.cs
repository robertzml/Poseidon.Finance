﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Finance.Test
{
    using Poseidon.Winform.Base;
    using Poseidon.Finance.ClientDx;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuFundList_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmFundList));
        }

        private void menuExpenseOv_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmExpenseOverview));
        }

        private void menuCategoryMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmCategoryManage));
        }

        private void menuExpenseMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmExpenseManage));
        }

        private void menuPaymentMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmPaymentManage));
        }
    }
}
