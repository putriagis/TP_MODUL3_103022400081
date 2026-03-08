namespace TP_MODUL3_103022400081
{
    public partial class Form1 : Form
    {
        int angka1 = 0;
        int angka2 = 0;
        bool tambah = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "1";
            else
                lblOutput.Text += "1";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "2";
            else
                lblOutput.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "3";
            else
                lblOutput.Text += "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "4";
            else
                lblOutput.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "5";
            else
                lblOutput.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "6";
            else
                lblOutput.Text += "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "7";
            else
                lblOutput.Text += "7";
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "8";
            else
                lblOutput.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "9";
            else
                lblOutput.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblOutput.Text, out angka1))
            {
                lblOutput.Text = "0";
                tambah = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "0";
            else
                lblOutput.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka2 = int.Parse(lblOutput.Text);

            if (tambah == true)
            {
                int hasil = angka1 + angka2;
                lblOutput.Text = hasil.ToString();
            }
        }
    }
}