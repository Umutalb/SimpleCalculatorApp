    namespace SimpleCalculatorApp
    {
    public partial class Form1 : Form
    {

        double firstValue = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Clear();

            txtDisplay.Text += btn.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstValue = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            txtDisplay.Clear();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;

                case "-":
                    result = firstValue - secondValue;
                    break;

                case "x":
                    result = firstValue * secondValue;
                    break;

                case "/":
                    if (secondValue == 0)
                    {
                        txtDisplay.Text = "Hata";
                        return;
                    }
                    result = firstValue / secondValue;
                    break;
            }

            txtDisplay.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstValue = 0;
            operation = "";
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
                txtDisplay.Text += ",";
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            value = -value;
            txtDisplay.Text = value.ToString();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3,14";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCredit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Umutalb",
                UseShellExecute = true
            });
        }
    }
}
