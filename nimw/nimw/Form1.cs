namespace nimw
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cs = new Form2();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cs = new Form3();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 cs = new Form4();
            cs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 cs = new Form5();
            cs.Show();
        }
    }
}