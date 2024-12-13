using System;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Button[,] boardButtons;
        private string currentPlayer;
        private bool gameOver;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            boardButtons = new Button[3, 3];
            currentPlayer = "X";
            gameOver = false;
            lblCurrentPlayer.Text = "Gracz X rozpoczyna";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardButtons[i, j] = new Button
                    {
                        Size = new System.Drawing.Size(100, 100),
                        Location = new System.Drawing.Point(i * 100, j * 100),
                        Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold)
                    };
                    boardButtons[i, j].Click += BoardButton_Click;
                    Controls.Add(boardButtons[i, j]);
                }
            }

            Button newGameButton = new Button
            {
                Text = "Nowa Gra",
                Size = new System.Drawing.Size(100, 50),
                Location = new System.Drawing.Point(350, 200)
            };
            newGameButton.Click += NewGameButton_Click;
            Controls.Add(newGameButton);
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            Button clickedButton = sender as Button;
            if (clickedButton.Text != "") return;

            clickedButton.Text = currentPlayer;
            if (CheckWin())
            {
                lblCurrentPlayer.Text = $"{currentPlayer} Wygral!";
                gameOver = true;
            }
            else if (CheckDraw())
            {
                lblCurrentPlayer.Text = "Remis!";
                gameOver = true;
            }
            else
            {
                currentPlayer = currentPlayer == "X" ? "O" : "X";
                lblCurrentPlayer.Text = $"{currentPlayer}'twoja kolej ";
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (boardButtons[i, 0].Text == currentPlayer &&
                    boardButtons[i, 1].Text == currentPlayer &&
                    boardButtons[i, 2].Text == currentPlayer)
                    return true;

                if (boardButtons[0, i].Text == currentPlayer &&
                    boardButtons[1, i].Text == currentPlayer &&
                    boardButtons[2, i].Text == currentPlayer)
                    return true;
            }

            if (boardButtons[0, 0].Text == currentPlayer &&
                boardButtons[1, 1].Text == currentPlayer &&
                boardButtons[2, 2].Text == currentPlayer)
                return true;

            if (boardButtons[0, 2].Text == currentPlayer &&
                boardButtons[1, 1].Text == currentPlayer &&
                boardButtons[2, 0].Text == currentPlayer)
                return true;

            return false;
        }

        private bool CheckDraw()
        {
            foreach (Button button in boardButtons)
            {
                if (button.Text == "") return false;
            }
            return true;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            foreach (Button button in boardButtons)
            {
                button.Text = "";
            }

            currentPlayer = "X";
            gameOver = false;
            lblCurrentPlayer.Text = "Gracz X rozpoczyna";
        }
    }
}
