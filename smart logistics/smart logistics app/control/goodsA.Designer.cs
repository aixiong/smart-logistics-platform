namespace smart_logistics_app.control
{
	partial class goodsA
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
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// name_textBox
			// 
			this.name_textBox.Location = new System.Drawing.Point(95, 14);
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(221, 25);
			this.name_textBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(7, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "车型名称";
			// 
			// goodsA
			// 
			this.ClientSize = new System.Drawing.Size(815, 284);
			this.Controls.Add(this.name_textBox);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "goodsA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.Label label2;
	}
}
