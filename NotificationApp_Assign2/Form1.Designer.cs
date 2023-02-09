namespace NotificationApp_Assign2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnManageSub = new System.Windows.Forms.Button();
			this.btnPublishNotice = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnManageSub
			// 
			this.btnManageSub.BackColor = System.Drawing.Color.IndianRed;
			this.btnManageSub.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnManageSub.Location = new System.Drawing.Point(33, 159);
			this.btnManageSub.Name = "btnManageSub";
			this.btnManageSub.Size = new System.Drawing.Size(222, 76);
			this.btnManageSub.TabIndex = 0;
			this.btnManageSub.Text = "Manage Subscription";
			this.btnManageSub.UseVisualStyleBackColor = false;
			this.btnManageSub.Click += new System.EventHandler(this.btnManageSub_Click);
			// 
			// btnPublishNotice
			// 
			this.btnPublishNotice.BackColor = System.Drawing.Color.IndianRed;
			this.btnPublishNotice.Enabled = false;
			this.btnPublishNotice.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPublishNotice.Location = new System.Drawing.Point(291, 159);
			this.btnPublishNotice.Name = "btnPublishNotice";
			this.btnPublishNotice.Size = new System.Drawing.Size(222, 76);
			this.btnPublishNotice.TabIndex = 1;
			this.btnPublishNotice.Text = "Publish Notification";
			this.btnPublishNotice.UseVisualStyleBackColor = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.IndianRed;
			this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(555, 159);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(222, 76);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnPublishNotice);
			this.Controls.Add(this.btnManageSub);
			this.Name = "Form1";
			this.Text = "Notification Manager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnManageSub;
		private Button btnPublishNotice;
		private Button btnExit;
	}
}