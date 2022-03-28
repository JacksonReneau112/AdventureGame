using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //Tracks the page of the user.
        int page = 1;

        //Tracks if the user has the key.
        int key = 0;

        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();

            //Displays the initial message.
            storyOutputLabel.Text = "You wake up on a beach near a dense jungle.";
            option1Label.Text = "Set up camp";
            option2Label.Text = "Explore the beach";
            pictureBox.BackgroundImage = Properties.Resources.beachJungle;
        }

        private void choice1Button_Click(object sender, EventArgs e)
        {

            //Checks what page the user is on then sends to a different page depending on choice.
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                int randValue = randGen.Next(1, 11);

                if (randValue > 5)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 4)
            {
                page = 9;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 11;
            }
            else if (page == 7)
            {
                page = 1;

                key = 0;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 1;

                key = 0;
            }
            else if (page == 10)
            {
                page = 1;

                key = 0;
            }
            else if (page == 11)
            {
                key = 1;

                page = 15;
            }
            else if (page == 12)
            {
                page = 1;

                key = 0;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 14)
            {
                page = 1;

                key = 0;
            }
            else if (page == 15)
            {
                page = 19;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 23;
            }
            else if (page == 18)
            {
                page = 1;

                key = 0;
            }
            else if (page == 19)
            {
                if (key == 1)
                {
                    page = 20;
                }
                else
                {
                    page = 21;
                }
            }
            else if (page == 20)
            {
                page = 1;

                key = 0;
            }
            else if (page == 21)
            {
                page = 26;
            }
            else if (page == 22)
            {
                page = 1;

                key = 0;
            }
            else if (page == 23)
            {
                page = 1;

                key = 0;
            }
            else if (page == 24)
            {
                page = 1;

                key = 0;
            }
            else if (page == 25)
            {
                int randValue = randGen.Next(1, 11);

                if (randValue > 3)
                {
                    page = 28;
                }
                else
                {
                    page = 29;
                }
            }
            else if (page == 26)
            {
                page = 1;

                key = 0;
            }
            else if (page == 27)
            {
                page = 1;

                key = 0;
            }
            else if (page == 28)
            {
                page = 1;

                key = 0;
            }
            else if (page == 29)
            {
                page = 1;

                key = 0;
            }
            else if (page == 30)
            {
                page = 1;

                key = 0;
            }

            displayPage();

            // Display text and game options depending upon current page.

      

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 8;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 12;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 14;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 16;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 18;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 19;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 25;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 27;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 30;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;
            }
            else if (page == 28)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 99;
            }

            displayPage();

        }

        private void option3button_Click(object sender, EventArgs e)
        {
            if (page == 17)
            {
                page = 24;
            }

            displayPage();

        }

        public void displayPage()
        {
            switch (page)
            {
                case 1:
                    storyOutputLabel.Text = "You wake up on a beach near a dense jungle.";
                    option1Label.Text = "Set up camp";
                    option2Label.Text = "Explore the beach";

                    pictureBox.BackgroundImage = Properties.Resources.beachJungle;

                    break;
                case 2:
                    storyOutputLabel.Text = "Build a campfire?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.BackgroundImage = Properties.Resources.campfire;

                    break;
                case 3:
                    storyOutputLabel.Text = "You find a running stream and its getting dark.";
                    option1Label.Text = "Drink and Leave";
                    option2Label.Text = "Sleep here for the night";

                    pictureBox.BackgroundImage = Properties.Resources.jungleStream;

                    break;
                case 4:
                    storyOutputLabel.Text = "You start to get reall thirsty and the only water around is the ocean.";
                    option1Label.Text = "Go to sleep";
                    option2Label.Text = "Take a drink from the ocean";

                    pictureBox.BackgroundImage = Properties.Resources.beachJungle;

                    break;
                case 5:
                    storyOutputLabel.Text = "It gets dark and you die from a lurking panther. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.panther;

                    break;
                case 6:
                    storyOutputLabel.Text = "You find a little shack in the jungle. Do you enter?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.jungleShack;

                    break;
                case 7:
                    storyOutputLabel.Text = "You die from a disease in the water. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.jungleStream;

                    break;
                case 8:
                    storyOutputLabel.Text = "You wake up. Do you want to go deeper into the jungle?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.jungleStream;

                    break;
                case 9:
                    storyOutputLabel.Text = "You go to sleep and never wake up. Something or someone killed you while you were sleeping.\n Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.darkJungle;

                    break;
                case 10:
                    storyOutputLabel.Text = "The ocean water is too salty and you die from dehydration. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.beachJungle;

                    break;
                case 11:
                    storyOutputLabel.Text = "Theres a key on the ground. Take it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.key;

                    break;
                case 12:
                    storyOutputLabel.Text = "You go deeper into the jungle and die from a falling tree. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.darkJungle;

                    break;
                case 13:
                    storyOutputLabel.Text = "Before you leave you see a nice rock. Do you take it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.rock;

                    break;
                case 14:
                    storyOutputLabel.Text = "A tribe of indigenous people find you, you become one of them and survive the horros of the jungle. \n Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.jungleTribe;

                    break;
                case 15:
                    option2Button.Visible = false;

                    storyOutputLabel.Text = "You put the key in your pocket and keep exploring the shack.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.jungleShack;

                    break;
                case 16:
                    option2Button.Visible = false;

                    storyOutputLabel.Text = "You keep exploring the shack";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.jungleShack;

                    break;
                case 17:
                    option3Label.Visible = true;
                    option3button.Visible = true;

                    storyOutputLabel.Text = "A group of monkeys jump out of the bushes. Do you beat one to death?";
                    option1Label.Text = "Tame";
                    option2Label.Text = "Yes";
                    option3Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.monkeys;

                    break;
                case 18:
                    storyOutputLabel.Text = "A group of monkeys jump out of the bushes. They kill you because you had no way of defending yourself. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.monkeys;

                    break;
                case 19:
                    option2Button.Visible = true;

                    storyOutputLabel.Text = "You find a hatch in the shack that has a lock on it.Try to open it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.hatch;

                    break;
                case 20:
                    storyOutputLabel.Text = "The hatch opened to a bunker that has food and supplies for a liftime. You survive. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.bunker;

                    break;
                case 21:
                    storyOutputLabel.Text = "You cant unlock it. Go back and grab the key?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.hatch;

                    break;
                case 22:
                    storyOutputLabel.Text = "You die from starvation. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.youDied;

                    break;
                case 23:
                    option3button.Visible = false;
                    option3Label.Visible = false;

                    storyOutputLabel.Text = "The monkeys beat you to death. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.monkeys;

                    break;
                case 24:
                    option3button.Visible = false;
                    option3Label.Visible = false;

                    storyOutputLabel.Text = "You die of starvation because you spared the monkeys. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.monkeys;

                    break;
                case 25:
                    option3button.Visible = false;
                    option3Label.Visible = false;

                    storyOutputLabel.Text = "You keep the dead monkeys body for food. Make a fire and cook the monkey?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.campfire;

                    break;
                case 26:
                    storyOutputLabel.Text = "The key is not there anymore. You start to get really hungry and die of starvation. \nPlay Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.key;

                    break;
                case 27:
                    storyOutputLabel.Text = "You stand up and trip a trip wire. A hammer falls and kills you. \nPlay Again.";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.tripwire;

                    break;
                case 28:
                    storyOutputLabel.Text = "You cooked up the monkey and had a good feast. After you eat it a tribe finds you. They worship the monkey god and see that you ate a monkey so they kill you. \nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.youDied;

                    break;
                case 29:
                    storyOutputLabel.Text = "The monkey had Ebola and you die from it. \nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.youDied;

                    break;
                case 30:
                    storyOutputLabel.Text = "Because of your stubbornness you die of starvation. \nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox.BackgroundImage = Properties.Resources.youDied;

                    break;
                case 99:
                    storyOutputLabel.Text = "Thank you for playing.";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    pictureBox.BackgroundImage = Properties.Resources.thank;

                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();

                    break;
            }
        }
    }
}
