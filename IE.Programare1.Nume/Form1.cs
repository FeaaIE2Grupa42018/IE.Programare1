using IE.Programare1.Util;
using System;
using System.Windows.Forms;

namespace IE.Programare1.Nume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonAdauga_Click(object sender, EventArgs e)
        {
            AdaugaNume();
        }

        private void AdaugaNume()
        {
            string nume = uxTextBoxNume.Text;
            if(string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Numele nu poate fi gol.");
            }
            else
            {
                uxListBoxNume.Items.Add(nume);
            }
            uxTextBoxNume.Focus();
            uxTextBoxNume.Clear();
        }

        private void uxTextBoxNume_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AdaugaNume();
            }
        }

        private void uxButtonSorteaza_Click(object sender, EventArgs e)
        {
            string[] toSort = NumeToArray();
            FunctiiCautareSortare.InsertionSort(toSort, uxCheckBoxDescr.Checked);

            uxListBoxNume.Items.Clear();
            uxListBoxNume.Items.AddRange(toSort);
        }

        private string[] NumeToArray()
        {
            string[] toSort = new string[uxListBoxNume.Items.Count];
            for(int i = 0; i < uxListBoxNume.Items.Count; i++)
            {
                toSort[i] = uxListBoxNume.Items[i].ToString();
            }

            return toSort;
        }

        private void uxButtonCauta_Click(object sender, EventArgs e)
        {
            string[] toSort = NumeToArray();
            int pozitie = FunctiiCautareSortare.Cauta(toSort, uxTextBoxCauta.Text);
            MessageBox.Show("Valaoare se gaseste la pozitia " + (pozitie + 1));
        }
    }
}
