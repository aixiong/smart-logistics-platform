namespace smart_logistics_app.control
{
	partial class goodsQForm
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
			this.number_textBox = new System.Windows.Forms.TextBox();
			this.arriveS_time = new System.Windows.Forms.DateTimePicker();
			this.arriveF_time = new System.Windows.Forms.DateTimePicker();
			this.finishS_time = new System.Windows.Forms.DateTimePicker();
			this.finishF_time = new System.Windows.Forms.DateTimePicker();
			this.num_checkBox = new System.Windows.Forms.CheckBox();
			this.arrive_checkBox = new System.Windows.Forms.CheckBox();
			this.finish_checkBox = new System.Windows.Forms.CheckBox();
			this.status_checkBox = new System.Windows.Forms.CheckBox();
			this.status_comBox = new System.Windows.Forms.ComboBox();
			this.vech_checkBox = new System.Windows.Forms.CheckBox();
			this.vech_comBox = new System.Windows.Forms.ComboBox();
			this.dest_checkBox = new System.Windows.Forms.CheckBox();
			this.dest_comBox = new System.Windows.Forms.ComboBox();
			this.cal_button = new System.Windows.Forms.Button();
			this.ok_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// number_textBox
			// 
			this.number_textBox.Location = new System.Drawing.Point(105, 16);
			this.number_textBox.Name = "number_textBox";
			this.number_textBox.Size = new System.Drawing.Size(221, 25);
			this.number_textBox.TabIndex = 7;
			// 
			// arriveS_time
			// 
			this.arriveS_time.CustomFormat = "yyyy-MM-dd";
			this.arriveS_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.arriveS_time.Location = new System.Drawing.Point(104, 66);
			this.arriveS_time.Name = "arriveS_time";
			this.arriveS_time.Size = new System.Drawing.Size(127, 25);
			this.arriveS_time.TabIndex = 17;
			// 
			// arriveF_time
			// 
			this.arriveF_time.CustomFormat = "yyyy-MM-dd";
			this.arriveF_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.arriveF_time.Location = new System.Drawing.Point(237, 66);
			this.arriveF_time.Name = "arriveF_time";
			this.arriveF_time.Size = new System.Drawing.Size(127, 25);
			this.arriveF_time.TabIndex = 18;
			// 
			// finishS_time
			// 
			this.finishS_time.CustomFormat = "yyyy-MM-dd";
			this.finishS_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.finishS_time.Location = new System.Drawing.Point(104, 115);
			this.finishS_time.Name = "finishS_time";
			this.finishS_time.Size = new System.Drawing.Size(127, 25);
			this.finishS_time.TabIndex = 20;
			// 
			// finishF_time
			// 
			this.finishF_time.CustomFormat = "yyyy-MM-dd";
			this.finishF_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.finishF_time.Location = new System.Drawing.Point(237, 115);
			this.finishF_time.Name = "finishF_time";
			this.finishF_time.Size = new System.Drawing.Size(127, 25);
			this.finishF_time.TabIndex = 21;
			// 
			// num_checkBox
			// 
			this.num_checkBox.AutoSize = true;
			this.num_checkBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.num_checkBox.Location = new System.Drawing.Point(8, 22);
			this.num_checkBox.Name = "num_checkBox";
			this.num_checkBox.Size = new System.Drawing.Size(89, 19);
			this.num_checkBox.TabIndex = 22;
			this.num_checkBox.Text = "货物编号";
			this.num_checkBox.UseVisualStyleBackColor = true;
			// 
			// arrive_checkBox
			// 
			this.arrive_checkBox.AutoSize = true;
			this.arrive_checkBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.arrive_checkBox.Location = new System.Drawing.Point(8, 72);
			this.arrive_checkBox.Name = "arrive_checkBox";
			this.arrive_checkBox.Size = new System.Drawing.Size(89, 19);
			this.arrive_checkBox.TabIndex = 23;
			this.arrive_checkBox.Text = "到达时间";
			this.arrive_checkBox.UseVisualStyleBackColor = true;
			// 
			// finish_checkBox
			// 
			this.finish_checkBox.AutoSize = true;
			this.finish_checkBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.finish_checkBox.Location = new System.Drawing.Point(8, 121);
			this.finish_checkBox.Name = "finish_checkBox";
			this.finish_checkBox.Size = new System.Drawing.Size(89, 19);
			this.finish_checkBox.TabIndex = 24;
			this.finish_checkBox.Text = "完成时间";
			this.finish_checkBox.UseVisualStyleBackColor = true;
			// 
			// status_checkBox
			// 
			this.status_checkBox.AutoSize = true;
			this.status_checkBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.status_checkBox.Location = new System.Drawing.Point(454, 22);
			this.status_checkBox.Name = "status_checkBox";
			this.status_checkBox.Size = new System.Drawing.Size(89, 19);
			this.status_checkBox.TabIndex = 25;
			this.status_checkBox.Text = "货物状态";
			this.status_checkBox.UseVisualStyleBackColor = true;
			// 
			// status_comBox
			// 
			this.status_comBox.FormattingEnabled = true;
			this.status_comBox.Items.AddRange(new object[] {
            "待配送",
            "配送中",
            "已送达"});
			this.status_comBox.Location = new System.Drawing.Point(579, 18);
			this.status_comBox.Name = "status_comBox";
			this.status_comBox.Size = new System.Drawing.Size(162, 23);
			this.status_comBox.TabIndex = 26;
			// 
			// vech_checkBox
			// 
			this.vech_checkBox.AutoSize = true;
			this.vech_checkBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.vech_checkBox.Location = new System.Drawing.Point(454, 72);
			this.vech_checkBox.Name = "vech_checkBox";
			this.vech_checkBox.Size = new System.Drawing.Size(119, 19);
			this.vech_checkBox.TabIndex = 27;
			this.vech_checkBox.Text = "承运车辆编号";
			this.vech_checkBox.UseVisualStyleBackColor = true;
			// 
			// vech_comBox
			// 
			this.vech_comBox.FormattingEnabled = true;
			this.vech_comBox.Items.AddRange(new object[] {
            "待配送",
            "配送中",
            "已送达"});
			this.vech_comBox.Location = new System.Drawing.Point(579, 70);
			this.vech_comBox.Name = "vech_comBox";
			this.vech_comBox.Size = new System.Drawing.Size(162, 23);
			this.vech_comBox.TabIndex = 28;
			// 
			// dest_checkBox
			// 
			this.dest_checkBox.AutoSize = true;
			this.dest_checkBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dest_checkBox.Location = new System.Drawing.Point(454, 121);
			this.dest_checkBox.Name = "dest_checkBox";
			this.dest_checkBox.Size = new System.Drawing.Size(74, 19);
			this.dest_checkBox.TabIndex = 29;
			this.dest_checkBox.Text = "目的地";
			this.dest_checkBox.UseVisualStyleBackColor = true;
			// 
			// dest_comBox
			// 
			this.dest_comBox.FormattingEnabled = true;
			this.dest_comBox.Items.AddRange(new object[] {
            "待配送",
            "配送中",
            "已送达"});
			this.dest_comBox.Location = new System.Drawing.Point(579, 121);
			this.dest_comBox.Name = "dest_comBox";
			this.dest_comBox.Size = new System.Drawing.Size(162, 23);
			this.dest_comBox.TabIndex = 30;
			// 
			// cal_button
			// 
			this.cal_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.cancel;
			this.cal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cal_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cal_button.Location = new System.Drawing.Point(829, 109);
			this.cal_button.Name = "cal_button";
			this.cal_button.Size = new System.Drawing.Size(49, 39);
			this.cal_button.TabIndex = 32;
			this.cal_button.UseVisualStyleBackColor = true;
			this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
			// 
			// ok_button
			// 
			this.ok_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.ok;
			this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok_button.Location = new System.Drawing.Point(760, 109);
			this.ok_button.Name = "ok_button";
			this.ok_button.Size = new System.Drawing.Size(49, 39);
			this.ok_button.TabIndex = 31;
			this.ok_button.UseVisualStyleBackColor = true;
			this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
			// 
			// goodsQForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(992, 160);
			this.Controls.Add(this.cal_button);
			this.Controls.Add(this.ok_button);
			this.Controls.Add(this.dest_comBox);
			this.Controls.Add(this.dest_checkBox);
			this.Controls.Add(this.vech_comBox);
			this.Controls.Add(this.vech_checkBox);
			this.Controls.Add(this.status_comBox);
			this.Controls.Add(this.status_checkBox);
			this.Controls.Add(this.finish_checkBox);
			this.Controls.Add(this.arrive_checkBox);
			this.Controls.Add(this.num_checkBox);
			this.Controls.Add(this.finishF_time);
			this.Controls.Add(this.finishS_time);
			this.Controls.Add(this.arriveF_time);
			this.Controls.Add(this.arriveS_time);
			this.Controls.Add(this.number_textBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "goodsQForm";
			this.Text = "goodsQForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox number_textBox;
		private System.Windows.Forms.DateTimePicker arriveS_time;
		private System.Windows.Forms.DateTimePicker arriveF_time;
		private System.Windows.Forms.DateTimePicker finishS_time;
		private System.Windows.Forms.DateTimePicker finishF_time;
		private System.Windows.Forms.CheckBox num_checkBox;
		private System.Windows.Forms.CheckBox arrive_checkBox;
		private System.Windows.Forms.CheckBox finish_checkBox;
		private System.Windows.Forms.CheckBox status_checkBox;
		private System.Windows.Forms.ComboBox status_comBox;
		private System.Windows.Forms.CheckBox vech_checkBox;
		private System.Windows.Forms.ComboBox vech_comBox;
		private System.Windows.Forms.CheckBox dest_checkBox;
		private System.Windows.Forms.ComboBox dest_comBox;
		private System.Windows.Forms.Button cal_button;
		private System.Windows.Forms.Button ok_button;
	}
}