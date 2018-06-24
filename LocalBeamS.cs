//Dilara Ademoglu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_hw1
{
    struct state
    {
        public int[] states;
        public int h;
        public state(int[] s, int heur)
        {
            states = s;
            h = heur;
        }
    };
    class LocalBeamS
    {
        int steps = 0;
        System.Windows.Forms.Label Lblnum;
        System.Windows.Forms.Label lblStep;
        int numQueens;
        public int[] queenPositions;
        int numOfStates;

        public LocalBeamS(int size, int numStates, System.Windows.Forms.Label Lblnum, System.Windows.Forms.Label lblStep)
        {
            this.lblStep = lblStep;
            this.Lblnum = Lblnum;
            this.numQueens = size;
            this.numOfStates = numStates;
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

        public int[] solveLBS(int maxNumIt)
        {
            //state s = new state();
            int h = 0;
            List<state> stateList = new List<state>();
            state s;
            for (int i = 0; i < numOfStates; i++) //k states
            {
                int[] k = randomizeQueens(); //one state
                //this.queenPositions = k;
                h = getHeuristic(k); //get h for each state
                s = new state(k, h);
                stateList.Add(s); //randomly generated k states
            }
            int newNum = numOfStates * numQueens; //size of newStatesList
            state[] sList = new state[newNum];
    
            for (int i = 0; i < newNum; i++)
            {
                sList[i].h = 1000;
            }
            List<state> newStatesList;
                for (int i = 0; i < maxNumIt; i++) //do we need this?
                {
                    //generate successors of k states
                    for (int j = 0; j < numOfStates; j++)
                    {
                        int h1 = stateList.ElementAt(j).h;
                        Lblnum.Text = (h1).ToString(); //show h on GUI
                        if (h1 == 0) //if solved
                        {
                            int[] r = stateList.ElementAt(j).states;
                            this.queenPositions = r;
                            return r;
                        }

                        for (int col = 0; col < numQueens; col++) //generate successors of k states
                        {
                            int index = (j * numQueens) + col;
                            int h_stat = stateList.ElementAt(j).h;
                            
                            int[] stat = makeMove(stateList.ElementAt(j).states, col, h_stat);
                            state m;
                            if (stat != null)
                            {
                                int h_new = getHeuristic(stat);
                                m = new state(stat, h_new);
                                sList[index] = m;
                            }
                            else
                            {
                                m = new state(stat, 1000);
                            }

                            if (sList[index].states==null) //if stuck
                            {
                                int[] rq = randomizeQueens();
                                int rh = getHeuristic(rq);
                                state nk = new state(rq, rh);
                                sList[index] = nk;
                            }

                        }
                    }
                    //here comes the sorting part
                    newStatesList = sList.ToList();
                    newStatesList = newStatesList.OrderBy(sel => sel.h).ToList();
                    
                    List<state> copyStateList = new List<state>();
                    for (int a = 0; a < numOfStates; a++) //use the k best successors
                    {
                        copyStateList.Add(newStatesList.ElementAt(a));
                    }
                    stateList.Clear();
                    stateList = copyStateList;

                    steps++;
                    lblStep.Text = steps.ToString();
                }
            return null;
        }
        private int[] makeMove(int[] r, int col, int h) //r is the state
        {
            int n = numQueens;

            for (int row = 0; row < n; row++)
            {
                // we do not need to evaluate because we already know current h
                if (row == r[col])
                    continue;

                int tmpRow = r[col];
                r[col] = row;
                int cost = getHeuristic(r);
                if (h > cost)
                {
                    r[col] = row;
                    return r;
                }
                r[col] = tmpRow;
            }
            return null;
        }
    }
}

