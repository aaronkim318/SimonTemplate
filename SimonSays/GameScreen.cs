///Created By Aaron KIm
///February - March 2022
///to demonstrate a SimonSays Gamex 
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

        //made to variables, a values variable to store the random numbers, and a guess vairable to store the players guesses
        int values = 0;
        public static int guess;
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //clears the stored list and waits for half a second before runnig the computer turn
            Form1.stored.Clear();
            Refresh();
            Thread.Sleep(500);
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
                    greenButton.BackColor = Form1.colors[0];//lights up the green button
                    Form1.sound[2].Play();//plays a sound 
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds
                    greenButton.BackColor = Form1.colors[1];//darkens the green button
                    Refresh();
                    Thread.Sleep(800);//wait another 0.8 seconds
                }

                if (Form1.stored[i] == 1)
                {
                    redButton.BackColor = Form1.colors[2];//lights up the red button
                    Form1.sound[4].Play();//plays a sound
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds
                    redButton.BackColor = Form1.colors[3];//darkens the red button
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds

                }

                if (Form1.stored[i] == 2)
                {
                    yellowButton.BackColor = Form1.colors[4];//lights up the yellow button
                    Form1.sound[3].Play();//plays a sound
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds
                    yellowButton.BackColor = Form1.colors[5];//darkens the yellow button
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds

                }

                if (Form1.stored[i] == 3)
                {
                    blueButton.BackColor = Form1.colors[6];//lights up the bluee button
                    Form1.sound[1].Play();//plays a sound
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds
                    blueButton.BackColor = Form1.colors[7];//darkens the blue button
                    Refresh();
                    Thread.Sleep(800);//waits 0.8 seconds

                }

            }
            //sets the guess index back to 0
            guess = 0;
        }

        public void GameOver()
        {
            //plays a sound when the game is finished
            Form1.sound[0].Play();
            //closes the game screen and adds the gameover screen
            Form1.ChangeScreen(this, new GameOverScreen());
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.stored[guess] == 0)
            {
                //checks to see if the guess was the green button
                greenButton.BackColor = Form1.colors[0];//lights up the green button
                Form1.sound[2].Play();//plays a sound 
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                greenButton.BackColor = Form1.colors[1];//darkens the green button
                Refresh();
                Thread.Sleep(800);//wait another 0.8 seconds
                guess++;//adds one to the guess
            }
            else
            {
                GameOver();//goes to the game over screen
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();//runs the computers turn again
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            //check to see if the guess was the red button
            if (Form1.stored[guess] == 1)
            {
                redButton.BackColor = Form1.colors[2];//lights up the red button
                Form1.sound[4].Play();//plays a sound
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                redButton.BackColor = Form1.colors[3];//darkens the red button
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                guess++;//adds one to the guess
            }
            else
            {
                GameOver();//goes to the game over screen
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();//runs the computers turn again
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            //checks to see if the guess is the yellow button
            if (Form1.stored[guess] == 2)
            {
                yellowButton.BackColor = Form1.colors[4];//lights up the yellow button
                Form1.sound[3].Play();//plays a sound
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                yellowButton.BackColor = Form1.colors[5];//darkens the yellow button
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                guess++;//adds one to the guess
            }
            else
            {
                GameOver();//goes to the game over screen
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();//runs the computers turn again
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            //checks to see if the guess is the blue button
            if (Form1.stored[guess] == 3)
            {
                blueButton.BackColor = Form1.colors[6];//lights up the bluee button
                Form1.sound[1].Play();//plays a sound
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                blueButton.BackColor = Form1.colors[7];//darkens the blue button
                Refresh();
                Thread.Sleep(800);//waits 0.8 seconds
                guess++;//adds one to the guess
            }
            else
            {
                GameOver();//goes to the game over screen
            }
            if (Form1.stored.Count() == guess)
            {
                ComputerTurn();//runs the computers turn again
            }
        }
    }
}
