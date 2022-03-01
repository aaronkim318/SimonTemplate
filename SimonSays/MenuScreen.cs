using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
       
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //deletes the menuscreeen and adds the game screen to form1
            Form1.ChangeScreen(this, new GameScreen());
            Refresh();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }


    }
}
