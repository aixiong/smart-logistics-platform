namespace smart_logistics_app.control
{
	partial class algoForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addr_refresh = new System.Windows.Forms.Button();
			this.addr_button = new System.Windows.Forms.Button();
			this.dataView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.veh_refresh = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataView3 = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veh_button = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.box_refresh = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dataView4 = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.box_button = new System.Windows.Forms.Button();
			this.run_button = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.检查订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.配送算法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.执行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_strip = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView3)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView4)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataView1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(9, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(931, 133);
			this.panel1.TabIndex = 0;
			// 
			// dataView1
			// 
			this.dataView1.AllowUserToAddRows = false;
			this.dataView1.AllowUserToDeleteRows = false;
			this.dataView1.AllowUserToResizeRows = false;
			this.dataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.dataView1.Location = new System.Drawing.Point(-2, 54);
			this.dataView1.MultiSelect = false;
			this.dataView1.Name = "dataView1";
			this.dataView1.RowTemplate.Height = 27;
			this.dataView1.Size = new System.Drawing.Size(930, 77);
			this.dataView1.TabIndex = 2;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "公司名称";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.addr_refresh);
			this.panel2.Controls.Add(this.addr_button);
			this.panel2.Controls.Add(this.dataView2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(8, 192);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(931, 133);
			this.panel2.TabIndex = 1;
			// 
			// addr_refresh
			// 
			this.addr_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addr_refresh.Location = new System.Drawing.Point(687, 3);
			this.addr_refresh.Name = "addr_refresh";
			this.addr_refresh.Size = new System.Drawing.Size(74, 40);
			this.addr_refresh.TabIndex = 5;
			this.addr_refresh.Text = "刷新";
			this.addr_refresh.UseVisualStyleBackColor = true;
			this.addr_refresh.Click += new System.EventHandler(this.addr_refresh_Click);
			// 
			// addr_button
			// 
			this.addr_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addr_button.Location = new System.Drawing.Point(781, 3);
			this.addr_button.Name = "addr_button";
			this.addr_button.Size = new System.Drawing.Size(147, 41);
			this.addr_button.TabIndex = 4;
			this.addr_button.Text = "地址分析";
			this.addr_button.UseVisualStyleBackColor = true;
			this.addr_button.Click += new System.EventHandler(this.addr_button_Click);
			// 
			// dataView2
			// 
			this.dataView2.AllowUserToAddRows = false;
			this.dataView2.AllowUserToDeleteRows = false;
			this.dataView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3});
			this.dataView2.Location = new System.Drawing.Point(0, 50);
			this.dataView2.Name = "dataView2";
			this.dataView2.RowTemplate.Height = 27;
			this.dataView2.Size = new System.Drawing.Size(931, 81);
			this.dataView2.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "已知地址数量";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "未知地址数量";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "地址总数";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.veh_refresh);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.dataView3);
			this.panel3.Controls.Add(this.veh_button);
			this.panel3.Location = new System.Drawing.Point(8, 336);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(931, 116);
			this.panel3.TabIndex = 2;
			// 
			// veh_refresh
			// 
			this.veh_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.veh_refresh.Location = new System.Drawing.Point(687, 3);
			this.veh_refresh.Name = "veh_refresh";
			this.veh_refresh.Size = new System.Drawing.Size(74, 40);
			this.veh_refresh.TabIndex = 6;
			this.veh_refresh.Text = "刷新";
			this.veh_refresh.UseVisualStyleBackColor = true;
			this.veh_refresh.Click += new System.EventHandler(this.veh_refresh_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			// 
			// dataView3
			// 
			this.dataView3.AllowUserToAddRows = false;
			this.dataView3.AllowUserToDeleteRows = false;
			this.dataView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.column6});
			this.dataView3.Location = new System.Drawing.Point(0, 50);
			this.dataView3.Name = "dataView3";
			this.dataView3.RowTemplate.Height = 27;
			this.dataView3.Size = new System.Drawing.Size(931, 65);
			this.dataView3.TabIndex = 5;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "金杯车数量";
			this.Column4.Name = "Column4";
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "新能源车数量";
			this.Column5.Name = "Column5";
			// 
			// column6
			// 
			this.column6.HeaderText = "合计";
			this.column6.Name = "column6";
			// 
			// veh_button
			// 
			this.veh_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.veh_button.Location = new System.Drawing.Point(779, 3);
			this.veh_button.Name = "veh_button";
			this.veh_button.Size = new System.Drawing.Size(147, 41);
			this.veh_button.TabIndex = 5;
			this.veh_button.Text = "车辆设置";
			this.veh_button.UseVisualStyleBackColor = true;
			this.veh_button.Click += new System.EventHandler(this.veh_button_Click);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.box_refresh);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.dataView4);
			this.panel4.Controls.Add(this.box_button);
			this.panel4.Location = new System.Drawing.Point(8, 465);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(931, 119);
			this.panel4.TabIndex = 1;
			// 
			// box_refresh
			// 
			this.box_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.box_refresh.Location = new System.Drawing.Point(687, 3);
			this.box_refresh.Name = "box_refresh";
			this.box_refresh.Size = new System.Drawing.Size(74, 40);
			this.box_refresh.TabIndex = 7;
			this.box_refresh.Text = "刷新";
			this.box_refresh.UseVisualStyleBackColor = true;
			this.box_refresh.Click += new System.EventHandler(this.box_refresh_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// dataView4
			// 
			this.dataView4.AllowUserToAddRows = false;
			this.dataView4.AllowUserToDeleteRows = false;
			this.dataView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7});
			this.dataView4.Location = new System.Drawing.Point(-1, 50);
			this.dataView4.Name = "dataView4";
			this.dataView4.RowTemplate.Height = 27;
			this.dataView4.Size = new System.Drawing.Size(931, 68);
			this.dataView4.TabIndex = 6;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "公司名称";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// box_button
			// 
			this.box_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.box_button.Location = new System.Drawing.Point(779, 3);
			this.box_button.Name = "box_button";
			this.box_button.Size = new System.Drawing.Size(147, 41);
			this.box_button.TabIndex = 6;
			this.box_button.Text = "装载箱设置";
			this.box_button.UseVisualStyleBackColor = true;
			this.box_button.Click += new System.EventHandler(this.box_button_Click);
			// 
			// run_button
			// 
			this.run_button.Location = new System.Drawing.Point(404, 592);
			this.run_button.Name = "run_button";
			this.run_button.Size = new System.Drawing.Size(138, 38);
			this.run_button.TabIndex = 3;
			this.run_button.Text = "执行算法";
			this.run_button.UseVisualStyleBackColor = true;
			this.run_button.Click += new System.EventHandler(this.run_button_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查ToolStripMenuItem,
            this.配送算法ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(951, 28);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 检查ToolStripMenuItem
			// 
			this.检查ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查订单ToolStripMenuItem});
			this.检查ToolStripMenuItem.Name = "检查ToolStripMenuItem";
			this.检查ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.检查ToolStripMenuItem.Text = "检查";
			// 
			// 检查订单ToolStripMenuItem
			// 
			this.检查订单ToolStripMenuItem.Name = "检查订单ToolStripMenuItem";
			this.检查订单ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.检查订单ToolStripMenuItem.Text = "重新检查";
			// 
			// 配送算法ToolStripMenuItem
			// 
			this.配送算法ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行ToolStripMenuItem});
			this.配送算法ToolStripMenuItem.Name = "配送算法ToolStripMenuItem";
			this.配送算法ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.配送算法ToolStripMenuItem.Text = "配送算法";
			// 
			// 执行ToolStripMenuItem
			// 
			this.执行ToolStripMenuItem.Name = "执行ToolStripMenuItem";
			this.执行ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
			this.执行ToolStripMenuItem.Text = "执行";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_strip});
			this.statusStrip1.Location = new System.Drawing.Point(0, 632);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(951, 25);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status_strip
			// 
			this.status_strip.Name = "status_strip";
			this.status_strip.Size = new System.Drawing.Size(39, 20);
			this.status_strip.Text = "状态";
			// 
			// algoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(951, 657);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.run_button);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "algoForm";
			this.Text = "配送算法";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView3)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView4)).EndInit();
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
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button run_button;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.DataGridView dataView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem 检查ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 检查订单ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 配送算法ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 执行ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridView dataView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripStatusLabel status_strip;
		private System.Windows.Forms.Button addr_button;
		private System.Windows.Forms.Button veh_button;
		private System.Windows.Forms.Button box_button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataView3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn column6;
		private System.Windows.Forms.Button addr_refresh;
		private System.Windows.Forms.Button veh_refresh;
		private System.Windows.Forms.Button box_refresh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}