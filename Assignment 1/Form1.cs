namespace Assignment_1
{
    public partial class Form1 : Form
    {
        private int door_posiiton = 5;
        private int position_left = 0;
        private int position_right = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!timer_left.Enabled)
            {
                timer_left.Start();
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer_left_Tick(object sender, EventArgs e)
        {
            if (position_left < 80)
            {
                pictureBox2.Left -= door_posiiton;
                position_left += door_posiiton;
            }
            else
            {
                timer_left.Stop();
            }
        }
    }
}