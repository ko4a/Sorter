using System;
using System.Windows.Forms;

namespace UIWinForms
{
    public partial class Form1 : Form
    {
        private int progressBarCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddValueButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddValueTextBox.Text, out int addedValue))
            {

            }
            else MessageBox.Show("Это не число.");
        }
    }
}
