//Dilara Ademoglu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_hw1
{
    class SimAnneal
    {
        int numQueens;
        public int[] queenPositions; //this is the board, index is column and value is row
        System.Windows.Forms.Label Lblnum;
        System.Windows.Forms.Label lblStep;
        double temperature;
        double coolFac;
        int steps = 0;

        public SimAnneal(int size, System.Windows.Forms.Label Lblnum, System.Windows.Forms.Label lblStep, double temp, double coolF)
        {
            this.numQueens = size; //get size from user
            this.queenPositions = new int[size];
            this.Lblnum = Lblnum;
            this.lblStep = lblStep;
            this.temperature = temp;
            this.coolFac = coolF;
        }

        private int[] randomizeQueens() //randomly generate queens
        {
            List<int> randPos = new List<int>();
            Random r = new Random();
            for (int i = 0; i < numQueens; i++)
            {
                randPos.Add(r.Next(numQueens));
            }
            int[] randomPositions = new int[numQueens];
            for (int i = 0; i < randPos.Count(); i++)
            {
                randomPositions[i] = randPos.ElementAt(i);
            }
            return randomPositions;
        }

        public int getHeuristic(int[] r) //heuristic cost function
        { //r is the random queen positions, aka board
            int h = 0;
            // increment cost if two queens are in same row or in same diagonal.
            for (int i = 0; i < r.Length; i++) //r.Length is number of queens
            {
                for (int j = i + 1; j < r.Length; j++)
                {
                    if (r[i] == r[j] || Math.Abs(r[i] - r[j]) == j - i) //if queens are in the same row OR same diagonal
                    {
                        h += 1;
                    }
                }
            }
            return h;
        }
        public int[] solve(int maxNumIt, double temperature, double coolingFac)
        {
            this.queenPositions = randomizeQueens();
            int[] r = this.queenPositions;
            int h = getHeuristic(r);

            for (int i = 0; i < maxNumIt && h > 0; i++)
            {
                r = makeMove(r, h, temperature);
                h = getHeuristic(r);
                temperature = Math.Max((temperature * coolingFac), 0.01);
                steps++;
            }
            string s = (h).ToString();
            Lblnum.Text = s;
            lblStep.Text = steps.ToString();
            this.queenPositions = r;
            return h == 0 ? r : null; // return solution if solved
        }

        private int[] makeMove(int[] r, int costToBeat, double temp)
        {
            int n = numQueens;
            Random rand = new Random();
            bool check = false;
            while (!check)
            {
                int nCol = rand.Next(n);
                int nRow = rand.Next(n);
                int tmpRow = r[nCol];
                r[nCol] = nRow;

                int cost_new = getHeuristic(r);
                if (cost_new < costToBeat)
                    check = true;
                else
                {
                    int dE = costToBeat - cost_new;
                    //Probability can never exceed 1
                    double ratio = Math.Exp(dE / temp);
                    double acceptProb = Math.Min(1, ratio);
                    if (rand.NextDouble() <= acceptProb)
                        check = true;
                    r[nCol] = tmpRow;
                }
            }
            return r;
        }
    }
}
