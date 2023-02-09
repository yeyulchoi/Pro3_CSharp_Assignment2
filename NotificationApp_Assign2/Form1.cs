namespace NotificationApp_Assign2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnManageSub_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 ftwo = new Form2();
			ftwo.Show();
		}
	}
}