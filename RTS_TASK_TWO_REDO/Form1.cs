using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS_TASK_TWO_REDO
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        Timer timer;
        GameState gameState = GameState.PAUSED;

        public enum GameState
        {
            RUNNING,
            PAUSED,
            ENDED
        }

        public Form1()
        {
            InitializeComponent();
            engine = new GameEngine();
            UpdateUI();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
        }
        public void UpdateUI() //Updates the displays for both the map and textbox
        {
            mapLabel.Text = engine.MapDisplay;
            roundLabel.Text = "Round: " + engine.Round;
            unitInfoTextBox.Text = engine.UnitInfo();
            resourceTextBox.Text = engine.BuildingInfo();
            unitLabel.Text = "Num.Units: " + engine.NumUnits;
            buildingLabel.Text = "Num.Buildings: " + engine.NumBuildings;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            engine.GameLoop();
            UpdateUI();

            if (engine.IsGameOver)
            {
                timer.Stop();
                UpdateUI();
                mapLabel.Text = engine.WinningTeam + " IS THE VICTOR! \n" + mapLabel.Text;
                gameState = GameState.ENDED;
                startPauseButton.Text = "RESTART?";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartPauseButton_Click(object sender, EventArgs e)
        {
            if (gameState == GameState.RUNNING) //Checks the game state
            {
                timer.Stop();
                gameState = GameState.PAUSED;
                startPauseButton.Text = "Start";
            }
            else
            {
                if (gameState == GameState.ENDED)
                {
                    engine.Reset();
                }

                timer.Start();
                gameState = GameState.RUNNING;
                startPauseButton.Text = "Pause";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            engine.SaveGame();
            mapLabel.Text = "GAME HAS BEEN SAVED\n" + mapLabel.Text;
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            engine.LoadGame();
            mapLabel.Text = "GAME HAS BEEN LOADED\n" + engine.MapDisplay;
        }
    }
}
