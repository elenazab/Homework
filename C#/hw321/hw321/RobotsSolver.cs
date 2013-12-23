using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw321
{
    /// <summary>
    /// класс, для решения задачи про роботов
    /// </summary>
    public class RobotsSolver
    {

        /// <summary>
        /// конструктор класса для решения задачи про роботов
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rob"></param>
        public RobotsSolver(int[,] array, bool[] rob)
        {
            nodes = rob.Length;
            AdjacencyMatrix = array;
            color = new int[nodes];
            for (int i = 0; i < nodes; i++)
            {
                color[i] = 0;
            }
            robots = rob;
        }



        /// <summary>
        /// обход графа
        /// </summary>
        /// <param name="NodeNumber"></param>
        public void TraversingGraph(int NodeNumber)
        {
            if (color[NodeNumber] == 1)
            {
                return;
            }
            color[NodeNumber] = 1;
            for (int i = 0; i < nodes; i++)
            {
                if (AdjacencyMatrix[NodeNumber, i] == 1 && NodeNumber != i)
                {
                    for (int j = 0; j < nodes; j++)
                    {
                        if (AdjacencyMatrix[i, j] == 1 && i != j)
                        {
                            TraversingGraph(j);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// проверка возможности уничтожения роботов
        /// </summary>
        /// <returns></returns>
        public bool IsPossible()
        {
            TraversingGraph(0);
            int color1 = 0;
            int color2 = 0;
            for (int i = 0; i < nodes; i++)
            {
                if (color[i] == 1 && robots[i])
                    color1++;
                if (color[i] == 0 && robots[i])
                    color2++;
            }
            return (!(color1 == 1 || color2 == 1));
        }

        private int[] color;
        private int[,] AdjacencyMatrix;
        private bool[] robots;
        private int nodes;
    }
}
