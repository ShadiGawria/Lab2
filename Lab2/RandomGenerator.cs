using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RandomGenerator
    {
        public Random rand = new Random();


        public int RandomNr()
        {
            int randomNumber;
            randomNumber = rand.Next(0,5);
            
            return randomNumber;

        }
    }
}
