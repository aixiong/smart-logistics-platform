namespace smart_logistics_app.control
{
	partial class addrAnalyser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.index_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.显示所有目标点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存至数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.自动定位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_strip = new System.Windows.Forms.ToolStripStatusLabel();
			this.status_progress = new System.Windows.Forms.ToolStripProgressBar();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataView);
			this.panel1.Location = new System.Drawing.Point(37, 343);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(921, 233);
			this.panel1.TabIndex = 0;
			// 
			// dataView
			// 
			this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index_column,
            this.addrName,
            this.latitude,
            this.longitude});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataView.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataView.Location = new System.Drawing.Point(0, 0);
			this.dataView.Name = "dataView";
			this.dataView.RowTemplate.Height = 27;
			this.dataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataView.Size = new System.Drawing.Size(921, 233);
			this.dataView.TabIndex = 0;
			this.dataView.Click += new System.EventHandler(this.dataView_Click);
			this.dataView.Resize += new System.EventHandler(this.dataGridView1_Resize);
			// 
			// index_column
			// 
			this.index_column.HeaderText = "序号";
			this.index_column.Name = "index_column";
			this.index_column.ReadOnly = true;
			// 
			// addrName
			// 
			this.addrName.HeaderText = "地址名称";
			this.addrName.Name = "addrName";
			this.addrName.ReadOnly = true;
			// 
			// latitude
			// 
			this.latitude.HeaderText = "纬度";
			this.latitude.Name = "latitude";
			this.latitude.ReadOnly = true;
			// 
			// longitude
			// 
			this.longitude.HeaderText = "经度";
			this.longitude.Name = "longitude";
			this.longitude.ReadOnly = true;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(37, 41);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(921, 233);
			this.panel2.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.自动定位ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(992, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 显示ToolStripMenuItem
			// 
			this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示所有目标点ToolStripMenuItem});
			this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
			this.显示ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.显示ToolStripMenuItem.Text = "显示";
			// 
			// 显示所有目标点ToolStripMenuItem
			// 
			this.显示所有目标点ToolStripMenuItem.Name = "显示所有目标点ToolStripMenuItem";
			this.显示所有目标点ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.显示所有目标点ToolStripMenuItem.Text = "显示所有目标点";
			this.显示所有目标点ToolStripMenuItem.Click += new System.EventHandler(this.显示所有目标点ToolStripMenuItem_Click);
			// 
			// 数据ToolStripMenuItem
			// 
			this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存至数据库ToolStripMenuItem});
			this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
			this.数据ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.数据ToolStripMenuItem.Text = "数据";
			// 
			// 保存至数据库ToolStripMenuItem
			// 
			this.保存至数据库ToolStripMenuItem.Name = "保存至数据库ToolStripMenuItem";
			this.保存至数据库ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
			this.保存至数据库ToolStripMenuItem.Text = "保存至数据库";
			this.保存至数据库ToolStripMenuItem.Click += new System.EventHandler(this.保存至数据库ToolStripMenuItem_Click);
			// 
			// 自动定位ToolStripMenuItem
			// 
			this.自动定位ToolStripMenuItem.Name = "自动定位ToolStripMenuItem";
			this.自动定位ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.自动定位ToolStripMenuItem.Text = "自动定位";
			this.自动定位ToolStripMenuItem.Click += new System.EventHandler(this.自动定位ToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_strip,
            this.status_progress});
			this.statusStrip1.Location = new System.Drawing.Point(0, 576);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(992, 25);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status_strip
			// 
			this.status_strip.AutoSize = false;
			this.status_strip.Name = "status_strip";
			this.status_strip.Size = new System.Drawing.Size(339, 20);
			this.status_strip.Text = "状态";
			// 
			// status_progress
			// 
			this.status_progress.Name = "status_progress";
			this.status_progress.Size = new System.Drawing.Size(500, 19);
			this.status_progress.Step = 1;
			// 
			// addrAnalyser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(992, 601);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.Name = "addrAnalyser";
			this.Text = "addrAnalyser";
			this.Load += new System.EventHandler(this.addrAnalyser_Load);
			this.Resize += new System.EventHandler(this.addrAnalyser_Resize);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 显示所有目标点ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存至数据库ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status_strip;
		private System.Windows.Forms.DataGridViewTextBoxColumn index_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn addrName;
		private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
		private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
		private System.Windows.Forms.ToolStripProgressBar status_progress;
		private System.Windows.Forms.ToolStripMenuItem 自动定位ToolStripMenuItem;
	}
}