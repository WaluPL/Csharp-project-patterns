using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMatC.Text =( Matrix.Parse(txtMatA.Text) + Matrix.Parse(txtMatB.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtMatC.Text = (Matrix.Parse(txtMatA.Text) - Matrix.Parse(txtMatB.Text)).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtMatC.Text = (Matrix.Parse(txtMatA.Text) * Matrix.Parse(txtMatB.Text)).ToString();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            txtMatB.Text = Matrix.solve(Matrix.Parse(txtMatA.Text), Matrix.Parse(txtMatC.Text)).ToString();
        }
    }
}
