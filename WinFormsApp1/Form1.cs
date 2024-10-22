namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                timer1.Stop();

                if (point > pointpc)
                {
                    label3.Text = "You win¡I";
                }
                else if (point < pointpc)
                {
                    label3.Text = "Computer win¡I";
                }
                else
                {
                    label3.Text = "Draw";
                }
            }
        }
    }
}