namespace smart_logistics_app.control
{
	partial class listForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.index_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.number_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.info_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phone_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addr_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.time_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.client_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remark_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.source_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.加载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.加载文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.加载文件夹ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.清空表单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.加载文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.分析表单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.分析地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存至数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.导出ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.status_Strip = new System.Windows.Forms.StatusStrip();
			this.status_Label1 = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.status_Strip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataView
			// 
			this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index_column,
            this.name_column,
            this.number_column,
            this.info_column,
            this.phone_column,
            this.addr_column,
            this.time_column,
            this.client_column,
            this.remark_column,
            this.source_column});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataView.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataView.Location = new System.Drawing.Point(4, 49);
			this.dataView.Name = "dataView";
			this.dataView.RowTemplate.Height = 27;
			this.dataView.Size = new System.Drawing.Size(1103, 640);
			this.dataView.TabIndex = 0;
			this.dataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataView_CellBeginEdit);
			this.dataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellEndEdit);
			this.dataView.Resize += new System.EventHandler(this.dataGrid_Resize);
			// 
			// index_column
			// 
			this.index_column.HeaderText = "序号";
			this.index_column.Name = "index_column";
			this.index_column.ReadOnly = true;
			// 
			// name_column
			// 
			this.name_column.HeaderText = "姓名";
			this.name_column.Name = "name_column";
			// 
			// number_column
			// 
			this.number_column.HeaderText = "数量";
			this.number_column.Name = "number_column";
			// 
			// info_column
			// 
			this.info_column.HeaderText = "配送信息";
			this.info_column.Name = "info_column";
			// 
			// phone_column
			// 
			this.phone_column.HeaderText = "联系方式";
			this.phone_column.Name = "phone_column";
			// 
			// addr_column
			// 
			this.addr_column.HeaderText = "配送地址";
			this.addr_column.Name = "addr_column";
			// 
			// time_column
			// 
			this.time_column.HeaderText = "预计时间";
			this.time_column.Name = "time_column";
			// 
			// client_column
			// 
			this.client_column.HeaderText = "客户签收";
			this.client_column.Name = "client_column";
			// 
			// remark_column
			// 
			this.remark_column.HeaderText = "备注";
			this.remark_column.Name = "remark_column";
			// 
			// source_column
			// 
			this.source_column.HeaderText = "发货人";
			this.source_column.Name = "source_column";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载文件ToolStripMenuItem,
            this.加载文件夹ToolStripMenuItem,
            this.数据ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 加载文件ToolStripMenuItem
			// 
			this.加载文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载文件ToolStripMenuItem1,
            this.加载文件夹ToolStripMenuItem1,
            this.清空表单ToolStripMenuItem});
			this.加载文件ToolStripMenuItem.Name = "加载文件ToolStripMenuItem";
			this.加载文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.加载文件ToolStripMenuItem.Text = "文件";
			// 
			// 加载文件ToolStripMenuItem1
			// 
			this.加载文件ToolStripMenuItem1.Name = "加载文件ToolStripMenuItem1";
			this.加载文件ToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
			this.加载文件ToolStripMenuItem1.Text = "加载文件";
			this.加载文件ToolStripMenuItem1.Click += new System.EventHandler(this.加载文件ToolStripMenuItem1_Click);
			// 
			// 加载文件夹ToolStripMenuItem1
			// 
			this.加载文件夹ToolStripMenuItem1.Name = "加载文件夹ToolStripMenuItem1";
			this.加载文件夹ToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
			this.加载文件夹ToolStripMenuItem1.Text = "加载文件夹";
			// 
			// 清空表单ToolStripMenuItem
			// 
			this.清空表单ToolStripMenuItem.Name = "清空表单ToolStripMenuItem";
			this.清空表单ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
			this.清空表单ToolStripMenuItem.Text = "清空表单";
			this.清空表单ToolStripMenuItem.Click += new System.EventHandler(this.清空表单ToolStripMenuItem_Click);
			// 
			// 加载文件夹ToolStripMenuItem
			// 
			this.加载文件夹ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分析表单ToolStripMenuItem,
            this.分析地址ToolStripMenuItem});
			this.加载文件夹ToolStripMenuItem.Name = "加载文件夹ToolStripMenuItem";
			this.加载文件夹ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.加载文件夹ToolStripMenuItem.Text = "分析";
			// 
			// 分析表单ToolStripMenuItem
			// 
			this.分析表单ToolStripMenuItem.Name = "分析表单ToolStripMenuItem";
			this.分析表单ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.分析表单ToolStripMenuItem.Text = "分析表单";
			// 
			// 分析地址ToolStripMenuItem
			// 
			this.分析地址ToolStripMenuItem.Name = "分析地址ToolStripMenuItem";
			this.分析地址ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.分析地址ToolStripMenuItem.Text = "分析地址";
			this.分析地址ToolStripMenuItem.Click += new System.EventHandler(this.分析地址ToolStripMenuItem_Click);
			// 
			// 数据ToolStripMenuItem
			// 
			this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存至数据库ToolStripMenuItem,
            this.导出ExcelToolStripMenuItem});
			this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
			this.数据ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.数据ToolStripMenuItem.Text = "数据";
			// 
			// 保存至数据库ToolStripMenuItem
			// 
			this.保存至数据库ToolStripMenuItem.Name = "保存至数据库ToolStripMenuItem";
			this.保存至数据库ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.保存至数据库ToolStripMenuItem.Text = "保存至数据库";
			// 
			// 导出ExcelToolStripMenuItem
			// 
			this.导出ExcelToolStripMenuItem.Name = "导出ExcelToolStripMenuItem";
			this.导出ExcelToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.导出ExcelToolStripMenuItem.Text = "导出Excel";
			// 
			// status_Strip
			// 
			this.status_Strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.status_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_Label1});
			this.status_Strip.Location = new System.Drawing.Point(0, 635);
			this.status_Strip.Name = "status_Strip";
			this.status_Strip.Size = new System.Drawing.Size(1119, 25);
			this.status_Strip.TabIndex = 2;
			this.status_Strip.Text = "statusStrip1";
			this.status_Strip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// status_Label1
			// 
			this.status_Label1.Name = "status_Label1";
			this.status_Label1.Size = new System.Drawing.Size(39, 20);
			this.status_Label1.Text = "状态";
			// 
			// listForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1119, 660);
			this.Controls.Add(this.status_Strip);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "listForm";
			this.Text = "货物信息";
			this.Load += new System.EventHandler(this.listForm_Load);
			this.Resize += new System.EventHandler(this.listForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.status_Strip.ResumeLayout(false);
			this.status_Strip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 加载文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 加载文件夹ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 加载文件ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 加载文件夹ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 分析表单ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 分析地址ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存至数据库ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 导出ExcelToolStripMenuItem;
		private System.Windows.Forms.StatusStrip status_Strip;
		private System.Windows.Forms.ToolStripStatusLabel status_Label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn index_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn number_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn info_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn addr_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn time_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn client_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn remark_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn source_column;
		private System.Windows.Forms.ToolStripMenuItem 清空表单ToolStripMenuItem;
	}
}