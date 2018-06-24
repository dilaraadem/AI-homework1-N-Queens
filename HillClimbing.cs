//Dilara Ademoglu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_hw1
{
    class HillClimbing
    {
        int numQueens;
        public int[] queenPositions; //this is the board, index is column and value is row
        System.Windows.Forms.Label Lblnum;
        System.Windows.Forms.Label lblStep;

        public HillClimbing(int size, System.Windows.Forms.Label Lblnum,System.Windows.Forms.Label lblStep)
        {
            this.numQueens = size; //get size from user
            this.queenPositions = new int[size];
            this.Lblnum = Lblnum;
            this.lblStep = lblStep;
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

        public int[] solve(int maxNumIt)
        {
            this.queenPositions = randomizeQueens();
            int[] r = this.queenPositions;
            int n = this.numQueens;
            int steps = 0;
            int h_beat = getHeuristic(r); //first cost
            for (int i = 0; i < maxNumIt && h_beat> 0; i++) //terminate when max num of it or h=0
            {
                bool check = true;
                int h_temp = h_beat;
                for (int col = 0; col < n && check; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        if (row == r[col])
                            continue;
                        int[] rc = new int[n];
                        rc = r;
                        rc[col] = row;
                        int cost = getHeuristic(rc);
                        if (h_beat > cost)
                        {
                            r[col] = row;
                            h_beat = cost;
                            check = false;
                            break;
                        }
                    }
                }
                if (h_temp == h_beat) //get stuck at local maxima
                {
                    this.queenPositions = r;
                    r = randomizeQueens();
                }
                string s = (h_beat).ToString();
                Lblnum.Text = s;
                steps++;
                lblStep.Text = steps.ToString();
            }
            this.queenPositions = r;
            return h_beat == 0 ? r : null; ;
        }
    }
}
