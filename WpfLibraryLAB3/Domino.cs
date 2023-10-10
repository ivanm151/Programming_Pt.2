using System;

namespace WpfLibraryLAB3
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
        public void value_up()
        {
            int[] nums = this.get_value();
            int[] new_nums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) { new_nums[i] = nums[i]; }
            for (int i = 0; i < nums.Length; i++)
            {
                new_nums[i] = nums[i];
                if (nums[i] < 6)
                {
                    new_nums[i] = nums[i] + 1;
                    this.set_user_value(new_nums);
                }
                else
                {
                    new_nums[i] = 6;
                    this.set_user_value(new_nums);
                }
            }
        }
    }
}
