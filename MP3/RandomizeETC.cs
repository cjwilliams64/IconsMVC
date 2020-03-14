using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MatchingPairsGame
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            //these will represent a different symbol on the grid we're making
            //8 pairs!
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v","w", "w", "z","z"
        };

        public Form1()
        {
            InitializeComponent(); //the moment the app loads, the method below will begin
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            // 
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                Label iconLabel = c as Label; //creates a c variable that stores each variable one at a time. new name will be iconLabel
                if (iconLabel != null) //makes sure the conversion works, then next statements will run
                {
                    int randomNumber = random.Next(icons.Count);  //creates a random number that will correspond to ONE item in the icon list. the Next method returns the random number. the Count property determines the range the numbers will reach (1-8)
                    iconLabel.Text = icons[randomNumber]; //assigns an icon list item to a text property of the iconLabel

                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);  //removes the individual icon (from the list) that has been added to the form
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) return; //after two nonmatches are shown, the timer starts


            Label clickedLabel = sender as Label;
            if (clickedLabel !=null)
            {
                if (clickedLabel.ForeColor == Color.Black) return;

                if (firstClicked == null) // this changes the selected square to Black
                {
                    firstClicked = clickedLabel; //
                    firstClicked.ForeColor = Color.Black;

                    return; //icon is returned here

                    // first label that is clicked is revealed, but no others
                }

                secondClicked = clickedLabel; //tracks second clicked icon. makes it visible to user
                secondClicked.ForeColor = Color.Black;

                //Call for the CheckForWinner here!
                CheckForWinner();

                // if two consequetive selections match, return those squares as null
                if (firstClicked.Text == secondClicked.Text)
                {
                    //resets 
                    firstClicked = null;
                    secondClicked = null;
                    return; //tells program to skip the now null values. icons remain on page and timer stops
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer control to the form
            timer1.Stop(); //the timer isnt running right now. player hasn't clicked yet

            firstClicked.ForeColor = firstClicked.BackColor; //make these invisible
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null; //resets the variables so the next time the variable is clicked, the program knows that it is the first click. now user can click on the squares
            secondClicked = null;
        }

        private void CheckForWinner() // checks to see if all icons are matched
        {

            foreach(Control c in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                
                if (iconLabel != null)  
                {
                    //checks icon color. if colors match, the icon remains invisible so it's not matched. "return" means it escapes this method
                    if (iconLabel.ForeColor == iconLabel.BackColor) return;
                }
            }
            //if all are matched, you see the winning message

            MessageBox.Show("You matchced all the icons!", "Congratulations and well done!");
            Close(); //closes game
        }
    }
}