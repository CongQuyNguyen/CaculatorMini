using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorVersion2
{
    public partial class Caculator : Form
    {
        string op, postfix;
        public Caculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = "+";
            lblScreen1.Text = lblScreen1.Text + "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "8";
        }

        private void btnNice_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "9";
        }

        private void btnThapphan_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + ".";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            string tmp = lblScreen1.Text;

            // Console.WriteLine(tmp);

            InfixToPostfixPro infixToPostfixPro = new InfixToPostfixPro();

            postfix = infixToPostfixPro.InfixToPostfix(tmp);

            // Console.WriteLine(postfix);

            txtInfix.Text = postfix;

            Cal cal = new Cal();

            double res = cal.Caculate(txtInfix.Text);

            lblScreen2.Text = res.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            op = "-";
            lblScreen1.Text = lblScreen1.Text + "-";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            op = "*";
            lblScreen1.Text = lblScreen1.Text + "*";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            op = "/";
            lblScreen1.Text = lblScreen1.Text + "/";
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + "(";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you exit the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tmp = lblScreen1.Text;
            tmp = tmp.Remove(tmp.Length - 1);
            lblScreen1.Text = tmp;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            lblScreen1.Text = lblScreen1.Text + ")";
        }
    }
}
