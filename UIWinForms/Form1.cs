using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UIWinForms
{
    public partial class SorterForm : Form
    {
        private int progressBarCount = 0;
        private int previousBarLocationX = default;
        private List<int> values = new List<int>(); 
        public SorterForm()
        {
            InitializeComponent();
        }

        private void AddValueButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddValueTextBox.Text, out int addedValue))
            {
                ++progressBarCount;
                var progressBar = new VerticalProgressBar.VerticalProgressBar
                {
                   Height = ProgressBarPanel.Height,
                   Location = new System.Drawing.Point(previousBarLocationX,20),
                   Width = 20,
                   Value = addedValue
                };
               

                
                var textBox = new TextBox
                {
                    ReadOnly = true,
                    Height = 15,
                    Text = addedValue.ToString(), 
                    Width = progressBar.Width,
                    Location = new System.Drawing.Point(previousBarLocationX,0)
                };

                values.Add(addedValue);
                previousBarLocationX += progressBar.Width;
                ProgressBarPanel.Controls.Add(progressBar);
               
                ProgressBarPanel.Controls.Add(textBox);
                
            }
            else MessageBox.Show("Это не число.");
        }
    }
}
