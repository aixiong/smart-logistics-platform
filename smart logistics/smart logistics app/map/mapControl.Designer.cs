namespace smart_logistics_app.map
{
	partial class mapControl
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
			this.components = new System.ComponentModel.Container();
			this.cacelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.addrButton = new System.Windows.Forms.Button();
			this.addrText = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.图标显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.掠过时显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.始终显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.始终隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cacelButton
			// 
			this.cacelButton.BackColor = System.Drawing.Color.Transparent;
			this.cacelButton.BackgroundImage = global::smart_logistics_app.Properties.Resources.cancel;
			this.cacelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cacelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cacelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cacelButton.ForeColor = System.Drawing.Color.Transparent;
			this.cacelButton.Location = new System.Drawing.Point(593, 12);
			this.cacelButton.Name = "cacelButton";
			this.cacelButton.Size = new System.Drawing.Size(66, 49);
			this.cacelButton.TabIndex = 8;
			this.cacelButton.UseVisualStyleBackColor = false;
			this.cacelButton.Click += new System.EventHandler(this.cacelButton_Click);
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.Transparent;
			this.okButton.BackgroundImage = global::smart_logistics_app.Properties.Resources.ok;
			this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.okButton.Location = new System.Drawing.Point(524, 13);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(66, 49);
			this.okButton.TabIndex = 7;
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// addrButton
			// 
			this.addrButton.BackgroundImage = global::smart_logistics_app.Properties.Resources.searche;
			this.addrButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.addrButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addrButton.FlatAppearance.BorderSize = 0;
			this.addrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addrButton.Location = new System.Drawing.Point(439, 13);
			this.addrButton.Name = "addrButton";
			this.addrButton.Size = new System.Drawing.Size(70, 49);
			this.addrButton.TabIndex = 6;
			this.addrButton.UseVisualStyleBackColor = true;
			this.addrButton.Click += new System.EventHandler(this.addrButton_Click);
			// 
			// addrText
			// 
			this.addrText.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addrText.Location = new System.Drawing.Point(8, 13);
			this.addrText.Multiline = true;
			this.addrText.Name = "addrText";
			this.addrText.Size = new System.Drawing.Size(425, 62);
			this.addrText.TabIndex = 5;
			
			// mapControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 450);
			this.Controls.Add(this.cacelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.addrButton);
			this.Controls.Add(this.addrText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "mapControl";
			this.Text = "mapControl";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cacelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button addrButton;
		private System.Windows.Forms.TextBox addrText;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 图标显示ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 掠过时显示ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 始终显示ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 始终隐藏ToolStripMenuItem;
	}
}