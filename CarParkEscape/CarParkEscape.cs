using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        private string direction = null;
        private int distanceIndex = 0;
        private int downIndex = 1;
        private int stairIndex = 0;
        public string[] Escape(int[,] carpark)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 1)
                    {
                        stairIndex = j;
                    }
                    if (direction == null && carpark[i, j] != 0)
                    {
                        direction = carpark[i, j] == 2 ? "R" : "L";
                    }
                    else if (direction != null)
                    {
                        distanceIndex++;
                        if (i == carpark.GetLength(0) - 1 && j == carpark.GetLength(1) - 1)
                        {
                            res.Add(direction + distanceIndex.ToString());
                        }
                        else if (carpark[i, j] != 0)
                        {
                            while (carpark[i + downIndex, stairIndex] == 1)
                            {
                                downIndex++;
                            } 
                            carpark[i + downIndex, stairIndex] = 2;
                            res.Add(direction + distanceIndex.ToString());
                            res.Add("D" + downIndex.ToString());
                            i =  i + --downIndex; // As looping already handle
                            break;
                        }
                    }
                }
                ResetWhenDescend();
            }
            // Code here
            return res.ToArray();
        }

        private void ResetWhenDescend()
        {
            direction = null;
            distanceIndex = 0;
            stairIndex = 0;
            downIndex = 1;
        }
    }
}