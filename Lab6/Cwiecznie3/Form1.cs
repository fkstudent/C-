namespace Cwiecznie3
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
            try
            {
                float x = float.Parse(textBox1.Text);
                textBoxWynik.Text = (x * x).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano bledne dane","Uwaga", MessageBoxButtons.OK);
            }
        }
    }
}