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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.send_comBox = new System.Windows.Forms.ComboBox();
			this.recv_comBox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 26);
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
			this.send_comBox.DropDownHeight = 500;
			this.send_comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.send_comBox.FormattingEnabled = true;
			this.send_comBox.IntegralHeight = false;
			this.send_comBox.Location = new System.Drawing.Point(44, 47);
			this.send_comBox.Margin = new System.Windows.Forms.Padding(2);
			this.send_comBox.Name = "send_comBox";
			this.send_comBox.Size = new System.Drawing.Size(506, 26);
			this.send_comBox.TabIndex = 2;
			// 
			// recv_comBox
			// 
			this.recv_comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.recv_comBox.FormattingEnabled = true;
			this.recv_comBox.Location = new System.Drawing.Point(44, 111);
			this.recv_comBox.Margin = new System.Windows.Forms.Padding(2);
			this.recv_comBox.Name = "recv_comBox";
			this.recv_comBox.Size = new System.Drawing.Size(506, 26);
			this.recv_comBox.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(578, 46);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(36, 26);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(639, 46);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(36, 26);
			this.button2.TabIndex = 5;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(700, 46);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(36, 26);
			this.button3.TabIndex = 6;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(578, 111);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(36, 26);
			this.button4.TabIndex = 7;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(639, 111);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(36, 26);
			this.button5.TabIndex = 8;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(700, 111);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(36, 26);
			this.button6.TabIndex = 9;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// addrForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 643);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.recv_comBox);
			this.Controls.Add(this.send_comBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "addrForm";
			this.Text = "地址管理";
			this.Resize += new System.EventHandler(this.addrForm_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox send_comBox;
		private System.Windows.Forms.ComboBox recv_comBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
	}
}

