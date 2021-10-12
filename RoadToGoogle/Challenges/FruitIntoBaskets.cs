using System;

namespace RoadToGoogle.Challenges
{
    public static class FruitIntoBaskets
    {
        public static int TotalFruit(int[] tree)
        {
            //because there is no fruits yet that's why it's not existing integer (we are not using negatives values in the array b)
            int last_fruit = -1;
            int second_last_fruit = -1;
            int last_fruit_count = 0;
            int current_max = 0;
            int max = 0;

            foreach (var fruit in tree)
            {
                if (fruit == last_fruit || fruit == second_last_fruit)
                {
                    current_max += 1;
                }
                else
                {
                    current_max = last_fruit_count + 1;
                }

                if (fruit == last_fruit)
                {
                    // we just incrementing the count
                    last_fruit_count += 1;
                }
                else
                {
                    //we see a new fruit and it's a first new fruit
                    last_fruit_count = 1;

                    //then we need to swith them
                    second_last_fruit = last_fruit;
                    last_fruit = fruit;
                }
             

                max = Math.Max(current_max, max);
            }

            return max;
        }
    }
}
