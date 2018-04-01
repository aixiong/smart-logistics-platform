namespace smart_logistics_app
{
	partial class mapForm
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
			this.sizeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sizeButton
			// 
			this.sizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sizeButton.Location = new System.Drawing.Point(647, 12);
			this.sizeButton.Name = "sizeButton";
			this.sizeButton.Size = new System.Drawing.Size(64, 50);
			this.sizeButton.TabIndex = 0;
			this.sizeButton.Text = "button1";
			this.sizeButton.UseVisualStyleBackColor = true;
			this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
			// 
			// mapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 512);
			this.Controls.Add(this.sizeButton);
			this.Name = "mapForm";
			this.Text = "mapForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button sizeButton;
	}
}