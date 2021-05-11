using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbModel.Items.AddRange(Car.Keys);
            foreach(string decor in CarDecorator.Decorators)
			{
                clbDecorators.Items.Add(decor);
			}
            cbModel.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = Car.make(cbModel.SelectedItem.ToString());
            foreach(string decor in clbDecorators.CheckedItems)
            {
                car = CarDecorator.make(decor, car);
            }
            txtLog.AppendText(string.Format("{0,9}\t{1}", car.price(), car.info()) + Environment.NewLine);
        }
    }
}
