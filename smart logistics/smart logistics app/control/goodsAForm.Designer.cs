namespace smart_logistics_app.control
{
	partial class goodsAForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.source_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.arrive_time = new System.Windows.Forms.DateTimePicker();
			this.dead_time = new System.Windows.Forms.DateTimePicker();
			this.finish_time = new System.Windows.Forms.DateTimePicker();
			this.dest_comBox = new System.Windows.Forms.ComboBox();
			this.status_comBox = new System.Windows.Forms.ComboBox();
			this.vech_textBox = new System.Windows.Forms.TextBox();
			this.cal_button = new System.Windows.Forms.Button();
			this.ok_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// number_textBox
			// 
			this.number_textBox.Location = new System.Drawing.Point(111, 14);
			this.number_textBox.Name = "number_textBox";
			this.number_textBox.Size = new System.Drawing.Size(221, 25);
			this.number_textBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(7, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "货物编号";
			// 
			// source_textBox
			// 
			this.source_textBox.Location = new System.Drawing.Point(111, 59);
			this.source_textBox.Name = "source_textBox";
			this.source_textBox.Size = new System.Drawing.Size(221, 25);
			this.source_textBox.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(7, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "货物来源地";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(7, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "货物目的地";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(7, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "到达时间";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(417, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "配送期限";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(417, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "配送状态";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(417, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "承运车辆编号";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(417, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 15);
			this.label8.TabIndex = 15;
			this.label8.Text = "送达时间";
			// 
			// arrive_time
			// 
			this.arrive_time.CustomFormat = "yyyy-MM-dd";
			this.arrive_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.arrive_time.Location = new System.Drawing.Point(111, 149);
			this.arrive_time.Name = "arrive_time";
			this.arrive_time.Size = new System.Drawing.Size(221, 25);
			this.arrive_time.TabIndex = 16;
			// 
			// dead_time
			// 
			this.dead_time.CustomFormat = "yyyy-MM-dd";
			this.dead_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dead_time.Location = new System.Drawing.Point(544, 14);
			this.dead_time.Name = "dead_time";
			this.dead_time.Size = new System.Drawing.Size(221, 25);
			this.dead_time.TabIndex = 17;
			// 
			// finish_time
			// 
			this.finish_time.CustomFormat = "yyyy-MM-dd";
			this.finish_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.finish_time.Location = new System.Drawing.Point(544, 147);
			this.finish_time.Name = "finish_time";
			this.finish_time.Size = new System.Drawing.Size(221, 25);
			this.finish_time.TabIndex = 18;
			// 
			// dest_comBox
			// 
			this.dest_comBox.FormattingEnabled = true;
			this.dest_comBox.Location = new System.Drawing.Point(111, 109);
			this.dest_comBox.Name = "dest_comBox";
			this.dest_comBox.Size = new System.Drawing.Size(220, 23);
			this.dest_comBox.TabIndex = 19;
			// 
			// status_comBox
			// 
			this.status_comBox.FormattingEnabled = true;
			this.status_comBox.Location = new System.Drawing.Point(544, 65);
			this.status_comBox.Name = "status_comBox";
			this.status_comBox.Size = new System.Drawing.Size(220, 23);
			this.status_comBox.TabIndex = 20;
			// 
			// vech_textBox
			// 
			this.vech_textBox.Location = new System.Drawing.Point(544, 106);
			this.vech_textBox.Name = "vech_textBox";
			this.vech_textBox.Size = new System.Drawing.Size(219, 25);
			this.vech_textBox.TabIndex = 21;
			// 
			// cal_button
			// 
			this.cal_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.cancel;
			this.cal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cal_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cal_button.Location = new System.Drawing.Point(710, 211);
			this.cal_button.Name = "cal_button";
			this.cal_button.Size = new System.Drawing.Size(49, 39);
			this.cal_button.TabIndex = 23;
			this.cal_button.UseVisualStyleBackColor = true;
			this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
			// 
			// ok_button
			// 
			this.ok_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.ok;
			this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok_button.Location = new System.Drawing.Point(641, 211);
			this.ok_button.Name = "ok_button";
			this.ok_button.Size = new System.Drawing.Size(49, 39);
			this.ok_button.TabIndex = 22;
			this.ok_button.UseVisualStyleBackColor = true;
			this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::smart_logistics_app.Properties.Resources.edit;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(354, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(27, 23);
			this.button1.TabIndex = 24;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// goodsAForm
			// 
			this.ClientSize = new System.Drawing.Size(815, 258);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cal_button);
			this.Controls.Add(this.ok_button);
			this.Controls.Add(this.vech_textBox);
			this.Controls.Add(this.status_comBox);
			this.Controls.Add(this.dest_comBox);
			this.Controls.Add(this.finish_time);
			this.Controls.Add(this.dead_time);
			this.Controls.Add(this.arrive_time);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.source_textBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.number_textBox);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "goodsAForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox number_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox source_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker arrive_time;
		private System.Windows.Forms.DateTimePicker dead_time;
		private System.Windows.Forms.DateTimePicker finish_time;
		private System.Windows.Forms.ComboBox dest_comBox;
		private System.Windows.Forms.ComboBox status_comBox;
		private System.Windows.Forms.TextBox vech_textBox;
		private System.Windows.Forms.Button cal_button;
		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Button button1;
	}
}
