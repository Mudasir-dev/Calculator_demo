using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_demo
{
    public partial class Form1 : Form
    {
        int val1, val2, result;
        string op;

        public Form1()
        {
            InitializeComponent();
          //OffCal();
            OnCal();
            
        }

      

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnOne.Text);
            //txtDisplay.AppendText("1");

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnNine.Text);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btnZero.Text);
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(btndecimal.Text);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32((txtDisplay.Text).ToString());
            op = btnDivision.Text;
            txtDisplay.Clear();

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToInt32((txtDisplay.Text).ToString());
            if (op.Equals("+"))
            {
                result = val1 + val2;
                txtDisplay.Text = "" + result;
            }

            else if (op.Equals("-"))
            {
                result = val1 - val2;
                txtDisplay.Text = "" + result;
            }
            else if (op.Equals("/"))
            {
                result = val1 / val2;
                txtDisplay.Text = "" + result;
            }
           else if (op.Equals("*"))
            {
                result = val1 * val2;
                txtDisplay.Text = "" + result;
            }



        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32((txtDisplay.Text).ToString());
            //op="+";
            op = btnplus.Text;
            txtDisplay.Clear();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32((txtDisplay.Text).ToString());
            op = btnMinus.Text;
            txtDisplay.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            val1=Convert.ToInt32((txtDisplay.Text).ToString());
            op=btnMultiplication.Text ;
            txtDisplay.Clear();

        }
        private void btnOn_Click(object sender, EventArgs e)
        {
            OnCal();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            OffCal();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // txtDisplay.Text = "";
            txtDisplay.Clear();
        }
        void OnCal()
        {
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnZero.Enabled = true;
            btnDivision.Enabled = true;
            btndecimal.Enabled = true;
            btnMultiplication.Enabled = true;
            btnMinus.Enabled = true;
            btnplus.Enabled = true;
            btnOff.Enabled = true;
            btnOn.Enabled = true;
            btnClear.Enabled = true;


        }
        void OffCal()
        {
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnZero.Enabled = false;
            btnOff.Enabled = false;
            btnOn.Enabled = false;
            btnClear.Enabled = false;
            btnEquals.Enabled = false;
            btnDivision.Enabled = false;
            btndecimal.Enabled = false;
            btnMultiplication.Enabled = false;
            btnMinus.Enabled = false;
            btnplus.Enabled = false;
        }
    }
}
