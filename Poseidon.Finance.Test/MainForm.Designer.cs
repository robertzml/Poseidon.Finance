namespace Poseidon.Finance.Test
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.经费本管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFundList = new System.Windows.Forms.ToolStripMenuItem();
            this.用款管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpenseOv = new System.Windows.Forms.ToolStripMenuItem();
            this.费用分类管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.经费本管理ToolStripMenuItem,
            this.用款管理ToolStripMenuItem,
            this.费用分类管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 经费本管理ToolStripMenuItem
            // 
            this.经费本管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFundList});
            this.经费本管理ToolStripMenuItem.Name = "经费本管理ToolStripMenuItem";
            this.经费本管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.经费本管理ToolStripMenuItem.Text = "经费本管理";
            // 
            // menuFundList
            // 
            this.menuFundList.Name = "menuFundList";
            this.menuFundList.Size = new System.Drawing.Size(136, 22);
            this.menuFundList.Text = "经费本列表";
            this.menuFundList.Click += new System.EventHandler(this.menuFundList_Click);
            // 
            // 用款管理ToolStripMenuItem
            // 
            this.用款管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExpenseOv});
            this.用款管理ToolStripMenuItem.Name = "用款管理ToolStripMenuItem";
            this.用款管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用款管理ToolStripMenuItem.Text = "用款管理";
            // 
            // menuExpenseOv
            // 
            this.menuExpenseOv.Name = "menuExpenseOv";
            this.menuExpenseOv.Size = new System.Drawing.Size(124, 22);
            this.menuExpenseOv.Text = "用款总览";
            this.menuExpenseOv.Click += new System.EventHandler(this.menuExpenseOv_Click);
            // 
            // 费用分类管理ToolStripMenuItem
            // 
            this.费用分类管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoryMan});
            this.费用分类管理ToolStripMenuItem.Name = "费用分类管理ToolStripMenuItem";
            this.费用分类管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.费用分类管理ToolStripMenuItem.Text = "费用分类管理";
            // 
            // menuCategoryMan
            // 
            this.menuCategoryMan.Name = "menuCategoryMan";
            this.menuCategoryMan.Size = new System.Drawing.Size(152, 22);
            this.menuCategoryMan.Text = "费用分类管理";
            this.menuCategoryMan.Click += new System.EventHandler(this.menuCategoryMan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "测试";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 经费本管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFundList;
        private System.Windows.Forms.ToolStripMenuItem 用款管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExpenseOv;
        private System.Windows.Forms.ToolStripMenuItem 费用分类管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCategoryMan;
    }
}

