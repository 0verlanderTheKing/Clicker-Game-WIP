using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Clicker_Game
{
    public partial class Simple_Clicker_Game : Form
    {
        public Simple_Clicker_Game()
        {
            InitializeComponent();
        }
        // Defining the varibles that are used.
        int clicks = 0;
        int clicker_Press = 1;

        
        int upgrade_One_Multiplier = 1;
        int upgrade_One_Price = 10;



        //This is for upgrade 2;
        int upgrade_Two_Cost = 100;
        int add_500 = 500;


        int max_Score = 0;

        int test = 0;


        private void Simple_Clicker_Game_Load(object sender, EventArgs e)
        {
            // This fixes a weird bug.
            
            click_Display.Text = (clicks.ToString());
            high_Score.Text = (max_Score.ToString());
            // This fixes a bug that has something highlighted on application open.
            click_Display.TabStop = false;
            high_Score.TabStop = false;
            Click_Reset_Button.TabStop = false;
            clicker_Button.TabStop = false;
            upgrade_One_Button.TabStop = false;
            upgrade_Two_Button.TabStop = false;
            upgrade_Three_Button.TabStop = false;

        }



        private void click_Display_TextChanged(object sender, EventArgs e)
        {
            // Just in case the user somehow get's under 0 clicks.
            
            if (clicks < 0)
            {

                MessageBox.Show("Game Over");
            }
            else
            {

            }
        }

        private void Click_Reset_Button_Click(object sender, EventArgs e)
        {
   


            if (clicks == 0)
            {
                MessageBox.Show("Your clicks are already at zero. You cant reset nothing.");
            }
            else
            {

                clicks = clicks - clicks;
                click_Display.Text = (clicks.ToString());
                MessageBox.Show("Clicks Succesfully reset.");
            }
        }

        private void clicker_Button_Click(object sender, EventArgs e)
        {


            // This is to make sure that the math for the upgrade one is correct and the first upgrade "upgrade_One" works.
            if (clicks == 0 && upgrade_One_Multiplier <= 1)
            {
                clicks = clicks + 1;
                click_Display.Text = (clicks.ToString());
            }
            else if (clicks > 0 && upgrade_One_Multiplier == 1)
            {
                // clicks = clicks + 1;
                clicks = clicks + upgrade_One_Multiplier;
                click_Display.Text = (clicks.ToString());
            }
            else if (clicks >= 1 && upgrade_One_Multiplier > 1)
            {
                clicks = clicks * upgrade_One_Multiplier;
                click_Display.Text = (clicks.ToString());
            }
            else if (clicks == 0 && upgrade_One_Multiplier > 1)
            {
                clicks = clicks + upgrade_One_Multiplier;
                click_Display.Text = (clicks.ToString());

            }

            // This has to be under the Button to update the highscore correctly.
            if (clicks > max_Score && clicks > 0)
            {
                max_Score = max_Score - max_Score;        
                max_Score = max_Score + clicks;
                high_Score.Text = (max_Score.ToString());
               

            }
        }

        private void upgrade_One_Button_Click(object sender, EventArgs e)
        {
            
            if (clicks >= upgrade_One_Price)
            {
                upgrade_One_Multiplier = upgrade_One_Multiplier + 1;
                clicks = clicks - upgrade_One_Price;
                click_Display.Text = (clicks.ToString());
                upgrade_One_Price = upgrade_One_Price * 4;
                MessageBox.Show("Coin Multiplier added. The new price to upgrade this is (" + upgrade_One_Price + ") coin(s).");
            }
            else
            {
                MessageBox.Show("You need more coins. The price to use this upgrade is (" + upgrade_One_Price + ") more coin(s).");

            }
        }
        private void upgrade_Two_Button_Click(object sender, EventArgs e)
            
        {

            if (clicks >= upgrade_Two_Cost)
            {
                clicks = clicks - upgrade_Two_Cost;
                clicks = clicks + add_500;
                click_Display.Text = (clicks.ToString());
                MessageBox.Show(add_500 + " click(s) added.");
                upgrade_Two_Cost = upgrade_Two_Cost * 20;
                add_500 = add_500 * 4;
                upgrade_Two_Button.Text = "Add " + add_500 + " more click(s).";

            }
            else 
            {
                MessageBox.Show("You need more coins. The price to use this upgrade is (" + upgrade_Two_Cost + ") more coin(s).");

            }
            //Updates the high score if needed after the upgrade
            if (clicks > max_Score && clicks > 0)
            {
                max_Score = max_Score - max_Score;
                max_Score = max_Score + clicks;
                high_Score.Text = (max_Score.ToString());
            }

        }
        private void upgrade_Three_Button_Click(object sender, EventArgs e)
        {

            // This makes a random seed.
            Random rand = new Random();
            // Makes the chanses harder after each use.
            
            int win_odds = 2;
            // "win_fix" is to fix the odds bug. And make the math easier.
            int win_fix = win_odds + 1;
            int random_num = rand.Next(0, win_fix);
            int upgrade_Three_Price = 100;

            if (clicks >= upgrade_Three_Price)
            {

                if (random_num == 1)
                {
                    clicks = clicks * 2;
                    click_Display.Text = (clicks.ToString());
                    MessageBox.Show("Congrats you won the gamble and the odds have increased! The new price to upgrade this is (" + upgrade_Three_Price + ") coin(s).");
                    win_odds = win_odds * 2;
                    upgrade_Three_Price = upgrade_Three_Price * 2;
                    if (clicks > max_Score && clicks > 0)
                    {
                        max_Score = max_Score - max_Score;
                        max_Score = max_Score + clicks;
                        high_Score.Text = (max_Score.ToString());
                    }

                }
                else if (random_num > 1)
                {
                    clicks = clicks - clicks;
                    click_Display.Text = (clicks.ToString());
                    MessageBox.Show("You lost the gamble and the odds have increased. The new price to upgrade this is (" + upgrade_Three_Price + ") coin(s).");
                    win_odds = win_odds * 2;
                    upgrade_Three_Price = upgrade_Three_Price * 2;
                }
                // Just in case
                else if (random_num == 0)
                {
                    clicks = clicks  - clicks;
                    click_Display.Text = (clicks.ToString());
                    MessageBox.Show("You lost the gamble and the odds have increased. The new price to upgrade this is (" + upgrade_Three_Price + ") coin(s).");
                    win_odds = win_odds * 2;
                    upgrade_Three_Price = upgrade_Three_Price * 2;
                }
            } else
            {
                MessageBox.Show("You need more coins. The price to use this upgrade is (" + upgrade_Three_Price + ") more coin(s).");
            }
        }

        private void upgrades_Panel_Paint(object sender, PaintEventArgs e)
        {


        }
        private void high_Score_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

