namespace NotificationApp_Assign2
{
	partial class Form3
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
			this.txtNoticeContent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit2 = new System.Windows.Forms.Button();
			this.btnPublish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNoticeContent
			// 
			this.txtNoticeContent.Location = new System.Drawing.Point(336, 151);
			this.txtNoticeContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtNoticeContent.Name = "txtNoticeContent";
			this.txtNoticeContent.Size = new System.Drawing.Size(341, 27);
			this.txtNoticeContent.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(59, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Notification Content";
			// 
			// btnExit2
			// 
			this.btnExit2.BackColor = System.Drawing.Color.IndianRed;
			this.btnExit2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit2.Location = new System.Drawing.Point(424, 263);
			this.btnExit2.Name = "btnExit2";
			this.btnExit2.Size = new System.Drawing.Size(222, 76);
			this.btnExit2.TabIndex = 9;
			this.btnExit2.Text = "Exit";
			this.btnExit2.UseVisualStyleBackColor = false;
			// 
			// btnPublish
			// 
			this.btnPublish.BackColor = System.Drawing.Color.IndianRed;
			this.btnPublish.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPublish.Location = new System.Drawing.Point(160, 263);
			this.btnPublish.Name = "btnPublish";
			this.btnPublish.Size = new System.Drawing.Size(222, 76);
			this.btnPublish.TabIndex = 8;
			this.btnPublish.Text = "Publish ";
			this.btnPublish.UseVisualStyleBackColor = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit2);
			this.Controls.Add(this.btnPublish);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNoticeContent);
			this.Name = "Form3";
			this.Text = "Publish Notification";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtNoticeContent;
		private Label label1;
		private Button btnExit2;
		private Button btnPublish;
	}
}