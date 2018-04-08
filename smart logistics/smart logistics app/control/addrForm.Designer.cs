namespace smart_logistics_app
{
	partial class addrForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addrForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.send_comBox = new System.Windows.Forms.ComboBox();
			this.recv_comBox = new System.Windows.Forms.ComboBox();
			this.deleteButtonS = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.deleteButtonR = new System.Windows.Forms.Button();
			this.addButtonR = new System.Windows.Forms.Button();
			this.viewButtonR = new System.Windows.Forms.Button();
			this.addButtonS = new System.Windows.Forms.Button();
			this.viewButtonS = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "发货地址";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "收货地址";
			// 
			// send_comBox
			// 
			this.send_comBox.DropDownHeight = 200;
			this.send_comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.send_comBox.FormattingEnabled = true;
			this.send_comBox.IntegralHeight = false;
			this.send_comBox.Location = new System.Drawing.Point(44, 55);
			this.send_comBox.Margin = new System.Windows.Forms.Padding(2);
			this.send_comBox.Name = "send_comBox";
			this.send_comBox.Size = new System.Drawing.Size(506, 26);
			this.send_comBox.TabIndex = 2;
			// 
			// recv_comBox
			// 
			this.recv_comBox.DropDownHeight = 300;
			this.recv_comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.recv_comBox.FormattingEnabled = true;
			this.recv_comBox.IntegralHeight = false;
			this.recv_comBox.Location = new System.Drawing.Point(44, 111);
			this.recv_comBox.Margin = new System.Windows.Forms.Padding(2);
			this.recv_comBox.Name = "recv_comBox";
			this.recv_comBox.Size = new System.Drawing.Size(506, 26);
			this.recv_comBox.TabIndex = 3;
			// 
			// deleteButtonS
			// 
			this.deleteButtonS.BackgroundImage = global::smart_logistics_app.Properties.Resources.delete;
			this.deleteButtonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.deleteButtonS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteButtonS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteButtonS.Location = new System.Drawing.Point(700, 54);
			this.deleteButtonS.Name = "deleteButtonS";
			this.deleteButtonS.Size = new System.Drawing.Size(36, 26);
			this.deleteButtonS.TabIndex = 6;
			this.deleteButtonS.UseVisualStyleBackColor = true;
			this.deleteButtonS.Click += new System.EventHandler(this.deleteButtonS_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(779, 27);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::smart_logistics_app.Properties.Resources.edit;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton1.Text = "列表显示";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::smart_logistics_app.Properties.Resources.view;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton2.Text = "全屏显示";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// deleteButtonR
			// 
			this.deleteButtonR.BackgroundImage = global::smart_logistics_app.Properties.Resources.delete;
			this.deleteButtonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.deleteButtonR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteButtonR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteButtonR.Location = new System.Drawing.Point(700, 111);
			this.deleteButtonR.Name = "deleteButtonR";
			this.deleteButtonR.Size = new System.Drawing.Size(36, 26);
			this.deleteButtonR.TabIndex = 9;
			this.deleteButtonR.UseVisualStyleBackColor = true;
			this.deleteButtonR.Click += new System.EventHandler(this.deleteButtonR_Click);
			// 
			// addButtonR
			// 
			this.addButtonR.BackgroundImage = global::smart_logistics_app.Properties.Resources.add;
			this.addButtonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.addButtonR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addButtonR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.addButtonR.Location = new System.Drawing.Point(639, 111);
			this.addButtonR.Name = "addButtonR";
			this.addButtonR.Size = new System.Drawing.Size(36, 26);
			this.addButtonR.TabIndex = 8;
			this.addButtonR.UseVisualStyleBackColor = true;
			this.addButtonR.Click += new System.EventHandler(this.addButtonR_Click);
			// 
			// viewButtonR
			// 
			this.viewButtonR.BackgroundImage = global::smart_logistics_app.Properties.Resources.view;
			this.viewButtonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.viewButtonR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.viewButtonR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.viewButtonR.Location = new System.Drawing.Point(578, 111);
			this.viewButtonR.Name = "viewButtonR";
			this.viewButtonR.Size = new System.Drawing.Size(36, 26);
			this.viewButtonR.TabIndex = 7;
			this.viewButtonR.UseVisualStyleBackColor = true;
			this.viewButtonR.Click += new System.EventHandler(this.viewButtonR_Click);
			// 
			// addButtonS
			// 
			this.addButtonS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButtonS.BackgroundImage")));
			this.addButtonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.addButtonS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addButtonS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.addButtonS.Location = new System.Drawing.Point(639, 54);
			this.addButtonS.Name = "addButtonS";
			this.addButtonS.Size = new System.Drawing.Size(36, 26);
			this.addButtonS.TabIndex = 5;
			this.addButtonS.UseVisualStyleBackColor = true;
			this.addButtonS.Click += new System.EventHandler(this.addButtonS_Click);
			// 
			// viewButtonS
			// 
			this.viewButtonS.BackColor = System.Drawing.SystemColors.Control;
			this.viewButtonS.BackgroundImage = global::smart_logistics_app.Properties.Resources.view;
			this.viewButtonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.viewButtonS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.viewButtonS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.viewButtonS.Location = new System.Drawing.Point(578, 54);
			this.viewButtonS.Name = "viewButtonS";
			this.viewButtonS.Size = new System.Drawing.Size(36, 27);
			this.viewButtonS.TabIndex = 4;
			this.viewButtonS.UseVisualStyleBackColor = false;
			this.viewButtonS.Click += new System.EventHandler(this.viewButtonS_Click);
			// 
			// addrForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 643);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.deleteButtonR);
			this.Controls.Add(this.addButtonR);
			this.Controls.Add(this.viewButtonR);
			this.Controls.Add(this.deleteButtonS);
			this.Controls.Add(this.addButtonS);
			this.Controls.Add(this.viewButtonS);
			this.Controls.Add(this.recv_comBox);
			this.Controls.Add(this.send_comBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "addrForm";
			this.Text = "地址管理";
			this.Resize += new System.EventHandler(this.addrForm_Resize);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox send_comBox;
		private System.Windows.Forms.ComboBox recv_comBox;
		private System.Windows.Forms.Button viewButtonS;
		private System.Windows.Forms.Button addButtonS;
		private System.Windows.Forms.Button deleteButtonS;
		private System.Windows.Forms.Button viewButtonR;
		private System.Windows.Forms.Button addButtonR;
		private System.Windows.Forms.Button deleteButtonR;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}

