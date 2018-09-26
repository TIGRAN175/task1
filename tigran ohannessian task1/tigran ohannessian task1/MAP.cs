using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigran_ohannessian_task1
{
    class MAP
    {
        int units = 0;

        public void mapgen()
        {


            // attempting to randomize the spawn locations on our map
            int posnew;
            Random rnd = new Random();


            int[,] maparray = new int[20, 20];
            for (int i = 0; i < 1; i++)
                for (int j = 0; j < 0; j++)
                    maparray[i, j] = rnd.Next(1, 20);
        }
    }
}
