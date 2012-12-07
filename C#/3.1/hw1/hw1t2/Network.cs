using System;

namespace hw1t2
{
    class Network
    {
        public Network(int n, int[][] nn)
        {
            neighbors = nn;
            this.n = n;
            myNetwork = Computer[n];
            for (int i = 0; i < n; i++)
            {
                var rnd = new Random();
                if (rnd.Next(0, 2) < 1)
                {
                    Linux tmpOS1 = new Linux();
                    myNetwork[i] = new Computer(true, tmpOS1);
                }
                else
                {
                    Windows tmpOS2 = new Windows();
                    myNetwork[i] = new Computer(false, tmpOS2);
                }
            }
        }
        //а тут обход всех компов, каждый   ход - проверка каждого и попытка закинуь вирус соседям
        public void step()
        {
            for (int i = 0; i < n; i++)
            {
                if (myNetwork[i].virus)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (neighbors[i][j] == 1)
                            myNetwork[j].SetVirus();
                    }
                }
            }

        }
        private Computer[] myNetwork;
        private int[][] neighbors;
        private int n;//число компов. может и не нужно?
    }
}
