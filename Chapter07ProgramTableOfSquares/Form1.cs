using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07ProgramTableOfSquares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;

            //====== GATHER INPUNTS =====

            //CONVERT START FROM TEXT TO INT
            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }

            //CONVERT END FROM TEXT TO INT
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("Start greater than end.", "Input Error");
                txtStart.Focus();
                return;
            }

            //====== PROCESS AND DISPLAY ======
            for (i = start; i <+ end; i++)
            {
                buff = string.Format("{0, 5} {1, 20}", i, i * i);
                lstOutput.Items.Add(buff);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
