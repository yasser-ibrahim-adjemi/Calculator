using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double n1, n2,result;
        char op;
        public Form1()
        {
            InitializeComponent();
        }
        private void button16_MouseEnter(object sender, EventArgs e)
        {
                button16.BackColor = Color.MediumPurple;
        }
        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.LightGray;
        }
        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackColor = Color.MediumPurple;
        }
        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.LightGray;
        }
        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackColor = Color.MediumPurple;
        }
        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.LightGray;
        }
        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackColor = Color.MediumPurple;
        }
        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightGray;
        }
        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.MediumPurple;
        }
        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightGray;
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.MediumPurple;
        }
        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightGray;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumPurple;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGray;
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.MediumPurple;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightGray;
        }
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.MediumPurple;
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightGray;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumPurple;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumPurple;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumPurple;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }
        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            button16.BackColor = Color.Purple;
        }
        private void button16_MouseUp(object sender, MouseEventArgs e)
        {
            button16.BackColor = Color.LightGray;
        }
        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            button15.BackColor = Color.Purple;
        }
        private void button15_MouseUp(object sender, MouseEventArgs e)
        {
            button15.BackColor = Color.LightGray;
        }
        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            button14.BackColor = Color.Purple;
        }
        private void button14_MouseUp(object sender, MouseEventArgs e)
        {
            button14.BackColor = Color.LightGray;
        }
        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            button12.BackColor = Color.Purple;
        }
        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            button12.BackColor = Color.LightGray;
        }
        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            button11.BackColor = Color.Purple;
        }
        private void button11_MouseUp(object sender, MouseEventArgs e)
        {
            button11.BackColor = Color.LightGray;
        }
        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.Purple;
        }
        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.LightGray;
        }
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Purple;
        }
        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.LightGray;
        }
        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.Purple;
        }
        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.LightGray;
        }
        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.Purple;
        }
        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.LightGray;
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Purple;
        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Purple;
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Purple;
        }
        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.FlatAppearance.BorderColor = Color.Black;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.FlatAppearance.BorderColor = SystemColors.Control;
        }
        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.FlatAppearance.BorderColor = Color.Black;
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.FlatAppearance.BorderColor = SystemColors.Control;
        }
        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.FlatAppearance.BorderColor = Color.Black;
        }
        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.FlatAppearance.BorderColor = SystemColors.Control;
        }
        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.FlatAppearance.BorderColor = Color.Black;
        }
        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.FlatAppearance.BorderColor = SystemColors.Control;
        }
        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            button17.BackColor = Color.DarkViolet;
            button17.FlatAppearance.BorderColor = SystemColors.Control;
        }
        private void button17_MouseUp(object sender, MouseEventArgs e)
        {
            button17.BackColor = Color.OrangeRed;
            button17.FlatAppearance.BorderColor = Color.DarkViolet;
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if ((e.KeyCode == Keys.D1) || (e.KeyCode == Keys.NumPad1))
            {
                button12.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "1";
            }
            else if ((e.KeyCode == Keys.D2) || (e.KeyCode == Keys.NumPad2))
            {
                button11.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "2";
            }
            else if ((e.KeyCode == Keys.D3) || (e.KeyCode == Keys.NumPad3))
            {
                button10.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "3";
            }
            else if ((e.KeyCode == Keys.D4) || (e.KeyCode == Keys.NumPad4))
            {
                button5.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "4";
            }
            else if ((e.KeyCode == Keys.D5) || (e.KeyCode == Keys.NumPad5))
            {
                button6.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "5";
            }
            else if ((e.KeyCode == Keys.D6) || (e.KeyCode == Keys.NumPad6))
            {
                button7.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "6";
            }
            else if ((e.KeyCode == Keys.D7) || (e.KeyCode == Keys.NumPad7))
            {
                button1.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "7";
            }
            else if ((e.KeyCode == Keys.D8) || (e.KeyCode == Keys.NumPad8))
            {
                button2.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "8";
            }
            else if ((e.KeyCode == Keys.D9) || (e.KeyCode == Keys.NumPad9))
            {
                button3.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "9";
            }
            else if (e.KeyCode == Keys.Back)
            {
                button14.BackColor = Color.Purple;
                txtName.Clear();
            }
            else if ((e.KeyCode == Keys.D0) || (e.KeyCode == Keys.NumPad0))
            {
                button15.BackColor = Color.Purple;
                txtName.Text = txtName.Text + "0";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button17.BackColor = Color.Purple;
                try
                {
                    n2 = Convert.ToDouble(txtName.Text);
                    switch (op)
                    {
                        case '+':
                            result = n1 + n2;
                            txtName.Clear();
                            break;
                        case '-':
                            result = n1 - n2;
                            txtName.Clear();
                            break;
                        case '*':
                            result = n1 * n2;
                            txtName.Clear();
                            break;
                        case '/':
                            result = n1 / n2;
                            txtName.Clear();
                            break;
                    }
                    txtName.Text = Convert.ToString(result);
                }
                catch
                {
                }
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                button9.BackColor = Color.Purple;
                try
                {
                    n1 = Convert.ToDouble(txtName.Text);
                    op = '*';
                    txtName.Clear();
                }
                catch
                {
                }
            }
            else if (e.KeyCode == Keys.Divide)
            {
                button13.BackColor = Color.Purple;
                try
                {
                    n1 = Convert.ToDouble(txtName.Text);
                    op = '/';
                    txtName.Clear();
                }
                catch
                {
                }
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                button8.BackColor = Color.Purple;
                try
                {
                    n1 = Convert.ToDouble(txtName.Text);
                    op = '-';
                    txtName.Clear();
                }
                catch
                {
                }
            }
            else if (e.KeyCode == Keys.Add)
            {
                button4.BackColor = Color.Purple;
                try
                {
                    n1 = Convert.ToDouble(txtName.Text);
                    op = '+';
                    txtName.Clear();
                }
                catch
                {
                }
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                button16.BackColor = Color.Purple;
                try
                {
                    txtName.Text = txtName.Text + ",";
                }
                catch
                {
                }
            }
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D1) || (e.KeyCode == Keys.NumPad1))
            {
                button12.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D2) || (e.KeyCode == Keys.NumPad2))
            {
                button11.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D3) || (e.KeyCode == Keys.NumPad3))
            {
                button10.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D4) || (e.KeyCode == Keys.NumPad4))
            {
                button5.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D5) || (e.KeyCode == Keys.NumPad5))
            {
                button6.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D6) || (e.KeyCode == Keys.NumPad6))
            {
                button7.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D7) || (e.KeyCode == Keys.NumPad7))
            {
                button1.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D8) || (e.KeyCode == Keys.NumPad8))
            {
                button2.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D9) || (e.KeyCode == Keys.NumPad9))
            {
                button3.BackColor = Color.LightGray;
            }
            else if (e.KeyCode == Keys.Back)
            {
                button14.BackColor = Color.LightGray;
            }
            else if ((e.KeyCode == Keys.D0) || (e.KeyCode == Keys.NumPad0))
            {
                button15.BackColor = Color.LightGray;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button17.BackColor = Color.OrangeRed;
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                button9.BackColor = Color.OrangeRed;
            }
            else if (e.KeyCode == Keys.Divide)
            {
                button13.BackColor = Color.OrangeRed;
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                button8.BackColor = Color.OrangeRed;
            }
            else if (e.KeyCode == Keys.Add)
            {
                button4.BackColor = Color.OrangeRed;
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                button16.BackColor = Color.LightGray;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "1";
        }
        private void button16_Click(object sender, EventArgs e)
        {

                txtName.Text = txtName.Text + ",";
            

        }
        private void button11_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "2";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "3";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "4";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "5";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "6";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "7";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "8";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "9";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txtName.Text);
                op = '+';
                txtName.Clear();
            }
            catch
            {

            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txtName.Text);
                op = '-';
                txtName.Clear();
            }
            catch
            {
                
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txtName.Text);
                op = '*';
                txtName.Clear();
            }
            catch
            {
                
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txtName.Text);
                op = '/';
                txtName.Clear();
            }
            catch
            {
                
            }
        }
        private void button17_Click(object sender, EventArgs e)mm
        {
            try
            {
                n2 = Convert.ToDouble(txtName.Text);
                switch (op)
                {
                    case '+':
                        result = n1 + n2;
                        txtName.Clear();
                        break;
                    case '-':
                        result = n1 - n2;
                        txtName.Clear();
                        break;
                    case '*':
                        result = n1 * n2;
                        txtName.Clear();
                        break;
                    case '/':
                        result = n1 / n2;
                        txtName.Clear();
                        break;
                }
                txtName.Text = Convert.ToString(result);
            }
            catch
            {
            }
        } 
        private void button14_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
    }
}
