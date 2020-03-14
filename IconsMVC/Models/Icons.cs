using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameToWeb.Models
{
    public class Icons
    {

        //public IList<string> RandomList { get; set; }

        // public string Icon

            // assigning icons to each square, at random
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            //these will represent a different symbol on the grid we're making
            //8 pairs!
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v","w", "w", "z","z"
        };

        public IList<string> RandomList 
        {
            get
            {
                List<string> randomList = new List<string>();


                for (int i = 0; i < 16; i++)
                {

                    int randomNumber = random.Next(icons.Count);  //creates a random number that will correspond to ONE item in the icon list. the Next method returns the random number. the Count property determines the range the numbers will reach (0-15)

                    string iconLabel = icons[randomNumber]; //assigns a random icon list item to a one-character string called iconLabel


                    randomList.Add(iconLabel);


                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);  //removes the individual icon (from the list) that has been added to the form
                }
                return randomList;
            }
            
        }
        
    }
}
