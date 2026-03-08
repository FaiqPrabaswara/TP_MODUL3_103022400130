using System.Reflection.Emit;

namespace TP_MODUL3_103022400130
{
    public partial class Form1 : Form
    {
        // VARIABLE KALKULATOR
        double total = 0;
        string operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // TOMBOL ANGKA
        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lblOutput.Text == "0" || operationPressed)
                lblOutput.Text = "";

            operationPressed = false;
            lblOutput.Text = lblOutput.Text + btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lblOutput.Text == "0" || operationPressed)
                lblOutput.Text = "";

            operationPressed = false;
            lblOutput.Text = lblOutput.Text + btn.Text;
        }

        // TOMBOL +
        private void button12_Click(object sender, EventArgs e)
        {
            total += Double.Parse(lblOutput.Text);
            operation = "+";
            operationPressed = true;
        }

        // TOMBOL =
        private void button11_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                total += Double.Parse(lblOutput.Text);
                lblOutput.Text = total.ToString();
                total = 0;
            }
        }
    }
}
