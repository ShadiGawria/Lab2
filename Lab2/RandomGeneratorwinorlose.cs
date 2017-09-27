using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RandomGeneratorwinorlose
    {
       public Random randomwinorlose1 = new Random();

        public int RandomWinorlose()
        {
            int randomwinorlose;
            randomwinorlose = randomwinorlose1.Next(0, 2);//1 or 0
           
            return randomwinorlose;
        }
    }
}
