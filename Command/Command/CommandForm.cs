using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class CommandForm : Form
    {

        public CommandForm()
        {
            InitializeComponent();
            lbCommands.Items.Add(new SportsmanCommandRun());
            lbCommands.Items.Add(new SportsmanCommandJump());
            lbCommands.Items.Add(new SportsmanCommandSwim());
            AdjustButtons();
        }

        private void AdjustButtons() {
            string TreningName = txtTreningName.Text.Trim();
            SportsmanCommand sportsmanCommand = (SportsmanCommand)lbCommands.SelectedItem;
            bool TreningNameNotEmpty = (TreningName.Length > 0);
            bool TreningListNotEmpty = (lbTrening.Items.Count > 0);
            bool TreningNameNotUsed = (lbCommands.Items.IndexOf(TreningName) < 0);
            bool SportsmanNameNotEmpty = (txtSportsmenName.Text.Trim().Length > 0);
            bool ComplexCommandSelected = sportsmanCommand is SportsmanCommandComplex;
            btnAppendCommand.Enabled = (TreningNameNotEmpty && TreningListNotEmpty && TreningNameNotUsed);
            btnExecute.Enabled = (SportsmanNameNotEmpty);
            BtnDropTreningItem.Enabled = (TreningListNotEmpty);
            btnDeleteCommandItem.Enabled = (ComplexCommandSelected);
        }

		private void btnAppendTrening_Click(object sender, EventArgs e)
		{
            SportsmanCommand item = (SportsmanCommand)lbCommands.SelectedItem;
            lbTrening.Items.Add(item);
            lbTrening.SelectedIndex = lbTrening.Items.Count - 1;
            AdjustButtons();
		}

        private void btnAppendCommand_Click(object sender, EventArgs e)
        {
            List<SportsmanCommand> list = new List<SportsmanCommand>();
            for(int i = 0; i < lbTrening.Items.Count; ++i)
            {
                list.Add((SportsmanCommand)lbTrening.Items[i]);
            }
            string TreningName = txtTreningName.Text;
            SportsmanCommand trening = new SportsmenCommandTrening(TreningName, list);
            lbCommands.Items.Add(trening);
            lbCommands.SelectedIndex = lbTrening.Items.Count - 1;
            AdjustButtons();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string SportsmenName = txtSportsmenName.Text;
            SportsmanCommand item = (SportsmanCommand)lbCommands.SelectedItem;
            Sportsman sportsman = new Sportsman(SportsmenName);
            string result = sportsman.Execute(item);
            txtLog.AppendText(result + Environment.NewLine);
            AdjustButtons();
        }

        private void btnDeleteCommandItem_Click(object sender, EventArgs e)
        {
            int index = lbCommands.SelectedIndex;
            SportsmanCommand item = (SportsmanCommand)lbCommands.SelectedItem;
            lbCommands.Items.Remove(item);
            lbCommands.SelectedIndex = Math.Min(lbCommands.Items.Count - 1,index);
            AdjustButtons();

        }

        private void BtnDropTreningItem_Click(object sender, EventArgs e)
        {
            int index = lbTrening.SelectedIndex;
            SportsmanCommand item = (SportsmanCommand)lbTrening.SelectedItem;
            lbTrening.Items.Remove(item);
            lbTrening.SelectedIndex = Math.Min(lbTrening.Items.Count - 1, index);
            AdjustButtons();
        }

        private void txtTreningName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }

        private void txtSportsmenName_TextChanged(object sender, EventArgs e)
        {
            AdjustButtons();
        }
    }
}
