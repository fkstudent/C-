namespace Cwiczenie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                float x = float.Parse(textBox1.Text);

                float y = float.Parse(textBox2.Text);

                float z = float.Parse(textBox3.Text);

                float wynik = x + y + z;

                textBox4.Text = wynik.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Blad"," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                throw;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                float x = float.Parse(textBox1.Text);

                float y = float.Parse(textBox2.Text);

                float z = float.Parse(textBox3.Text);

                float wynik = x * y * z;

                textBox4.Text = wynik.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Blad", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}