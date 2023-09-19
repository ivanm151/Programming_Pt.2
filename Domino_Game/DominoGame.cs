using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino_Game
{
    public class Domino
    {
        Random rand;
        private int[] sides = new int[2];
        public Domino()
        {
            rand = new Random();
            sides[0] = rand.Next(1, 7);
            sides[1] = rand.Next(1, 7);
        }
        public void set_user_value(int[] nums)
        {
            sides[0] = nums[0];
            sides[1] = nums[1];
        }
        public int[] get_value()
        {
            return sides;
        }   
        public void turn()
        {
            int temp = sides[0];
            sides[0] = sides[1];
            sides[1] = temp;
        }
    }
}
