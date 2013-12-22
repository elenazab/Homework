using System;
using System.Collections.Generic;

namespace hw1t2
{
    class Network
    {

        public Network(int n, int[][] nn, Random rnd)
        {
            this.Initialisation(n, nn, rnd);
        }

        private void Initialisation(int n, int[][] nn, Random rnd)
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
                    Windows tmpOS2 = new Windows();
                }
                myNetwork[i].SetVirus();
                myNetwork[i].rnd = rnd;
            }
        }


        //а тут обход всех компов, каждый   ход - проверка каждого и попытка закинуь вирус соседям
        public void Step()
        {
            List<int> tmpList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (myNetwork[i].Virus)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (neighbours[i][j] == 1)
                            //myNetwork[j].SetVirus();
                            tmpList.Add(j);
                    }
                }
            }
            foreach (var i in tmpList)
            {
                myNetwork[i].SetVirus();
            }
        }
        private OS[] myNetwork;
        private int[][] neighbours;
        private int n;//число компов. может и не нужно?
    }
}
