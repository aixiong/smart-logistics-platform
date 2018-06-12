namespace smart_logistics_app.control
{
	partial class envForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存到数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_strip = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.value_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
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
            this.保存到数据库ToolStripMenuItem});
			this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
			this.数据ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.数据ToolStripMenuItem.Text = "数据";
			// 
			// 保存到数据库ToolStripMenuItem
			// 
			this.保存到数据库ToolStripMenuItem.Name = "保存到数据库ToolStripMenuItem";
			this.保存到数据库ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.保存到数据库ToolStripMenuItem.Text = "保存到数据库";
			this.保存到数据库ToolStripMenuItem.Click += new System.EventHandler(this.保存到数据库ToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_strip});
			this.statusStrip1.Location = new System.Drawing.Point(0, 425);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 25);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status_strip
			// 
			this.status_strip.Name = "status_strip";
			this.status_strip.Size = new System.Drawing.Size(39, 20);
			this.status_strip.Text = "状态";
			// 
			// dataView
			// 
			this.dataView.AllowUserToAddRows = false;
			this.dataView.AllowUserToDeleteRows = false;
			this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_column,
            this.value_column});
			this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataView.Location = new System.Drawing.Point(0, 28);
			this.dataView.Name = "dataView";
			this.dataView.RowTemplate.Height = 27;
			this.dataView.Size = new System.Drawing.Size(800, 397);
			this.dataView.TabIndex = 2;
			this.dataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataView_CellBeginEdit);
			this.dataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellEndEdit);
			// 
			// name_column
			// 
			this.name_column.HeaderText = "属性名称";
			this.name_column.Name = "name_column";
			this.name_column.ReadOnly = true;
			this.name_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// value_column
			// 
			this.value_column.HeaderText = "属性值";
			this.value_column.Name = "value_column";
			this.value_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// envForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "envForm";
			this.Text = "系统设置";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.envForm_FormClosing);
			this.Load += new System.EventHandler(this.envForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存到数据库ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status_strip;
		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn value_column;
	}
}