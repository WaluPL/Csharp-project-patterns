using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string kind in AnimalFactory.keys()) CB_Type.Items.Add(kind);
            CB_Type.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
