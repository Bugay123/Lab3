namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                label7.Visible = true;
                label7.Text = "Please fill in all the fields";
                return;
            }
            else if (!IsNumeric(textBox4.Text))
            {
                label7.Text = "Only number in course";
                label7.Visible = true;
                return;
            }
            else
            {
                label7.Visible = false;
            }

            textBox6.Text =
                textBox1.Text + Environment.NewLine +
                textBox2.Text + Environment.NewLine +
                numericUpDown1.Value + "/" + comboBox1.Text + "/" + comboBox2.Text + Environment.NewLine +
                sex() + Environment.NewLine +
                textBox4.Text + Environment.NewLine +
                textBox5.Text;
        }

        private string sex() {             
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else
            {
                return radioButton2.Text;
            }
        }
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
                }
    }
}
