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
            string[] valuesString = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text };

            try
            {
                //Validera inmattade värde på dragningarna och antal dragningar
                int[] valuesInt = lotto_Handler.ValidateValues(valuesString, textBox8.Text);
                
                int[] result = lotto_Handler.Handle_lottery(valuesInt, int.Parse(textBox8.Text));

                //Vissa resultatet för användare
                textBox9.Text = result[0].ToString();
                textBox10.Text = result[1].ToString();
                textBox11.Text = result[2].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}