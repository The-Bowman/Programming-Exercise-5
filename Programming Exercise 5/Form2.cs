using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Exercise_5
{
    public partial class luckyNumberDisplay : Form
    {
        public luckyNumberDisplay()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = luckyNumberFinderForm.luckyNumber.ToString();
            
        }
    }
}
