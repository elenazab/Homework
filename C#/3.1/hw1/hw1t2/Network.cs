using System;
using System.Collections.Generic;

namespace hw1t2
{
    public class Network
    {

        public Network(int n, int[,] nn, Random rnd)
        {
            this.Initialisation(n, nn, rnd);
        }

        private void Initialisation(int n, int[,] nn, Random rnd)
        {
            neighbours = nn;
            this.n = n;
            myNetwork = new OS[n];
                for (int i = 0; i < n; i++)
                {
                    if (rnd.Next(0, 2) < 1)
                    {
                        myNetwork[i] = new Linux();
                    }
                    else
                    {
                        myNetwork[i] = new Windows();
                    }
                    myNetwork[i].rnd = new Random();
                    myNetwork[i].rnd = rnd;
                    myNetwork[i].SetVirus();
                }
        }


/// <summary>
/// обход компов с попыткой передать вирус соседям
/// </summary>
        public void Step()
        {
            List<int> tmpList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (myNetwork[i].Virus)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (neighbours[i,j] == 1)
                            tmpList.Add(j);
                    }
                }
            }
            foreach (var i in tmpList)
            {
                myNetwork[i].SetVirus();
            }
        }

        public bool getVirus(int i)
        {
            return myNetwork[i].Virus;
        }

        private OS[] myNetwork;
        private int[,] neighbours;
        private int n;
    }
}
