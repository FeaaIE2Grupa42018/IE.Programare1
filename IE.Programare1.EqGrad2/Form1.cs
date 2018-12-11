using IE.Programare1.Util;
using System;
using System.Windows.Forms;

namespace IE.Programare1.EqGrad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonRezolva_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if(!NumberTryParse(uxTextBoxA, nameof(a), out a))
            {
                return;
            }
            if(!NumberTryParse(uxTextBoxB, nameof(b), out b))
            {
                return;
            }
            if(!NumberTryParse(uxTextBoxC, nameof(c), out c))
            {
                return;
            }

            double[] solutii = FunctiiMat.FctGrad2(a, b, c, out bool infinitate);

            if(infinitate)
            {
                MessageBox.Show("Ecuatia are o infinitate de solutii");
            }
            else
            {
                if(solutii.Length == 0)
                {
                    MessageBox.Show("Ecuatia nu are solutii reale");
                }
                else if(solutii.Length == 1)
                {
                    MessageBox.Show("Ecuatie de gradul 1. x=" + solutii[0]);
                }
                else
                {
                    MessageBox.Show($"Ecuatie de grad 2: x1={solutii[0]}; x2={solutii[1]}");
                }
            }
        }

        private bool NumberTryParse(TextBox control, string numeParametru, out double parametru)
        {
            bool sePoate = double.TryParse(control.Text, out parametru);
            if(!sePoate)
            {
                MessageBox.Show($"{numeParametru} trebuie sa contina doar caractere numerice!");
                control.Clear();
                control.Focus();
            }
            return sePoate;
        }
    }
}
