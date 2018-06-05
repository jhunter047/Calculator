using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float number, answer;
        int count; 

        public Form1()
        {
            InitializeComponent();
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = ""; 
        }

        public void Calculate()
        {
            switch (count)
            {
                case 1: 
                    answer = number + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 2:
                    answer = number - float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 3:
                    answer = number * float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                case 4:
                    answer = number / float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                default:
                    break; 
            }
        }

        //"." button 
        private void DotBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red; 
        }

        //
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = number.ToString() + "+";
        }

        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = number.ToString() + "-";
        }

        private void TimesBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = number.ToString() + "X";
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = number.ToString() + "/ ";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void BackSpaceBtn_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i]; 
        }
    }
}
