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
        public static int guess;
        SoundPlayer homerDarnTootin = new SoundPlayer(Properties.Resources.darn_tootin);
        SoundPlayer homerDoh = new SoundPlayer(Properties.Resources.doh1_y);
        SoundPlayer homerDammit= new SoundPlayer(Properties.Resources.dammit);
        SoundPlayer homerBurp = new SoundPlayer(Properties.Resources.burp);
        SoundPlayer homerSinging= new SoundPlayer(Properties.Resources.dah_dah_hey);
        SoundPlayer homerBoring = new SoundPlayer(Properties.Resources.boring);
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()
            Form1.stored.Clear();
            Refresh();
            Thread.Sleep(200);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            values = Form1.randGen.Next(0, 4);
            Form1.stored.Add(values);


            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.stored.Count(); i++)
            {
                if (Form1.stored[i] == 0)
                {
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    homerBurp.Play();
                   
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                    Thread.Sleep(200);
                }
                else if (Form1.stored[i] == 1)
                {
                    redButton.BackColor = Color.Red;
                    
                    homerDarnTootin.Play();
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    Thread.Sleep(200);
                }
                else if (Form1.stored[i] == 2)
                {
                    yellowButton.BackColor = Color.Yellow;
                    
                    homerDoh.Play();
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                    Thread.Sleep(200);
                }
                else if (Form1.stored[i] == 3)
                {
                    blueButton.BackColor = Color.Blue;
                   
                    homerBoring.Play();
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                    Thread.Sleep(200);
                }

            }
            //TODO: get guess index value back to 0
            guess = 0;
        }

        public void GameOver()
        {
            //TODO: Play a game over sound
            homerDammit.Play();
            //TODO: close this screen and open the GameOverScreen
            Form1.ChangeScreen(this, new GameOverScreen());
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

            if (Form1.stored[guess] == 0)
            {
                greenButton.BackColor = Color.LightGreen;
               
                homerBurp.Play();
                Refresh();
                Thread.Sleep(500);
                greenButton.BackColor = Color.ForestGreen;
                Refresh();
                Thread.Sleep(200);
                guess++;
            }
            else
            {
                GameOver();
            }

            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {

            if (Form1.stored[guess] == 1)
            {
                redButton.BackColor = Color.Red;
                
                homerDarnTootin.Play();
                Refresh();
                Thread.Sleep(500);
                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(200);
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();
            }

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

            if (Form1.stored[guess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;
               
                homerDoh.Play();
                Refresh();
                Thread.Sleep(500);
                yellowButton.BackColor = Color.Goldenrod;
                Refresh();
                Thread.Sleep(200);
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {

            if (Form1.stored[guess] == 3)
            {
                blueButton.BackColor = Color.Blue;
                
                homerBoring.Play();
                Refresh();
                Thread.Sleep(500);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                Thread.Sleep(200);
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();
            }
        }
    }
}
