namespace NotificationApp_Assign2
{
	partial class Form2
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSMS = new System.Windows.Forms.TextBox();
			this.lbEmailFailMsg = new System.Windows.Forms.Label();
			this.lbSMSFailMsg = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUnsubscribe = new System.Windows.Forms.Button();
			this.btnSubscribe = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.chckEmail = new System.Windows.Forms.CheckBox();
			this.chckSMS = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(534, 78);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(477, 27);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.Text = "";
		//	this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			// 
			// txtSMS
			// 
			this.txtSMS.Location = new System.Drawing.Point(534, 158);
			this.txtSMS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtSMS.Name = "txtSMS";
			this.txtSMS.Size = new System.Drawing.Size(477, 27);
			this.txtSMS.TabIndex = 3;
			// 
			// lbEmailFailMsg
			// 
			this.lbEmailFailMsg.AutoSize = true;
			this.lbEmailFailMsg.ForeColor = System.Drawing.Color.Red;
			this.lbEmailFailMsg.Location = new System.Drawing.Point(718, 108);
			this.lbEmailFailMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbEmailFailMsg.Name = "lbEmailFailMsg";
			this.lbEmailFailMsg.Size = new System.Drawing.Size(21, 20);
			this.lbEmailFailMsg.TabIndex = 4;
			this.lbEmailFailMsg.Text = "--";
			// 
			// lbSMSFailMsg
			// 
			this.lbSMSFailMsg.AutoSize = true;
			this.lbSMSFailMsg.ForeColor = System.Drawing.Color.Red;
			this.lbSMSFailMsg.Location = new System.Drawing.Point(718, 199);
			this.lbSMSFailMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSMSFailMsg.Name = "lbSMSFailMsg";
			this.lbSMSFailMsg.Size = new System.Drawing.Size(21, 20);
			this.lbSMSFailMsg.TabIndex = 5;
			this.lbSMSFailMsg.Text = "--";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
			this.btnCancel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCancel.Location = new System.Drawing.Point(660, 303);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(222, 76);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnUnsubscribe
			// 
			this.btnUnsubscribe.BackColor = System.Drawing.Color.IndianRed;
			this.btnUnsubscribe.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUnsubscribe.Location = new System.Drawing.Point(396, 303);
			this.btnUnsubscribe.Name = "btnUnsubscribe";
			this.btnUnsubscribe.Size = new System.Drawing.Size(222, 76);
			this.btnUnsubscribe.TabIndex = 7;
			this.btnUnsubscribe.Text = "Unsubscribe";
			this.btnUnsubscribe.UseVisualStyleBackColor = false;
		//	this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
			// 
			// btnSubscribe
			// 
			this.btnSubscribe.BackColor = System.Drawing.Color.IndianRed;
			this.btnSubscribe.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSubscribe.Location = new System.Drawing.Point(138, 303);
			this.btnSubscribe.Name = "btnSubscribe";
			this.btnSubscribe.Size = new System.Drawing.Size(222, 76);
			this.btnSubscribe.TabIndex = 6;
			this.btnSubscribe.Text = "Subscribe";
			this.btnSubscribe.UseVisualStyleBackColor = false;
			this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(54, 404);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(414, 264);
			this.listBox1.TabIndex = 10;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Location = new System.Drawing.Point(512, 404);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(414, 264);
			this.listBox2.TabIndex = 11;
		//	this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// chckEmail
			// 
			this.chckEmail.AutoSize = true;
			this.chckEmail.Location = new System.Drawing.Point(68, 81);
			this.chckEmail.Name = "chckEmail";
			this.chckEmail.Size = new System.Drawing.Size(263, 24);
			this.chckEmail.TabIndex = 14;
			this.chckEmail.Text = "Notification sent by Email";
			this.chckEmail.UseVisualStyleBackColor = true;
			// 
			// chckSMS
			// 
			this.chckSMS.AutoSize = true;
			this.chckSMS.Location = new System.Drawing.Point(68, 158);
			this.chckSMS.Name = "chckSMS";
			this.chckSMS.Size = new System.Drawing.Size(251, 24);
			this.chckSMS.TabIndex = 15;
			this.chckSMS.Text = "Notification sent by SMS";
			this.chckSMS.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1099, 721);
			this.Controls.Add(this.chckSMS);
			this.Controls.Add(this.chckEmail);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUnsubscribe);
			this.Controls.Add(this.btnSubscribe);
			this.Controls.Add(this.lbEmailFailMsg);
			this.Controls.Add(this.lbSMSFailMsg);
			this.Controls.Add(this.txtSMS);
			this.Controls.Add(this.txtEmail);
			this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form2";
			this.Text = "Manage Subscription";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private TextBox txtEmail;
		private TextBox txtSMS;
		private Label lbEmailFailMsg;
		private Label lbSMSFailMsg;
		private Button btnCancel;
		private Button btnUnsubscribe;
		private Button btnSubscribe;
		//private DataGridView dataGridViewSMS;
		private ListBox listBox1;
		private ListBox listBox2;
		private CheckBox chckEmail;
		private CheckBox chckSMS;
	}
}