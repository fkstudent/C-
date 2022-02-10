namespace Zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 12);
            }
            else if (radioButton2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
            }
            else if (radioButton3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 24);
            }


            if (checkedListBox2.GetItemChecked(0))
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if(checkedListBox2.GetItemChecked(1)) textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            if(checkedListBox2.GetItemChecked(2)) textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);



            if (radioButton4.Checked) textBox1.ForeColor = Color.Red;
            else if (radioButton5.Checked) textBox1.ForeColor = Color.Blue;
            else if (radioButton6.Checked) textBox1.ForeColor = Color.Orange;









        }
    }
}