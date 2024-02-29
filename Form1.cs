/////////////////////////////////////   
/// 2/7/2024 Develped Gui TIc tack toe buttons 
/// 2/7/2024 Event handled buttons
/// 2/7/2024 Made grid of player 1 or 2
/// 2/7/2024 winCheck to see if the player got three in a row.
/// 2/7/2024 Reset event-handler developed resets everything.
/// 2/8/2024 took appart button click and make executBtn a seperate method
/// 2/8/2024 made tieCheck()
/// 2/8/2024 made pickRandomBtn() this plays as the computer when called
/// 2/8/2024 The buttons will become de-enabled when pressed.
/// 2/10/2024 updated start button logic
/// 2/10/2024 Event handling update for start button reset button NOW new game
/// 2/10/2024 Event handling for FULL reset button.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///
/// This .cs file will handle all exceptions and also compute all logic for the 
/// Tic Tak Toe game
///
///
namespace TikTakToe

{
    public partial class Form1 : Form
    {

        int playerTurn = 0;

        int[,] grid = new int[3, 3];

        int playCounts = 0;

        int playTiesAmount = 0;

        int player1Wins = 0;
        int player2Wins = 0;

        string player1name = "player 1";

        public Form1()
        {
            InitializeComponent();
            greyButtonsOut(false);
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }
        //start button
        //When the game is started, the user can not play till pressing the start buttom
        //This will input the player name into the stats
        // will also enable the buttons
        private void startBtn_Click(object sender, EventArgs e)
        {
            player1name = playerInputName.Text;

            Player1Label.Text = player1name;
            string player = player1name;

            startBtn.Enabled = false;
            greyButtonsOut(true);

            Random random = new Random();
            playerTurn = random.Next(1, 3);
            if (playerTurn == 2)
            {
                player = "Computer";
                pickRandomBtn();
            }


            displayBox.Text = $"{player}'s Turn";
            //restartBtn_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // when a grid button is pressed for the player to play this will start.
        // This will invoke a the executeBtn.
        // if the player is a computer then it will be player turn 2
        // and will get a random available button and then invoke executeBtn
        // 
        private void gridBtn_Click(object sender, EventArgs e)
        {
            // what the grid looks like
            // gridArray [[1,2,3],
            //            [4,5,6],
            //            [7,8,9]]

            Button btn = (Button)sender;

            int row = Grid.GetRow(btn);
            int col = Grid.GetColumn(btn);

            executBtn(btn, row, col);

            //This plays the computer to turn off just Comment out
            if (playerTurn == 2)
            {
                pickRandomBtn();
            }

            //shows where it is in the array in a message box 
            //FOR TESTING
            //ShowGrid();
        }


        //This method will: Check to see whos turn it is and update the button text 
        //and check if there is a tie. It will assign the player a 1 or 2 in grid array
        //                  
        //Paras: btn, row of button cell, col of button cell
        private void executBtn(Button btn, int row, int col)
        {

            if (playerTurn == 0)
            {
                playerTurn = 1;
            }
            switch (playerTurn)
            {
                case 1:
                    btn.Text = "X";
                    playCounts++;

                    grid[row, col] = playerTurn;
                    btn.Enabled = false;
                    if (true == winCheck(playerTurn))
                    {
                        displayBox.Text = $"Good Job {player1name} Won!";
                        player1Wins++;
                        P1WinsLabel.Text = player1Wins.ToString();
                        playerTurn = 0;
                        greyButtonsOut(false);

                        break;
                    }

                    if (tieCheck() == true)
                    {
                        displayBox.Text = $"The Game was Tied";
                        playerTurn = 0;
                        break;
                    }

                    playerTurn = 2;


                    break;

                case 2:
                    btn.Text = "O";
                    playCounts++;
                    grid[row, col] = playerTurn;
                    btn.Enabled = false;

                    if (true == winCheck(playerTurn))
                    { /*displayBox.Text = $"Player {playerTurn} Won!";*/
                        displayBox.Text = $"The Computer Won!";
                        player2Wins++;
                        P2WinsLabel.Text = player2Wins.ToString();
                        playerTurn = 0;
                        greyButtonsOut(false);
                        break;
                    }
                    if (tieCheck() == true)
                    {
                        displayBox.Text = $"The Game was Tied";
                        playerTurn = 0;
                        break;
                    }

                    playerTurn = 1;
                    displayBox.Text = $"{player1name}'s Turn";
                    break;

            }
        }

        // Pick a random btn on the board. Acts as the computer.
        // uses a switch to pick between 1-9 of the buttons then
        // pull the row and column data and checks so see if the 
        // spot has been taken.
        private void pickRandomBtn()
        {
            bool foundEmptyBtn = false;
            while (foundEmptyBtn == false)
            {
                //pick a number between 1 - 9 
                Random random = new Random();
                int randomBtn = random.Next(1, 10);

                //checks grid if spot has been taken.
                switch (randomBtn)
                {
                    case 1:
                        int row = Grid.GetRow(gridBtn1);
                        int col = Grid.GetColumn(gridBtn1);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn1, row, col);

                            foundEmptyBtn = true;
                        }
                        break;

                    case 2:
                        row = Grid.GetRow(gridBtn2);
                        col = Grid.GetColumn(gridBtn2);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn2, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 3:
                        row = Grid.GetRow(gridBtn3);
                        col = Grid.GetColumn(gridBtn3);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn3, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 4:
                        row = Grid.GetRow(gridBtn4);
                        col = Grid.GetColumn(gridBtn4);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn4, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 5:
                        row = Grid.GetRow(gridBtn5);
                        col = Grid.GetColumn(gridBtn5);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn5, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 6:
                        row = Grid.GetRow(gridBtn6);
                        col = Grid.GetColumn(gridBtn6);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn6, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 7:
                        row = Grid.GetRow(gridBtn7);
                        col = Grid.GetColumn(gridBtn7);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn7, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 8:
                        row = Grid.GetRow(gridBtn8);
                        col = Grid.GetColumn(gridBtn8);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn8, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    case 9:
                        row = Grid.GetRow(gridBtn9);
                        col = Grid.GetColumn(gridBtn9);
                        if (grid[row, col] == 0)
                        {
                            grid[row, col] = 2;
                            executBtn(gridBtn9, row, col);

                            foundEmptyBtn = true;
                        }
                        break;
                    default:
                        displayBox.Text = "There is an error in the pickRandomNum() Switch";
                        break;
                }
            }
        }

        //This method will check how many plays there have been
        //if there is 9 turns played then it will be a tie.
        private bool tieCheck()
        {
            if (playCounts >= 9 && winCheck(playerTurn) == false)
            {
                playTiesAmount++;
                PlayerTies.Text = playTiesAmount.ToString();
                return true;

            }
            else
            {
                return false;
            }
        }


        //this method will check if there is a THREE in a row.
        private bool winCheck(int playerTurn)
        {
            //grid[ cols rows,]
            //----------- horizontal wins --------------
            if (grid[0, 0] == playerTurn && grid[0, 1] == playerTurn && grid[0, 2] == playerTurn)
            {
                return true;
            }
            if (grid[1, 0] == playerTurn && grid[1, 1] == playerTurn && grid[1, 2] == playerTurn)
            {
                return true;
            }
            if (grid[2, 0] == playerTurn && grid[2, 1] == playerTurn && grid[2, 2] == playerTurn)
            {
                return true;
            }
            //----------- Vertical wins --------------
            if (grid[0, 0] == playerTurn && grid[1, 0] == playerTurn && grid[2, 0] == playerTurn)
            {
                return true;
            }
            if (grid[0, 1] == playerTurn && grid[1, 1] == playerTurn && grid[2, 1] == playerTurn)
            {
                return true;
            }
            if (grid[0, 2] == playerTurn && grid[1, 2] == playerTurn && grid[2, 2] == playerTurn)
            {
                return true;
            }
            //----------- diagonal --------------
            if (grid[0, 0] == playerTurn && grid[1, 1] == playerTurn && grid[2, 2] == playerTurn)
            {
                return true;
            }
            if (grid[0, 2] == playerTurn && grid[1, 1] == playerTurn && grid[2, 0] == playerTurn)
            {
                return true;
            }

            else

                return false;

        }

        //This resets the grid to all zeros
        //resets all the grid Buttons text
        //will not reset player name 
        //or amount of game play wins/tie
        //acts as NEW GAME
        private void restartBtn_Click(object sender, EventArgs e)
        {

            greyButtonsOut(true);
            grid = new int[3, 3];
            gridBtn1.Text = "";
            gridBtn2.Text = "";
            gridBtn3.Text = "";
            gridBtn4.Text = "";
            gridBtn5.Text = "";
            gridBtn6.Text = "";
            gridBtn7.Text = "";
            gridBtn8.Text = "";
            gridBtn9.Text = "";

            playCounts = 0;

            string player = "Player 1";
            Random random = new Random();
            playerTurn = random.Next(1, 3);
            if (playerTurn == 2)
            {
                player = "Computer";
                pickRandomBtn();
            }
            displayBox.Text = $"{player}'s Turn";
        }


        //Will grey out grid buttons
        private void greyButtonsOut(bool enable)
        {

            gridBtn1.Enabled = enable;
            gridBtn2.Enabled = enable;
            gridBtn3.Enabled = enable;
            gridBtn4.Enabled = enable;
            gridBtn5.Enabled = enable;
            gridBtn6.Enabled = enable;
            gridBtn7.Enabled = enable;
            gridBtn8.Enabled = enable;
            gridBtn9.Enabled = enable;
        }

        //This will fully reset the game to init state.
        private void fullResetBtn_Click(object sender, EventArgs e)
        {
            player1Wins = 0;
            player2Wins = 0;
            P1WinsLabel.Text = player1Wins.ToString();
            P2WinsLabel.Text = player2Wins.ToString();


            Player1Label.Text = "Player 1";

            playerInputName.Text = "Player 1";

            startBtn.Enabled = true;
            greyButtonsOut(false);
            playCounts = 0;

            restartBtn_Click(sender, e);
            displayBox.Text = $"Press start to Play";

        }
        //This will display the grid and player number in a message box
        private void ShowGrid()
        {
            // Iterate over rows
            string gridString = "gridArray [\n";
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                // Iterate over columns
                gridString += "            [";
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    gridString += grid[i, j].ToString();
                    if (j < grid.GetLength(1) - 1)
                    {
                        gridString += ", ";
                    }
                }
                gridString += "]" + (i < grid.GetLength(0) - 1 ? ",\n" : "\n");
            }
            gridString += "          ]";

            // Display the grid in a message box
            MessageBox.Show(gridString, "Grid State");
        }
    }


}
