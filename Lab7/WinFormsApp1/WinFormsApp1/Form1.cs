namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked) {
                if (checkedListBox1.GetItemChecked(0) )
                {
                    var wynik = int.Parse(textBox1.Text) - 100;
                    label3.Text = wynik.ToString();
                }
                else if (checkedListBox1.GetItemChecked(1))
                {
                    var wynik = (int.Parse(textBox1.Text) - 100)*0.85;
                    label3.Text = wynik.ToString();
                }
                return;
            }

            if (radioButton2.Checked)
            {
                if (checkedListBox1.GetItemChecked(0))
                {
                    var wynik = int.Parse(textBox1.Text) - 100;
                    label3.Text = wynik.ToString();
                }
                else if (checkedListBox1.GetItemChecked(1))
                {
                    var wynik = (int.Parse(textBox1.Text) - 100) * 0.9;
                    label3.Text = wynik.ToString();
                }
                return;
            }

        }
    }
}