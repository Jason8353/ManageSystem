namespace userForm
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.userTitle = new System.Windows.Forms.Panel();
            this.proBtn = new System.Windows.Forms.Button();
            this.ageBtn = new System.Windows.Forms.Button();
            this.nameBtn = new System.Windows.Forms.Button();
            this.numBtn = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.delBtn = new System.Windows.Forms.Button();
            this.alterBtn = new System.Windows.Forms.Button();
            this.serBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDisplay.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.userTitle.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80843F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19157F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.53271F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.46729F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new System.Drawing.Size(522, 159);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDisplay.Controls.Add(this.panelInfo);
            this.panelDisplay.Controls.Add(this.panelNav);
            this.panelDisplay.Controls.Add(this.panelTitle);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(661, 460);
            this.panelDisplay.TabIndex = 0;
            this.panelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplay_Paint);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(tableLayoutPanel1);
            this.panelInfo.Controls.Add(this.userTitle);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(136, 77);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(525, 383);
            this.panelInfo.TabIndex = 2;
            // 
            // userTitle
            // 
            this.userTitle.Controls.Add(this.proBtn);
            this.userTitle.Controls.Add(this.ageBtn);
            this.userTitle.Controls.Add(this.nameBtn);
            this.userTitle.Controls.Add(this.numBtn);
            this.userTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.userTitle.Location = new System.Drawing.Point(0, 0);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(525, 53);
            this.userTitle.TabIndex = 0;
            // 
            // proBtn
            // 
            this.proBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.proBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.proBtn.Location = new System.Drawing.Point(393, 0);
            this.proBtn.Name = "proBtn";
            this.proBtn.Size = new System.Drawing.Size(130, 53);
            this.proBtn.TabIndex = 3;
            this.proBtn.Text = "专业";
            this.proBtn.UseVisualStyleBackColor = true;
            // 
            // ageBtn
            // 
            this.ageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ageBtn.Location = new System.Drawing.Point(262, 0);
            this.ageBtn.Name = "ageBtn";
            this.ageBtn.Size = new System.Drawing.Size(131, 53);
            this.ageBtn.TabIndex = 2;
            this.ageBtn.Text = "年龄";
            this.ageBtn.UseVisualStyleBackColor = true;
            this.ageBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameBtn
            // 
            this.nameBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameBtn.Location = new System.Drawing.Point(131, 0);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(131, 53);
            this.nameBtn.TabIndex = 1;
            this.nameBtn.Text = "姓名";
            this.nameBtn.UseVisualStyleBackColor = true;
            // 
            // numBtn
            // 
            this.numBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.numBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numBtn.Location = new System.Drawing.Point(0, 0);
            this.numBtn.Name = "numBtn";
            this.numBtn.Size = new System.Drawing.Size(131, 53);
            this.numBtn.TabIndex = 0;
            this.numBtn.Text = "学号";
            this.numBtn.UseVisualStyleBackColor = true;
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.delBtn);
            this.panelNav.Controls.Add(this.alterBtn);
            this.panelNav.Controls.Add(this.serBtn);
            this.panelNav.Controls.Add(this.AddBtn);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 77);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(136, 383);
            this.panelNav.TabIndex = 1;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.delBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delBtn.Location = new System.Drawing.Point(0, 159);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(136, 53);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // alterBtn
            // 
            this.alterBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.alterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.alterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alterBtn.Location = new System.Drawing.Point(0, 106);
            this.alterBtn.Name = "alterBtn";
            this.alterBtn.Size = new System.Drawing.Size(136, 53);
            this.alterBtn.TabIndex = 2;
            this.alterBtn.Text = "修改";
            this.alterBtn.UseVisualStyleBackColor = false;
            // 
            // serBtn
            // 
            this.serBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.serBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.serBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serBtn.Location = new System.Drawing.Point(0, 53);
            this.serBtn.Name = "serBtn";
            this.serBtn.Size = new System.Drawing.Size(136, 53);
            this.serBtn.TabIndex = 1;
            this.serBtn.Text = "查找";
            this.serBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(136, 53);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(661, 77);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HomePage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDisplay);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(661, 460);
            this.panelDisplay.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.userTitle.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button alterBtn;
        private System.Windows.Forms.Button serBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel userTitle;
        private System.Windows.Forms.Button numBtn;
        private System.Windows.Forms.Button proBtn;
        private System.Windows.Forms.Button ageBtn;
        private System.Windows.Forms.Button nameBtn;
    }
}
