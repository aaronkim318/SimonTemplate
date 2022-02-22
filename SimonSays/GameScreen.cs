using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        int values = 0;
        int guess = 0;


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()
            Form1.stored.Clear();
            Refresh();
            Thread.Sleep(2000);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            values = Form1.randGen.Next(0, 4);
            Form1.stored.Add(values);
            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < values; i++)
            {
                if (values == 0)
                {
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(1000);
                    redButton.BackColor = Color.DarkRed;
                    
                }
                else if (values == 1)
                {
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(1000);
                    blueButton.BackColor = Color.DarkBlue;

                }
                else if (values == 2)
                {
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(1000);
                    greenButton.BackColor = Color.ForestGreen;

                }
                else if (values == 3)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(1000);
                    yellowButton.BackColor = Color.Goldenrod;

                }
                Refresh();
            }
            //TODO: get guess index value back to 0
            values = 0;
        }

        public void GameOver()
        {
            //TODO: Play a game over sound

            //TODO: close this screen and open the GameOverScreen

        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value at current guess index equal to a green. If so:
            // light up button, play sound, and pause
            // set button colour back to original
            // add one to the guess index
            // check to see if we are at the end of the pattern. If so:
            // call ComputerTurn() method
            // else call GameOver method
            if(values == 2)
            {

            }
        }
    }
}
