namespace smart_logistics_app.control
{
	partial class vechSubFormD
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.type_comBox = new System.Windows.Forms.ComboBox();
			this.num_textBox = new System.Windows.Forms.TextBox();
			this.status_comBox = new System.Windows.Forms.ComboBox();
			this.ok_button = new System.Windows.Forms.Button();
			this.cal_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(44, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "车型名称";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(12, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "车牌号或编号";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(41, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "车辆状态";
			// 
			// type_comBox
			// 
			this.type_comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.type_comBox.FormattingEnabled = true;
			this.type_comBox.Location = new System.Drawing.Point(118, 18);
			this.type_comBox.Name = "type_comBox";
			this.type_comBox.Size = new System.Drawing.Size(178, 23);
			this.type_comBox.TabIndex = 4;
			// 
			// num_textBox
			// 
			this.num_textBox.Location = new System.Drawing.Point(116, 76);
			this.num_textBox.Name = "num_textBox";
			this.num_textBox.Size = new System.Drawing.Size(179, 25);
			this.num_textBox.TabIndex = 5;
			// 
			// status_comBox
			// 
			this.status_comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.status_comBox.FormattingEnabled = true;
			this.status_comBox.Items.AddRange(new object[] {
            "车况完好",
            "能源待补充",
            "车辆损坏",
            "道路限行",
            "配送中"});
			this.status_comBox.Location = new System.Drawing.Point(119, 140);
			this.status_comBox.Name = "status_comBox";
			this.status_comBox.Size = new System.Drawing.Size(175, 23);
			this.status_comBox.TabIndex = 6;
			// 
			// ok_button
			// 
			this.ok_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.ok;
			this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok_button.Location = new System.Drawing.Point(337, 131);
			this.ok_button.Name = "ok_button";
			this.ok_button.Size = new System.Drawing.Size(49, 39);
			this.ok_button.TabIndex = 7;
			this.ok_button.UseVisualStyleBackColor = true;
			this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
			// 
			// cal_button
			// 
			this.cal_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.cancel;
			this.cal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cal_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cal_button.Location = new System.Drawing.Point(392, 131);
			this.cal_button.Name = "cal_button";
			this.cal_button.Size = new System.Drawing.Size(49, 39);
			this.cal_button.TabIndex = 8;
			this.cal_button.UseVisualStyleBackColor = true;
			this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
			// 
			// vechSubFormD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 186);
			this.Controls.Add(this.cal_button);
			this.Controls.Add(this.ok_button);
			this.Controls.Add(this.status_comBox);
			this.Controls.Add(this.num_textBox);
			this.Controls.Add(this.type_comBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "vechSubFormD";
			this.Text = "vechSubFormD";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox type_comBox;
		private System.Windows.Forms.TextBox num_textBox;
		private System.Windows.Forms.ComboBox status_comBox;
		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Button cal_button;
	}
}