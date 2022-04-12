using System.Globalization;

namespace lab1
{
    public partial class Form1 : Form
    {
        ICalculator calculator = new Calculator();
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(firstDigitTextBox.Text.Equals("") || secondDigitTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                resultTextBox.Text = calculator.Summ(int.Parse(firstDigitTextBox.Text), int.Parse(secondDigitTextBox.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstDigitTextBox.Text.Equals("") || secondDigitTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                if (int.Parse(secondDigitTextBox.Text) == 0)
                    throw new DivideByZeroException();
                resultTextBox.Text = calculator.Divide(int.Parse(firstDigitTextBox.Text), int.Parse(secondDigitTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstDigitTextBox.Text.Equals("") || secondDigitTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                resultTextBox.Text = calculator.Subtr(int.Parse(firstDigitTextBox.Text), int.Parse(secondDigitTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstDigitTextBox.Text.Equals("") || secondDigitTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                resultTextBox.Text = calculator.Multiply(int.Parse(firstDigitTextBox.Text), int.Parse(secondDigitTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.secondDigitTextBox.TextChanged += new System.EventHandler(this.secondDigitTextBox_TextChanged);
                if (firstDigitTextBox.Text.Equals("") || secondDigitTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                if (int.Parse(secondDigitTextBox.Text) == 0)
                    throw new DivideByZeroException();
                resultTextBox.Text = calculator.Division(int.Parse(firstDigitTextBox.Text), int.Parse(secondDigitTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstDigitTextBox.Text.Equals("") || secondDigitTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                if (int.Parse(secondDigitTextBox.Text) == 0)
                    throw new DivideByZeroException();
                resultTextBox.Text = calculator.Module(int.Parse(firstDigitTextBox.Text), int.Parse(secondDigitTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            secondDigitTextBox.Clear();
            firstDigitTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultTextBox.Text.Equals(""))
                    throw new FormatException("Argument missing");
                if (resultTextBox.Text.Contains(","))
                    throw new FormatException("Digits shoud be devided by '.'");
                calculator.GetResult(double.Parse(resultTextBox.Text, formatter));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                secondDigitTextBox.Text = calculator.SetResult().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void secondDigitTextBox_TextChanged(object sender, EventArgs e)
        {
            if(secondDigitTextBox.Text != "0")
            {
                secondDigitTextBox.BackColor = Color.White;
            }
            else if (int.Parse(secondDigitTextBox.Text) == 0)
                secondDigitTextBox.BackColor = Color.Red;
        }
    }
}