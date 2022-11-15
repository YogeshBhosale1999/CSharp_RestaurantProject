namespace PointOfSalesRestaurant
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongTimeString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Datelbl.Text = DateTime.Now.ToLongDateString();
			timer1.Start();
		}
	}
}