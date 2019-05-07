using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VerticalProgressBarSpace;
using Sorter.Sort;
using System.Linq;
using System.Drawing;

namespace UIWinForms
{
    public partial class SorterForm : Form
    {
        private int progressBarCount = 0;
        private int previousBarLocationX = default;
        private List<ItemSort> values = new List<ItemSort>(); 
        public SorterForm()
        {
            InitializeComponent();
        }

        private void AddValueButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddValueTextBox.Text, out int addedValue))
            {
                ++progressBarCount;
                var progressBar = new VerticalProgressBar
                {
                   Height = ProgressBarPanel.Height,
                   Location = new Point(previousBarLocationX,20),
                   Width = 20,
                   Value = addedValue
                };
               

                
                var textBox = new TextBox
                {
                    ReadOnly = true,
                    Height = 15,
                    Text = addedValue.ToString(), 
                    Width = progressBar.Width,
                    Location = new Point(previousBarLocationX,0)
                };

                values.Add(new ItemSort(progressBar,textBox));
                previousBarLocationX += progressBar.Width;
                ProgressBarPanel.Controls.Add(progressBar);
               
                ProgressBarPanel.Controls.Add(textBox);
                
            }
            else MessageBox.Show("Это не число.");
        }

        private void ProgressBarPanelSizeChanged(object sender, EventArgs e)
        {
            ProgressBarPanel.Controls.Clear();

            previousBarLocationX = default;
            for (int i=0;i<progressBarCount;i++)
            {
                var progressBar = new VerticalProgressBar
                {
                    Height = ProgressBarPanel.Height,
                    Location = new Point(previousBarLocationX, 20),
                    Width = 20,
                    Value = values[i].Bar.Value
                };

                var textBox = new TextBox
                {
                    ReadOnly = true,
                    Height = 15,
                    Text = values[i].Box.Text,
                    Width = progressBar.Width,
                    Location = new Point(previousBarLocationX, 0)
                };
                previousBarLocationX += progressBar.Width;
                ProgressBarPanel.Controls.Add(progressBar);
                ProgressBarPanel.Controls.Add(textBox);

            }
        }

        private void AddRandValueButton_Click(object sender, EventArgs e)
        {
            //AddRandValueButton.BackColor = Color.Red;
            Random randomiser = new Random();
            if (int.TryParse(AddRandValueTextBox.Text, out int size))
            {
                ProgressBarPanel.Controls.Clear();
                values.Clear();
                progressBarCount = default;
                previousBarLocationX = default;
                for (int i = 0; i < size; i++)
                {
                    ++progressBarCount;
                    int rnd = randomiser.Next(100);
                    var progressBar = new VerticalProgressBar
                    {
                        Height = ProgressBarPanel.Height,
                        Location = new Point(previousBarLocationX, 20),
                        Width = 20,
                        Value = rnd
                    };

                    var textBox = new TextBox
                    {
                        ReadOnly = true,
                        Height = 15,
                        Text = rnd.ToString(),
                        Width = progressBar.Width,
                        Location = new Point(previousBarLocationX, 0)
                    };
                    values.Add(new ItemSort(progressBar, textBox));
                    previousBarLocationX += progressBar.Width;
                    ProgressBarPanel.Controls.Add(progressBar);
                    ProgressBarPanel.Controls.Add(textBox);

                }
            }
            else MessageBox.Show("Это не число.");
        }

        private void BubbleSortButtonClick(object sender, EventArgs e)
        {
            if (progressBarCount < 2) MessageBox.Show("нечего сортировать");
            else
            {
                var bubble = new BubbleSort<int>();
                bubble.Items.AddRange(values.Select(x=>x.Bar.Value));
                bubble.SwapEvent += SwapEvent;
                bubble.Sort();
            }
        }


        private void SwapEvent(object sender, Tuple<int, int> e)
        {
           
            var tmpItem = values[e.Item1];
            values[e.Item1] = values[e.Item2];
            values[e.Item2] = tmpItem;

            SwapItemsOnUI(e.Item1, e.Item2);

        }

        private void SwapItemsOnUI(int firstPos, int secondPos)
        {
            var BarTmpLocation = values[firstPos].Bar.Location;
            var BoxTmpLocation = values[firstPos].Box.Location;

            values[firstPos].Bar.Location = values[secondPos].Bar.Location;
            values[firstPos].Box.Location = values[secondPos].Box.Location;

            values[secondPos].Bar.Location = BarTmpLocation;
            values[secondPos].Box.Location = BoxTmpLocation;

        }

        private void InsertSortButtonClick(object sender, EventArgs e)
        {
            if (progressBarCount < 2) MessageBox.Show("нечего сортировать");
            else
            {
                var insert = new InsertSort<int>();
                insert.Items.AddRange(values.Select(x => x.Bar.Value));
                insert.SwapEvent += SwapEvent;
                insert.Sort();
            }
        }

        private void CocktailSortButtonClick(object sender, EventArgs e)
        {
            if (progressBarCount < 2) MessageBox.Show("нечего сортировать");
            else
            {
                var cocktail = new CocktailSort<int>();
                cocktail.Items.AddRange(values.Select(x => x.Bar.Value));
                cocktail.SwapEvent += SwapEvent;
                cocktail.Sort();
            }
        }

        private void ShellSortButtonClick(object sender, EventArgs e)
        {
            if (progressBarCount < 2) MessageBox.Show("нечего сортировать");
            else
            {
                var shell = new ShellSort<int>();
                shell.Items.AddRange(values.Select(x => x.Bar.Value));
                shell.SwapEvent += SwapEvent;
                shell.Sort();
            }
        }
    }
}
