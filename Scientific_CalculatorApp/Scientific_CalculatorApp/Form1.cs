using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_CalculatorApp
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if(num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }

            }

        }

        private void NumberOperators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);
            switch(op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;
                case "×":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "÷":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = enterSecondValue;
                    txtResult.Text =Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntery_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            string f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if(txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 320;
            txtResult.Width = 270;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 640;
            txtResult.Width = 580;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.14159265358979323846";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = Convert.ToString(a);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x,q,m,p;
            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);
            x = (q * p * m);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double ch = Convert.ToDouble(txtResult.Text);
            ch = Math.Cosh(ch);
            txtResult.Text = Convert.ToString(ch);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(txtResult.Text);
            th = Math.Tanh(th);
            txtResult.Text = Convert.ToString(th);
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void btnPs_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btninx_Click(object sender, EventArgs e)
        {
            double Inx = Convert.ToDouble(txtResult.Text);
            Inx = Math.Log(Inx);
            txtResult.Text = Convert.ToString(Inx);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 320;
            txtResult.Width = 270;
        }
    }
}
