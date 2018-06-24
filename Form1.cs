//Dilara Ademoglu
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace AI_hw1
{
    public partial class Form1 : Form
    {
        List<PictureBox> queens;
        Panel[,] board;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetBtn_Click(object sender, EventArgs e)            //Startbutton
        {
            if (cmbBxSize.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                if (cmbBxSize.SelectedItem == null)
                    MessageBox.Show("Please select the size of the board!");
                else
                    MessageBox.Show("Please select the algorithm!");
            }
            else
            {
                int size = Int32.Parse(cmbBxSize.SelectedItem.ToString());
                CreateTable(size);
                string selected = comboBox1.Text;
                if (selected.Equals("Genetic Algorithm"))
                {
                    this.GAParamPanel.Visible = true;
                    this.HCpanel.Visible = false;
                }
                else if (selected.Equals("Local Beam Search"))
                {
                    this.panel2.Visible = true;
                    this.HCpanel.Visible = true;
                }
                else if (selected.Equals("Simulated Annealing"))
                {
                    this.panel1.Visible = true;
                    this.HCpanel.Visible = true;
                }
                else if (selected.Equals("Hill Climbing"))
                {
                    this.HCpanel.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateTable(int gridSize) //create the chessboard with this function, size as parameter
        {
            var clr1 = Color.Black;
            var clr2 = Color.White;
            Panel[,] _chessBoardPanels = new Panel[gridSize, gridSize];
            int tileSize = 60;
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // create new Panel control which will be one chess board tile
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(25 + tileSize * n, 25 + tileSize * m)
                    };

                    Controls.Add(newPanel); // add to Form's Controls so that they show up

                    _chessBoardPanels[n, m] = newPanel;// add to our 2d array of panels for future use

                    if (n % 2 == 0) // color the backgrounds
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                }
            }
            board = _chessBoardPanels;
            DrawQueen(gridSize, board);
        }

        private void QueenList()
        {
            queens = new List<PictureBox>();
            queens.Add(queen1);
            queens.Add(queen2);
            queens.Add(queen3);
            queens.Add(queen4);
            queens.Add(queen5);
            queens.Add(queen6);
            queens.Add(queen7);
            queens.Add(queen8);
        }

        private void DrawQueen(int gridSize, Panel[,] board) //initial queen drawing
        {
            QueenList();
            for (int i = 0; i < gridSize; i++)
            {
                queens[i].Location = board[i, 0].Location;
                queens[i].Visible = true;
            }
        }

        private void ClearTable()
        {
            Controls.Clear();
            InitializeComponent();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearTable();
        }
        private void placeQ(int size, int[] res, Panel[,] board)
        {
            for (int i = 0; i < size; i++)
            {
                queens[i].Visible = false;
                queens[i].Location = (board[res[i], i]).Location;
                queens[i].Visible = true;
            }
        }
        private void SolveHillClimb(int size) //hill climbing here
        {
            int maxNumIt = (int)(numericUpDownHC.Value);
            HillClimbing HC = new HillClimbing(size, lblHeuNum, stepCount);
            int[] res = HC.solve(maxNumIt);
            int[] r = HC.queenPositions;
            placeQ(size, r, board);
        }
        private void SolveSimAnn(int size)
        {
            int maxNumIt = (int)(numericUpDownHC.Value);
            double temperature = double.Parse(textBox1.Text);
            double coolF = Convert.ToDouble(textBox2.Text);
            SimAnneal SA = new SimAnneal(size, lblHeuNum, stepCount, temperature, coolF);
            int[] res = SA.solve(maxNumIt, temperature, coolF);
            int[] r = SA.queenPositions;
            placeQ(size, r, board);
        }
        private void SolveLocBeamS(int size)
        {
            int maxNumIt = (int)(numericUpDownHC.Value); //normally dont need this, but takes too long if we dont use this
            int numStates = Int32.Parse(textBox3.Text);
            LocalBeamS LBS = new LocalBeamS(size, numStates, lblHeuNum, stepCount);
            int[] res = LBS.solveLBS(maxNumIt);
            int[] r = LBS.queenPositions;
            if (r != null)
            {
                placeQ(size, r, board);
                label1.Text = "";
            }
            else
                label1.Text = "Solution not found!";
        }
        private void SolveGA(int size)
        {
            int popSize = (int)(numericUpDown1.Value);
            int generations = (int)(numericUpDown2.Value);
            double crossProb = (double)(numericUpDown3.Value); //probablity must be smaller than size. Write if cond.
            double mutProb = (double)(numericUpDown4.Value);
            double percentElit = (double)(numericUpDown5.Value); //baştan kaç tane state seçileceği?

            GeneticAlgo GA = new GeneticAlgo(size, mutProb, crossProb, popSize, generations, percentElit,lblHeuNum,stepCount);
            //here, max num of iterations is the same thing with number of generations
            //delete one of them or hide
            int[] res = GA.solve();
            int[] r = GA.queenPositions;
            if (r != null)
                placeQ(size, r, board);
            else
                label1.Text = "Solution not found!";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int size = Int32.Parse(cmbBxSize.SelectedItem.ToString());

            if (comboBox1.Text.Equals("Hill Climbing"))
            {
                SolveHillClimb(size);
            }
            else if (comboBox1.Text.Equals("Simulated Annealing"))
            {
                SolveSimAnn(size);
            }
            else if (comboBox1.Text.Equals("Local Beam Search"))
            {
                SolveLocBeamS(size);
            }
            else if (comboBox1.Text.Equals("Genetic Algorithm"))
            {
                SolveGA(size);
            }
        }
    }
}
