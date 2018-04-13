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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapForm));
			this.addrText = new System.Windows.Forms.TextBox();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.cacelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.addrButton = new System.Windows.Forms.Button();
			this.sizeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addrText
			// 
			this.addrText.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addrText.Location = new System.Drawing.Point(12, 6);
			this.addrText.Multiline = true;
			this.addrText.Name = "addrText";
			this.addrText.Size = new System.Drawing.Size(425, 47);
			this.addrText.TabIndex = 1;
			// 
			// images
			// 
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			this.images.Images.SetKeyName(0, "magnify.png");
			this.images.Images.SetKeyName(1, "zoom.jpg");
			// 
			// cacelButton
			// 
			this.cacelButton.BackColor = System.Drawing.Color.Transparent;
			this.cacelButton.BackgroundImage = global::smart_logistics_app.Properties.Resources.cancel;
			this.cacelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cacelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cacelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cacelButton.ForeColor = System.Drawing.Color.Transparent;
			this.cacelButton.Location = new System.Drawing.Point(597, 5);
			this.cacelButton.Name = "cacelButton";
			this.cacelButton.Size = new System.Drawing.Size(66, 49);
			this.cacelButton.TabIndex = 4;
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
			this.okButton.Location = new System.Drawing.Point(528, 6);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(66, 49);
			this.okButton.TabIndex = 3;
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
			this.addrButton.Location = new System.Drawing.Point(456, 4);
			this.addrButton.Name = "addrButton";
			this.addrButton.Size = new System.Drawing.Size(70, 49);
			this.addrButton.TabIndex = 2;
			this.addrButton.UseVisualStyleBackColor = true;
			this.addrButton.Click += new System.EventHandler(this.addrButton_Click);
			// 
			// sizeButton
			// 
			this.sizeButton.BackColor = System.Drawing.Color.Transparent;
			this.sizeButton.BackgroundImage = global::smart_logistics_app.Properties.Resources.magnify;
			this.sizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.sizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sizeButton.FlatAppearance.BorderSize = 0;
			this.sizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sizeButton.ForeColor = System.Drawing.Color.Transparent;
			this.sizeButton.Location = new System.Drawing.Point(831, 6);
			this.sizeButton.Margin = new System.Windows.Forms.Padding(4);
			this.sizeButton.Name = "sizeButton";
			this.sizeButton.Size = new System.Drawing.Size(60, 47);
			this.sizeButton.TabIndex = 0;
			this.sizeButton.UseVisualStyleBackColor = false;
			this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
			// 
			// mapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 614);
			this.Controls.Add(this.cacelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.addrButton);
			this.Controls.Add(this.addrText);
			this.Controls.Add(this.sizeButton);
			this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "mapForm";
			this.Text = "mapForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mapForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button sizeButton;
		private System.Windows.Forms.TextBox addrText;
		private System.Windows.Forms.Button addrButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cacelButton;
		private System.Windows.Forms.ImageList images;
	}
}