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
    /// <summary>
    /// 用款基类控件
    /// </summary>
    public partial class BaseExpenseControl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public BaseExpenseControl()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="documentId">文档ID</param>
        public virtual void Init(string documentId)
        {
        }
        #endregion //Method
    }
}
