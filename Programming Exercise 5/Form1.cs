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
    public partial class luckyNumberFinderForm : Form
    {

        private string color;
        private string shape;
        private int number;
        private double mult;
        public static int luckyNumber;
        // private string display;

        public luckyNumberFinderForm()
        {
            InitializeComponent();
        }

        // launches second form to display lucky number
        private void luckyButton_Click(object sender, EventArgs e)
        {
            luckyNumberDisplay luckyNumberDisplay = new luckyNumberDisplay();
            luckyNumberDisplay.Show();

        }

        // hides undesired controls at form loading
        private void luckyNumberFinderForm_Load(object sender, EventArgs e)
        {

            Hide_Content();

        }

        // assigns values and reveals the next controls
        private void clrDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapeLabel.Visible = true;
            shapeDropDownList.Visible = true;
            color = clrDropDownList.SelectedItem.ToString();
        }

        // assigns values and reveals the next controls
        private void shapeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = shapeDropDownList.SelectedItem.ToString();
            numberLabel.Visible = true;
            numberDropDownList.Visible = true;
        }

        // assigns values and reveals the next controls
        private void numberDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            multiplierLabel.Visible = true;
            multiplierDescrLabel.Visible = true;
            number = int.Parse(numberDropDownList.SelectedItem.ToString());
            mult = Set_Multiplier_Colors() * Set_Multiplier_Shapes();
            multiplierLabel.Text = String.Format("{0:0.0000}", mult);
            luckyNumber = number + (int)mult;
        }

        // sets all but the first controls to not be visible
        private void Hide_Content()
        {
            shapeLabel.Visible = false;
            shapeDropDownList.Visible = false;
            multiplierDescrLabel.Visible = false;
            multiplierLabel.Visible = false;
            numberLabel.Visible = false;
            numberDropDownList.Visible = false;
        }
        // creates a random number to assign to multipliers to generate lucky numbers
        private double Set_Multiplier_Colors()
        {
            double x = .1;
            Random rand = new Random();
            if (color.Equals("Red"))
            {
                x = rand.NextDouble();
            }
            else if (color.Equals("Yellow"))
            {
                x = 2.1 * rand.Next(0, 5);
            }
            else if (color.Equals("Green"))
            {
                x = rand.NextDouble() * 3.33;
            }
            else if (color.Equals("Blue"))
            {
                x = rand.Next(10, 26) % 2.8;
            }
            else if (color.Equals("Orange"))
            {
                x = rand.NextDouble() + 6.9;
            }
            return x;
        }

        // creates a random number to assign to multipliers to generate lucky numbers
        private double Set_Multiplier_Shapes()
        {
            double x = .6;
            Random rand = new Random();
            if (shape.Equals("Triangle"))
            {
                x = rand.NextDouble();
            }
            else if (shape.Equals("Square"))
            {
                x = rand.Next(3, 11);
            }
            else if (shape.Equals("Circle"))
            {
                x = rand.NextDouble() / 4.2;
            }
            else if (shape.Equals("Octagon"))
            {
                x = rand.NextDouble() % 2 + 3.3;
            }
            return x;

        }



    }
}
