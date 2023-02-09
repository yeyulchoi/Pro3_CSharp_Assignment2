using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace NotificationApp_Assign2
{
	
	public partial class Form2 : Form
	{
		
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}
		

		private void chckEmail_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void chckSMS_CheckedChanged(object sender, EventArgs e)
		{
			
		}
		public Email LoadEmail(Email emailObj)
		{
			string email = txtEmail.Text;
			emailObj = new Email(email);
			return emailObj;
		}
		public SMS LoadSMS(SMS smsObj)
		{
			string sms = txtSMS.Text;
			smsObj = new SMS(sms);
			return smsObj;
		}


		private void btnSubscribe_Click(object sender, EventArgs e)
		{
			Email objemail = new Email();
			Email createdEmail = LoadEmail(objemail);
			SMS objsms = new SMS();
			SMS createdSMS = LoadSMS(objsms);

			string displayEmail = createdEmail.ClientEmail;
			string displaySMS = createdSMS.Sms;

			Regex validateEmail = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
			bool isEmailValid = validateEmail.IsMatch(displayEmail);

			Regex validateSms = new Regex(@"^[0-9]{10}$");
			bool isSmsValid = validateSms.IsMatch(displaySMS);

			if ((chckEmail.Checked)&&(!chckSMS.Checked))
			{
				if (isEmailValid == true)
				{
					lbEmailFailMsg.Text = "valid email";
					if (listBox1.Items.Contains(displayEmail) == false)
					{
						listBox1.Items.Add(displayEmail);
						MessageBox.Show("Welcome new subscriber.");
					}else
					{
						lbEmailFailMsg.Text = "registered Email";
						MessageBox.Show("You are already a subscriber.");
					}
				}else
				{
					lbEmailFailMsg.Text ="inValid Email";
					MessageBox.Show("Please observe the email format.");
				}
				
			}
			

			if ((!chckEmail.Checked)&& (chckSMS.Checked))
			{
			
				if(isSmsValid == true)
				{					
					if (listBox2.Items.Contains(displaySMS) !=true)
					{
						lbSMSFailMsg.Text = "Valid Number";
						MessageBox.Show("New subscriber!!");
						listBox2.Items.Add(txtSMS.Text);
					}else
					{
						lbSMSFailMsg.Text = "registered Number";
						MessageBox.Show("Already registered phone number.");
					}
				}else
				{
					lbSMSFailMsg.Text = "Invalid Phone number";
					MessageBox.Show("Please use the phone number format '6479951444'.");

				}

			}
			

			if ((chckEmail.Checked) && (chckSMS.Checked))
			{
				if ((isEmailValid == false) && (isSmsValid == true))
				{
					lbEmailFailMsg.Text = "Invalid Email number";
					MessageBox.Show("Please enter the valid email");
				}
				if ((isEmailValid==true) && (isSmsValid == false))
				{
					lbSMSFailMsg.Text = "Invalid SMS number";
					MessageBox.Show("Please enter the valid phone number");
				}
				if((isEmailValid == false) && (isSmsValid == false))
				{
					lbEmailFailMsg.Text = "Invalid Email number";
					lbSMSFailMsg.Text = "Invalid SMS number";
					MessageBox.Show("Please enter the valid information");
				}
				if((isEmailValid == true) && (isSmsValid == true))
				{

					//lbEmailFailMsg.Text = "Valid Email";
					//lbSMSFailMsg.Text = "valid SMS number";
					if ((listBox1.Items.Contains(displayEmail) == true) && (listBox2.Items.Contains(displaySMS) == true))
					{
						MessageBox.Show("You are already a subscriber.");
					}
					if ((listBox1.Items.Contains(displayEmail) != true) && (listBox2.Items.Contains(displaySMS) !=true))
					{
						listBox1.Items.Add(displayEmail);
						listBox2.Items.Add(displaySMS);
						MessageBox.Show("NEW subscriber.");
					}
					if ((listBox1.Items.Contains(displayEmail) == true) && (listBox2.Items.Contains(displaySMS) != true))
					{						
						MessageBox.Show("You are already registered with an email .");
					}
					if ((listBox1.Items.Contains(displayEmail) == false) && (listBox2.Items.Contains(displaySMS) == true))
					{						
						MessageBox.Show("You are already registered with your phone number.");
					}
					

				}
			}
			//txtSMS.Text = "";
			////lbSMSFailMsg.Text = " ";
			//chckSMS.Checked = false;

			//lbEmailFailMsg.Text = " ";

			txtEmail.Text = "";
			lbEmailFailMsg.Text = "";
			chckEmail.Checked = false;

			txtSMS.Text = "";
			lbSMSFailMsg.Text = " ";
			chckSMS.Checked = false;





			//================================================================


			/*
						Email objemail = new Email();
						Email createdEmail =LoadEmail(objemail);
						SMS objsms = new SMS();
						SMS createdSMS = LoadSMS(objsms);

						string displayEmail = createdEmail.ClientEmail;
						string displaySMS =createdSMS.Sms;


					//Email associated


						Regex validateEmail = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
						bool IsEmailValid = validateEmail.IsMatch(displayEmail);
						if (IsEmailValid == false)
						{
							lbEmailFailMsg.Text = "Invalid Email number";

						}
						else
						{

							lbEmailFailMsg.Text = "Valid Email";

							if (listBox1.Items.Contains(displayEmail) == false)
							{
								listBox1.Items.Add(displayEmail);
								MessageBox.Show("Welcome new subscriber.");
							}
							else
							{
								MessageBox.Show("Already registered email.");
							}

						}

						//SMS associated

						////==============================
						Regex validateSms = new Regex(@"^[0-9]{10}$");
						bool isSmsValid = validateSms.IsMatch(displaySMS);
						if (isSmsValid==false)
						{
							lbSMSFailMsg.Text = "Invalid Phone number";

						}
						else
						{

							lbSMSFailMsg.Text = "Valid Number";

								if (listBox2.Items.Contains(displaySMS)==false)
								{
									listBox2.Items.Add(txtSMS.Text);
								}
								else
								{
									MessageBox.Show("Already registered phone number.");
								}
						}

						txtEmail.Text = "";
						lbEmailFailMsg.Text = " ";
						txtSMS.Text = "";
						lbSMSFailMsg.Text = " ";

					}
			*/

		}



	}
}

