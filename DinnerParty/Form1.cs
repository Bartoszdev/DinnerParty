using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;
        public Form1()
        {
            InitializeComponent();

            dinnerparty = new DinnerParty((int)numericUpDown1.Value,healthyBox.Checked,fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople =(int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
