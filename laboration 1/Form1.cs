namespace laboration_1
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Lotto_handler lotto_Handler = new Lotto_handler();
            try
            {
                int[] values = { int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text) };
                if (lotto_Handler.CheckValues(values))
                {
                    int numberOfDraws = int.Parse(textBox8.Text);
                    int[] result = lotto_Handler.Handle_lottery(values, 999999);
                    textBox9.Text = result[0].ToString();
                    textBox10.Text = result[1].ToString();
                    textBox11.Text = result[2].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid inputs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your lottery inputs should be numbers");
            }
            
            
        }
    }
}