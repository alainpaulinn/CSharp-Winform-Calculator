using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Alain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        bool onceForPoint = false;
        double a, b, c;
        char operation;
        bool inOperation = false;
        private void btn0_Click(object sender, EventArgs e)//000000000000000000000000
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "0";
                    break;
                case true:
                    label3.Text += "0";
                    break;
            }
        }
        private void btn1_Click(object sender, EventArgs e)//1111111111111111111111111111111111111
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "1";
                    break;
                case true:
                    label3.Text += "1";
                    break;
            }
        }
        private void btn2_Click(object sender, EventArgs e)//222222222222222222222222222222222222222
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "2";
                    break;
                case true:
                    label3.Text += "2";
                    break;
            }
        }
        private void btn3_Click(object sender, EventArgs e)//3333333333333333333333333333333333
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "3";
                    break;
                case true:
                    label3.Text += "3";
                    break;
            }
        }
        private void btn4_Click(object sender, EventArgs e)//44444444444444444444444444444
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "4";
                    break;
                case true:
                    label3.Text += "4";
                    break;
            }
        }
        private void btn5_Click(object sender, EventArgs e)//55555555555555555555555555555555555
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "5";
                    break;
                case true:
                    label3.Text += "5";
                    break;
            }
        }
        private void btn6_Click(object sender, EventArgs e)//6666666666666666666666666666
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "6";
                    break;
                case true:
                    label3.Text += "6";
                    break;
            }
        }
        private void btn7_Click(object sender, EventArgs e)//77777777777777777777777777
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "7";
                    break;
                case true:
                    label3.Text += "7";
                    break;
            }
        }
        private void btn8_Click(object sender, EventArgs e)//888888888888888888888
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "8";
                    break;
                case true:
                    label3.Text += "8";
                    break;
            }
        }
        private void btn9_Click(object sender, EventArgs e)//99999999999999999999999999999999999999999999
        {
            switch (inOperation)
            {
                case false:
                    label1.Text += "9";
                    break;
                case true:
                    label3.Text += "9";
                    break;
            }
        }
        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                if (inOperation == false)
                {
                    a = Convert.ToDouble(label1.Text);
                    label3.Text += $"x{label1.Text}";
                    inOperation = true;
                    label2.Text = Convert.ToString(a * a);
                }
                else { }
            }
            else { }
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (inOperation == false)
            {
                switch (onceForPoint)
                {
                    case false:
                        if (label1.Text == "")
                        {
                            label1.Text += "0.";
                            onceForPoint = true;
                        }
                        else
                        {
                            label1.Text += ".";
                            onceForPoint = true;
                        }
                        break;
                    case true:
                        break;
                }
            }
            
            else if(inOperation==true)
            {
                switch (onceForPoint)
                {
                    case false:
                        if (label3.Text == "")
                        {
                            label3.Text += "0.";
                            onceForPoint = true;
                        }
                        else
                        {
                            label3.Text += ".";
                            onceForPoint = true;
                        }
                        break;
                    case true:
                        break;
                }
            }
        }
        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (inOperation == false)
            {
                a = Convert.ToDouble(label1.Text);
                label3.Text += "x";
                operation = 'x';
                inOperation = true;
                onceForPoint = false;
            }
            else { }
        }
       private void btnDivide_Click(object sender, EventArgs e)
       {
           if (inOperation == false)
           {
               a = Convert.ToDouble(label1.Text);
               label3.Text += "÷";
               operation = '÷';
               inOperation = true;
               onceForPoint = false;
           }
            else { }
       }
       private void btnMinus_Click(object sender, EventArgs e)
       {
           if (inOperation == false)
           {
               a = Convert.ToDouble(label1.Text);
               label3.Text += "-";
               operation = '-';
               inOperation = true;
               onceForPoint = false;
           }
            else { }
       }
       private void btnPlus_Click(object sender, EventArgs e)
       {
           if (inOperation == false)
           {
               a = Convert.ToDouble(label1.Text);
               label3.Text += "+";
               operation = '+';
               inOperation = true;
               onceForPoint = false;
           }
            else { }
       }
       private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close();}
       private void button9_Click(object sender, EventArgs e)
       {
           onceForPoint = false;
           inOperation = false;
           label1.Text = "";
           label3.Text = "";
       }
       private void button10_Click(object sender, EventArgs e)
       {
           try
           {
               if (label3.Text == "" && inOperation){ inOperation = false; label1.Text = label1.Text.Remove(label1.Text.Length - 1);}
               switch (inOperation)
               {
                   case false:
                       label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        if (!label1.Text.Contains(".")) { onceForPoint = false;}
                       break;
                   case true:
                       label3.Text = label3.Text.Remove(label3.Text.Length - 1);
                        if (!label3.Text.Contains(".")) { onceForPoint = false;}
                        break;
               }
           }
           catch { }
       }
       private void btnEqual_Click(object sender, EventArgs e)
       {
           try
           {
               b = Convert.ToDouble(label3.Text.Substring(1));
               switch (operation)
               {
                   case 'x':
                       c = a * b;
                       break;
                   case '÷':
                        c = a / b;
                        break;
                    case '-':
                       c = a - b;
                       break;
                   case '+':
                       c = a + b;
                       break;
               }
               label2.Text = Convert.ToString(c);
                if (b == 0 && operation == '÷') { label2.Text = "Cannot divide a number by 0"; }
            }
           catch { label2.Text = "Synthax Error";}
       }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCLR.PerformClick();
            label2.Text = "";
        }
    }
}
   
