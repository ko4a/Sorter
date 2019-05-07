using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerticalProgressBarSpace;

namespace UIWinForms
{
    public class ItemSort
    {
        public VerticalProgressBar Bar { get; set; } = null;
        public TextBox Box { get; set; } = null;
        

        public ItemSort(VerticalProgressBar bar, TextBox box)
        {
            this.Box = box;
            this.Bar = bar;
 
        }

    }
}
