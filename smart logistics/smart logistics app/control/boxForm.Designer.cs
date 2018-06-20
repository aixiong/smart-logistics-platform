namespace smart_logistics_app.control
{
	partial class boxForm
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存到数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_strip = new System.Windows.Forms.ToolStripStatusLabel();
			this.helpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.删除该项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.helpMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 数据ToolStripMenuItem
			// 
			this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存到数据库ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
			this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
			this.数据ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.数据ToolStripMenuItem.Text = "数据";
			// 
			// 保存到数据库ToolStripMenuItem
			// 
			this.保存到数据库ToolStripMenuItem.Name = "保存到数据库ToolStripMenuItem";
			this.保存到数据库ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.保存到数据库ToolStripMenuItem.Text = "保存到数据库";
			this.保存到数据库ToolStripMenuItem.Click += new System.EventHandler(this.保存到数据库ToolStripMenuItem_Click);
			// 
			// 刷新ToolStripMenuItem
			// 
			this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
			this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.刷新ToolStripMenuItem.Text = "刷新";
			this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
			// 
			// dataView
			// 
			this.dataView.AllowUserToDeleteRows = false;
			this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataView.Location = new System.Drawing.Point(0, 28);
			this.dataView.Name = "dataView";
			this.dataView.RowTemplate.Height = 27;
			this.dataView.Size = new System.Drawing.Size(800, 422);
			this.dataView.TabIndex = 1;
			this.dataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataView_CellBeginEdit);
			this.dataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellEndEdit);
			this.dataView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataView_MouseClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "公司名称";
			this.Column1.Name = "Column1";
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "长(cm)";
			this.Column2.Name = "Column2";
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "宽(cm)";
			this.Column3.Name = "Column3";
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "高(cm)";
			this.Column4.Name = "Column4";
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_strip});
			this.statusStrip1.Location = new System.Drawing.Point(0, 425);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 25);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status_strip
			// 
			this.status_strip.Name = "status_strip";
			this.status_strip.Size = new System.Drawing.Size(167, 20);
			this.status_strip.Text = "toolStripStatusLabel1";
			// 
			// helpMenu
			// 
			this.helpMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.helpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除该项ToolStripMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(217, 58);
			// 
			// 删除该项ToolStripMenuItem
			// 
			this.删除该项ToolStripMenuItem.Name = "删除该项ToolStripMenuItem";
			this.删除该项ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.删除该项ToolStripMenuItem.Text = "删除该项";
			this.删除该项ToolStripMenuItem.Click += new System.EventHandler(this.删除该项ToolStripMenuItem_Click);
			// 
			// boxForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "boxForm";
			this.Text = "装载箱设置";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.boxForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.helpMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存到数据库ToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status_strip;
		private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.ContextMenuStrip helpMenu;
		private System.Windows.Forms.ToolStripMenuItem 删除该项ToolStripMenuItem;
	}
}