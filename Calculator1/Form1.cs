namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string f�rstaTal = "";
            string andraTal = "";
            string r�knes�tt = "";
            bool f�rstaKlar = false;

            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (!f�rstaKlar)
                {
                    switch (textBox1.Text[i])
                    {
                        case '+':
                            f�rstaKlar = true;
                            r�knes�tt = "+";
                            break;
                        case '-':
                            f�rstaKlar = true;
                            r�knes�tt = "-";
                            break;
                        case '*':
                            f�rstaKlar = true;
                            r�knes�tt = "*";
                            break;
                        case '/':
                            f�rstaKlar = true;
                            r�knes�tt = "/";
                            break;
                        default:
                            f�rstaTal += textBox1.Text[i].ToString();
                            break;
                    }
                }
                else
                {
                    andraTal += textBox1.Text[i].ToString();
                }
            }

            int y; 
            int.TryParse(f�rstaTal, out y);
            int x = int.Parse(andraTal);

            int resultat =0 ;

            switch (r�knes�tt)
            {
                case "+":
                    resultat = y + x;
                    break;
                case "-":
                    resultat = y - x;
                    break;
                case "*":
                    resultat = y * x;
                    break;
                case "/":
                    if (x != 0)
                        resultat = y / x;
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            textBox1.Text = resultat.ToString();
        }
    }
}
