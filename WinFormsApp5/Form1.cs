using System;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCommand.Items.Clear();
            cmbCommand.Items.Add("+");
            cmbCommand.Items.Add("-");
            cmbCommand.Items.Add("*");
            cmbCommand.Items.Add("/");

            cmbCommand.SelectedIndex = 0;

            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            lblAnswer.Text = "0";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double num1) &&
                double.TryParse(txtNumber2.Text, out double num2))
            {
                string command = cmbCommand.SelectedItem?.ToString();
                double result = 0;

                switch (command)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Sıfıra bölmək mümkün deyil!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                lblAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Xahiş olunur düzgün ədəd daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "0";
            txtNumber2.Text = "0";

            if (cmbCommand.Items.Count > 0)
            {
                cmbCommand.SelectedIndex = 0;
            }

            lblAnswer.Text = "0";
        }
    }
}