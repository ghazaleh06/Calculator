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
    public partial class Calculater : Form
    {
        ICalculate calculate;

        public Calculater()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Calculater_Load(object sender, EventArgs e)
        {
           
        }

        bool ValidateInputs()
        {
            bool Isvalid = true;

            if (Num1.Value == 0)
            {
                Isvalid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if (Num2.Value == 0)
                {
                    Isvalid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }
            return Isvalid;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum=calculate.Sum((int)Num1.Value , (int)Num2.Value);
                MessageBox.Show("sum is:" + sum);
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = calculate.Minus((int)Num1.Value, (int)Num2.Value);
                MessageBox.Show("sum is:" + minus);
            }
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Multiple = calculate.Multiple((int)Num1.Value, (int)Num2.Value);
                MessageBox.Show("sum is:" + Multiple);
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.Divide((int)Num1.Value, (int)Num2.Value);
                MessageBox.Show("sum is:" + divide);
            }
        }
    }
}
