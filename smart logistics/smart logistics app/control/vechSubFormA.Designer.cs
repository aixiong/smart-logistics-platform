namespace smart_logistics_app.control
{
	partial class vechSubFormA
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
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.vol_textBox = new System.Windows.Forms.TextBox();
			this.jour_textBox = new System.Windows.Forms.TextBox();
			this.cal_button = new System.Windows.Forms.Button();
			this.ok_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "车型名称";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(10, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "配送容积";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(10, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "续航路程";
			// 
			// name_textBox
			// 
			this.name_textBox.Location = new System.Drawing.Point(98, 5);
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(221, 25);
			this.name_textBox.TabIndex = 3;
			// 
			// vol_textBox
			// 
			this.vol_textBox.Location = new System.Drawing.Point(98, 64);
			this.vol_textBox.Name = "vol_textBox";
			this.vol_textBox.Size = new System.Drawing.Size(221, 25);
			this.vol_textBox.TabIndex = 4;
			// 
			// jour_textBox
			// 
			this.jour_textBox.Location = new System.Drawing.Point(98, 122);
			this.jour_textBox.Name = "jour_textBox";
			this.jour_textBox.Size = new System.Drawing.Size(221, 25);
			this.jour_textBox.TabIndex = 5;
			// 
			// cal_button
			// 
			this.cal_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.cancel;
			this.cal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cal_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cal_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cal_button.Location = new System.Drawing.Point(429, 113);
			this.cal_button.Name = "cal_button";
			this.cal_button.Size = new System.Drawing.Size(49, 39);
			this.cal_button.TabIndex = 7;
			this.cal_button.UseVisualStyleBackColor = true;
			this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
			// 
			// ok_button
			// 
			this.ok_button.BackgroundImage = global::smart_logistics_app.Properties.Resources.ok;
			this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ok_button.Location = new System.Drawing.Point(360, 113);
			this.ok_button.Name = "ok_button";
			this.ok_button.Size = new System.Drawing.Size(49, 39);
			this.ok_button.TabIndex = 6;
			this.ok_button.UseVisualStyleBackColor = true;
			this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
			// 
			// vechSubFormA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 158);
			this.Controls.Add(this.cal_button);
			this.Controls.Add(this.ok_button);
			this.Controls.Add(this.jour_textBox);
			this.Controls.Add(this.vol_textBox);
			this.Controls.Add(this.name_textBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "vechSubFormA";
			this.Text = "vechSubForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.TextBox vol_textBox;
		private System.Windows.Forms.TextBox jour_textBox;
		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Button cal_button;
	}
}