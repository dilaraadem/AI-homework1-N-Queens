//Dilara Ademoglu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_hw1
{
    struct Chromosome //store genes and fitness score together
    {
        public int[] genes;
        public int fitness;
    }
    class GeneticAlgo
    {
        int popSize, gens;
        double crossProb, mutProb, percentElitism;
        int numQueens;
        public int[] queenPositions;
        int step = 0;
        System.Windows.Forms.Label Lblnum;
        System.Windows.Forms.Label lblStep;

        public GeneticAlgo(int size, double mutationProb, double crossoverProb, int populationSize, int generations, double percentElite, System.Windows.Forms.Label Lblnum, System.Windows.Forms.Label lblStep)
        {
            this.numQueens = size;
            this.crossProb = crossoverProb;
            this.gens = generations;
            this.mutProb = mutationProb;
            this.popSize = populationSize;
            this.percentElitism = percentElite;
            this.queenPositions = new int[size];
            this.lblStep = lblStep;
            this.Lblnum = Lblnum;
        }

        private int[] randomizeQueens() //randomly generate queens //for GA this is a set of genes, one chromosome
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
        public Chromosome[] Crossover(Chromosome[] population)
        {
            Random rand = new Random();
            for (int i = 0; i < population.Length; i += 2)
            {
                if (rand.NextDouble() < crossProb)
                //get a random value and check if it is smaller than crossover probability. 
                //If it is smaller then do crossover
                {
                    int crossPosition = rand.Next(numQueens); //crossover position selected randomly
                    for (int j = 0; j < crossPosition; j++)
                    {
                        int tmp = population[i].genes[j];
                        population[i].genes[j] = population[i + 1].genes[j];
                        population[i + 1].genes[j] = tmp;
                    }
                }
                population[i].fitness = calculateFitness(population[i].genes); //calculate fitness again
                population[i + 1].fitness = calculateFitness(population[i + 1].genes);
            }
            return population;
        }
        public int[] Mutate(int[] chro)
        {
            Random r = new Random();
            if (mutProb >= r.NextDouble()) //use mutation prob
            {
                int num = (int)(r.NextDouble() * chro.Length); //generate new value
                chro[num] = num; //mutate the gene
                return chro;
            }
            return chro;
        }
        public int getElitism()
        {
            int elitism = (int)((double)popSize * percentElitism);
            return elitism; //calculate elitism using percent of elitism
        }

        public Chromosome[] Select(Chromosome[] population)
        {
            List<Chromosome> pop = population.ToList();
            pop = pop.OrderBy(sel => sel.fitness).ToList();//sort
            pop.Reverse();

            for (int k = 0; k < population.Length; k++)
            {
                population[k] = pop.ElementAt(k);
            }
            int elit = getElitism(); //calculate number of elements to be selected
            Chromosome[] poplist = new Chromosome[elit];
            for (int i = 0; i < elit; i++)
            {
                poplist[i] = pop.ElementAt(i); //selected elements
            }
            if (elit != 0)
            {
                Chromosome[] popul = new Chromosome[population.Length];
                for (int k = 0; k < population.Length; k++)
                {
                    popul[k] = poplist[k % elit];
                }
                return popul;
            }
            return population;

        }

        public int getFitness(int n)
        {
            return n * (n - 1) / 2;
        }
        public int calculateFitness(int[] r)
        {
            int fitness = getFitness(r.Length) - getHeuristic(r);
            return fitness;
        }

        public int[] solve()
        {
            popSize = popSize - (popSize % 2); //cannot be an odd number, has to be pairs
            Chromosome[] chr = new Chromosome[popSize]; //array for storing population
            //first, generate population

            for (int i = 0; i < popSize; i++)
            {
                chr[i].genes = randomizeQueens();//create a chromosome
                chr[i].fitness = calculateFitness(chr[i].genes); //calculate fitness and add
            }
            int maxFitness = getFitness(numQueens);
            if (maxFitness % 2 != 0)
                maxFitness = maxFitness - 1;
            //enter the select-crossover-mutate cycle
            for (int i = 0; i < gens; i++) //N iterations //generations
            {
                chr = Select(chr);
                chr = Crossover(chr); //do crossover

                //compute fitness again
                for (int k = 0; k < popSize; k++)
                {
                    //chr[k].fitness = calculateFitness(chr[k].genes); //calculate fitness again
                    if (chr[k].fitness == maxFitness)
                    {
                        this.queenPositions = chr[k].genes;
                        Lblnum.Text = (getHeuristic(chr[k].genes)).ToString();
                        return chr[k].genes;
                    }
                    chr[k].genes = Mutate(chr[k].genes); //mutate each one
                    chr[k].fitness = calculateFitness(chr[k].genes);
                    if (chr[k].fitness == maxFitness)
                    {
                        this.queenPositions = chr[k].genes;
                        Lblnum.Text = (getHeuristic(chr[k].genes)).ToString();
                        return chr[k].genes;
                    }
                }
                step++;
                lblStep.Text = step.ToString();
                
            }
            Lblnum.Text = (getHeuristic(chr[0].genes)).ToString();
            this.queenPositions = null;
            return null;
        }
    }
}
